﻿import { IsString, IsOptional, Matches, MinLength, MaxLength, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class ShadeMeshEnergyPropertiesAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^ShadeMeshEnergyPropertiesAbridged$/)
    /** Type */
    type?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of a ShadeConstruction to set the reflectance and specularity of the Shade. If None, it will be a generic context construction that is completely diffuse with 0.2 visible and solar reflectance. Unless it is building attached, in which case it will be set by the default generic ConstructionSet. */
    construction?: string;
	
    @IsString()
    @IsOptional()
    @MinLength(1)
    @MaxLength(100)
    /** Identifier of a schedule to set the transmittance of the shade, which can vary throughout the simulation. If None, the shade will be completely opaque. */
    transmittance_schedule?: string;
	

    constructor() {
        super();
        this.type = "ShadeMeshEnergyPropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ShadeMeshEnergyPropertiesAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.construction = obj.construction;
            this.transmittance_schedule = obj.transmittance_schedule;
        }
    }


    static override fromJS(data: any): ShadeMeshEnergyPropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ShadeMeshEnergyPropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["construction"] = this.construction;
        data["transmittance_schedule"] = this.transmittance_schedule;
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

