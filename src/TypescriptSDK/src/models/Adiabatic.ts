﻿import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** Base class for all objects that are not extensible with additional keys.\n\nThis effectively includes all objects except for the Properties classes\nthat are assigned to geometry objects. */
export class Adiabatic extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^Adiabatic$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "Adiabatic";
	

    constructor() {
        super();
        this.type = "Adiabatic";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Adiabatic, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.type = obj.type ?? "Adiabatic";
        }
    }


    static override fromJS(data: any): Adiabatic {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Adiabatic();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "Adiabatic";
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
