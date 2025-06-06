﻿import { IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";

/** Detailed HVAC system object defined using IronBug or OpenStudio .NET bindings. */
export class DetailedHVAC extends IDdEnergyBaseModel {
    @IsDefined()
    @Expose({ name: "specification" })
    /** A JSON-serializable dictionary representing the full specification of the detailed system. This can be obtained by calling the ToJson() method on any IronBug HVAC system and then serializing the resulting JSON string into a Python dictionary using the native Python json package. Note that the Rooms that the HVAC is assigned to must be specified as ThermalZones under this specification in order for the resulting Model this HVAC is a part of to be valid. */
    specification!: Object;
	
    @IsString()
    @IsOptional()
    @Matches(/^DetailedHVAC$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "DetailedHVAC";
	

    constructor() {
        super();
        this.type = "DetailedHVAC";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(DetailedHVAC, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.specification = obj.specification;
            this.type = obj.type ?? "DetailedHVAC";
        }
    }


    static override fromJS(data: any): DetailedHVAC {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new DetailedHVAC();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["specification"] = this.specification;
        data["type"] = this.type ?? "DetailedHVAC";
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
