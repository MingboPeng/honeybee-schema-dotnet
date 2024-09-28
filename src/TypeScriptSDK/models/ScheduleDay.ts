﻿import { IsArray, IsNumber, IsDefined, IsString, IsOptional, Matches, IsBoolean, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { IsNestedIntegerArray } from "./../helpers/class-validator.ts";
import { EnergyBaseModel } from "./EnergyBaseModel.ts";

/** Used to describe the daily schedule for a single simulation day. */
export class ScheduleDay extends EnergyBaseModel {
    @IsArray()
    @IsNumber({},{ each: true })
    @IsDefined()
    /** A list of floats or integers for the values of the schedule. The length of this list must match the length of the times list. */
    values!: number [];
	
    @IsString()
    @IsOptional()
    @Matches(/^ScheduleDay$/)
    type?: string;
	
    @IsArray()
    @IsNestedIntegerArray()
    @IsOptional()
    /** A list of lists with each sub-list possessing 2 values for [hour, minute]. The length of the master list must match the length of the values list. Each time in the master list represents the time of day that the corresponding value begins to take effect. For example [(0,0), (9,0), (17,0)] in combination with the values [0, 1, 0] denotes a schedule value of 0 from 0:00 to 9:00, a value of 1 from 9:00 to 17:00 and 0 from 17:00 to the end of the day. Note that this representation of times as the ""time of beginning"" is a different convention than EnergyPlus, which uses ""time until"". */
    times?: number [] [];
	
    @IsBoolean()
    @IsOptional()
    /** Boolean to note whether values in between times should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corresponding to them. */
    interpolate?: boolean;
	

    constructor() {
        super();
        this.type = "ScheduleDay";
        this.times = [[0, 0]];
        this.interpolate = false;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ScheduleDay, _data, { enableImplicitConversion: true });
            this.values = obj.values;
            this.type = obj.type;
            this.times = obj.times;
            this.interpolate = obj.interpolate;
        }
    }


    static override fromJS(data: any): ScheduleDay {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ScheduleDay();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["values"] = this.values;
        data["type"] = this.type;
        data["times"] = this.times;
        data["interpolate"] = this.interpolate;
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

