﻿import { IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _EquipmentBase } from "./_EquipmentBase";

/** Base class for all objects requiring an EnergyPlus identifier and user_data. */
export class ElectricEquipmentAbridged extends _EquipmentBase {
    @IsString()
    @IsOptional()
    @Matches(/^ElectricEquipmentAbridged$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "ElectricEquipmentAbridged";
	

    constructor() {
        super();
        this.type = "ElectricEquipmentAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(ElectricEquipmentAbridged, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.type = obj.type ?? "ElectricEquipmentAbridged";
        }
    }


    static override fromJS(data: any): ElectricEquipmentAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new ElectricEquipmentAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type ?? "ElectricEquipmentAbridged";
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
