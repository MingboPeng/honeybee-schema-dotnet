﻿import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { BaseModifierSetAbridged } from "./BaseModifierSetAbridged";

/** Abridged set containing radiance modifiers needed for a model's Shade. */
export class ShadeModifierSetAbridged extends BaseModifierSetAbridged {
    @IsString()
    @IsOptional()
    @Matches(/^ShadeModifierSetAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ShadeModifierSetAbridged";
	

    constructor() {
        super();
        this.type = "ShadeModifierSetAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ShadeModifierSetAbridged, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.type = obj.type ?? "ShadeModifierSetAbridged";
        }
    }


    static override fromJS(data: any): ShadeModifierSetAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ShadeModifierSetAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ShadeModifierSetAbridged";
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
