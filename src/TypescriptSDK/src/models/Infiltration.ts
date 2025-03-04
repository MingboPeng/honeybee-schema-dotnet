﻿import { IsNumber, IsDefined, Min, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";
import { ScheduleFixedInterval } from "./ScheduleFixedInterval";
import { ScheduleRuleset } from "./ScheduleRuleset";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class Infiltration extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    @Min(0)
    /** Number for the infiltration per exterior surface area in m3/s-m2. */
    flow_per_exterior_area!: number;
	
    @IsDefined()
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'ScheduleRuleset') return ScheduleRuleset.fromJS(item);
      else if (item?.type === 'ScheduleFixedInterval') return ScheduleFixedInterval.fromJS(item);
      else return item;
    })
    /** The schedule for the infiltration over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the flow_per_exterior_area to yield a complete infiltration profile. */
    schedule!: (ScheduleRuleset | ScheduleFixedInterval);
	
    @IsString()
    @IsOptional()
    @Matches(/^Infiltration$/)
    /** Type */
    type?: string;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** ConstantCoefficient */
    constant_coefficient?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** TemperatureCoefficient */
    temperature_coefficient?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    /** VelocityCoefficient */
    velocity_coefficient?: number;
	

    constructor() {
        super();
        this.type = "Infiltration";
        this.constant_coefficient = 1;
        this.temperature_coefficient = 0;
        this.velocity_coefficient = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Infiltration, _data, { enableImplicitConversion: true });
            this.flow_per_exterior_area = obj.flow_per_exterior_area;
            this.schedule = obj.schedule;
            this.type = obj.type;
            this.constant_coefficient = obj.constant_coefficient;
            this.temperature_coefficient = obj.temperature_coefficient;
            this.velocity_coefficient = obj.velocity_coefficient;
        }
    }


    static override fromJS(data: any): Infiltration {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Infiltration();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["flow_per_exterior_area"] = this.flow_per_exterior_area;
        data["schedule"] = this.schedule;
        data["type"] = this.type;
        data["constant_coefficient"] = this.constant_coefficient;
        data["temperature_coefficient"] = this.temperature_coefficient;
        data["velocity_coefficient"] = this.velocity_coefficient;
        data = super.toJSON(data);
        return instanceToPlain(data);
    }

	async validate(): Promise<boolean> {
        const errors = await validate(this);
        if (errors.length > 0){
			const errorMessages = errors.map((error: TsValidationError) => Object.values(error.constraints || [error]).join(', ')).join('; ');
      		throw new Error(`Validation failed: ${errorMessages}`);
		}
        return true;
    }
}

