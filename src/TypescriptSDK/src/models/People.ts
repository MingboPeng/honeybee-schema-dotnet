﻿import { IsNumber, IsDefined, Min, IsString, IsOptional, Matches, Max, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { Autocalculate } from "./Autocalculate";
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";
import { ScheduleFixedInterval } from "./ScheduleFixedInterval";
import { ScheduleRuleset } from "./ScheduleRuleset";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class People extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    @Min(0)
    @Expose({ name: "people_per_area" })
    /** People per floor area expressed as [people/m2] */
    peoplePerArea!: number;
	
    @IsDefined()
    @Expose({ name: "occupancy_schedule" })
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'ScheduleRuleset') return ScheduleRuleset.fromJS(item);
      else if (item?.type === 'ScheduleFixedInterval') return ScheduleFixedInterval.fromJS(item);
      else return item;
    })
    /** A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile. */
    occupancySchedule!: (ScheduleRuleset | ScheduleFixedInterval);
	
    @IsString()
    @IsOptional()
    @Matches(/^People$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "People";
	
    @IsOptional()
    @Expose({ name: "activity_schedule" })
    @Transform(({ value }) => {
      const item = value;
      if (item?.type === 'ScheduleRuleset') return ScheduleRuleset.fromJS(item);
      else if (item?.type === 'ScheduleFixedInterval') return ScheduleFixedInterval.fromJS(item);
      else return item;
    })
    /** A schedule for the activity of the occupants over the course of the year. The type of this schedule should be ActivityLevel and the values of the schedule equal to the number of Watts given off by an individual person in the room. If None, a default constant schedule with 120 Watts per person will be used, which is typical of awake, adult humans who are seated. */
    activitySchedule?: (ScheduleRuleset | ScheduleFixedInterval);
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    @Expose({ name: "radiant_fraction" })
    /** The radiant fraction of sensible heat released by people. (Default: 0.3). */
    radiantFraction: number = 0.3;
	
    @IsOptional()
    @Expose({ name: "latent_fraction" })
    /** Number for the latent fraction of heat gain due to people or an Autocalculate object. */
    latentFraction: (Autocalculate | number) = new Autocalculate();
	

    constructor() {
        super();
        this.type = "People";
        this.radiantFraction = 0.3;
        this.latentFraction = new Autocalculate();
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(People, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.peoplePerArea = obj.peoplePerArea;
            this.occupancySchedule = obj.occupancySchedule;
            this.type = obj.type ?? "People";
            this.activitySchedule = obj.activitySchedule;
            this.radiantFraction = obj.radiantFraction ?? 0.3;
            this.latentFraction = obj.latentFraction ?? new Autocalculate();
        }
    }


    static override fromJS(data: any): People {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new People();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["people_per_area"] = this.peoplePerArea;
        data["occupancy_schedule"] = this.occupancySchedule;
        data["type"] = this.type ?? "People";
        data["activity_schedule"] = this.activitySchedule;
        data["radiant_fraction"] = this.radiantFraction ?? 0.3;
        data["latent_fraction"] = this.latentFraction ?? new Autocalculate();
        data = super.toJSON(data);
        return instanceToPlain(data, { exposeUnsetFields: false });
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
