﻿import { IsNumber, IsDefined, Min, IsString, MinLength, MaxLength, IsOptional, Matches, Max, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { Autocalculate } from "./Autocalculate";
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class PeopleAbridged extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    @Min(0)
    /** People per floor area expressed as [people/m2] */
    people_per_area!: number;
	
    @IsString()
    @IsDefined()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of a schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile. */
    occupancy_schedule!: string;
	
    @IsString()
    @IsOptional()
    @Matches(/^PeopleAbridged$/)
    /** Type */
    type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of a schedule for the activity of the occupants over the course of the year. The type of this schedule should be ActivityLevel and the values of the schedule equal to the number of Watts given off by an individual person in the room. If None, a default constant schedule with 120 Watts per person will be used, which is typical of awake, adult humans who are seated. */
    activity_schedule?: string;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** The radiant fraction of sensible heat released by people. (Default: 0.3). */
    radiant_fraction?: number;
	
    @IsOptional()
    /** Number for the latent fraction of heat gain due to people or an Autocalculate object. */
    latent_fraction?: (Autocalculate | number);
	

    constructor() {
        super();
        this.type = "PeopleAbridged";
        this.radiant_fraction = 0.3;
        this.latent_fraction = new Autocalculate();
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(PeopleAbridged, _data, { enableImplicitConversion: true });
            this.people_per_area = obj.people_per_area;
            this.occupancy_schedule = obj.occupancy_schedule;
            this.type = obj.type;
            this.activity_schedule = obj.activity_schedule;
            this.radiant_fraction = obj.radiant_fraction;
            this.latent_fraction = obj.latent_fraction;
        }
    }


    static override fromJS(data: any): PeopleAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new PeopleAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["people_per_area"] = this.people_per_area;
        data["occupancy_schedule"] = this.occupancy_schedule;
        data["type"] = this.type;
        data["activity_schedule"] = this.activity_schedule;
        data["radiant_fraction"] = this.radiant_fraction;
        data["latent_fraction"] = this.latent_fraction;
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

