﻿import { IsString, IsDefined, MinLength, MaxLength, IsNumber, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class InternalMassAbridged extends IDdEnergyBaseModel {
    @IsString()
    @IsDefined()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier for an OpaqueConstruction that represents the material that the internal thermal mass is composed of. */
    construction!: string;
	
    @IsNumber()
    @IsDefined()
    /** A number representing the surface area of the internal mass that is exposed to the Room air. This value should always be in square meters regardless of what units system the parent model is a part of. */
    area!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^InternalMassAbridged$/)
    /** Type */
    type?: string;
	

    constructor() {
        super();
        this.type = "InternalMassAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(InternalMassAbridged, _data, { enableImplicitConversion: true });
            this.construction = obj.construction;
            this.area = obj.area;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): InternalMassAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new InternalMassAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["construction"] = this.construction;
        data["area"] = this.area;
        data["type"] = this.type;
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

