﻿import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _PropertiesBaseAbridged } from "./_PropertiesBaseAbridged";

/** Radiance Properties for Honeybee Face Abridged. */
export class FaceRadiancePropertiesAbridged extends _PropertiesBaseAbridged {
    @IsString()
    @IsOptional()
    @Matches(/^FaceRadiancePropertiesAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "FaceRadiancePropertiesAbridged";
	

    constructor() {
        super();
        this.type = "FaceRadiancePropertiesAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(FaceRadiancePropertiesAbridged, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.type = obj.type ?? "FaceRadiancePropertiesAbridged";
        }
    }


    static override fromJS(data: any): FaceRadiancePropertiesAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new FaceRadiancePropertiesAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "FaceRadiancePropertiesAbridged";
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
