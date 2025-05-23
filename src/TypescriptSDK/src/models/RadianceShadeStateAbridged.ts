﻿import { IsString, IsOptional, Matches, IsArray, IsInstance, ValidateNested, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { StateGeometryAbridged } from "./StateGeometryAbridged";

/** RadianceShadeStateAbridged represents a single state for a dynamic Shade. */
export class RadianceShadeStateAbridged extends _OpenAPIGenBaseModel {
    @IsString()
    @IsOptional()
    @Matches(/^RadianceShadeStateAbridged$/)
    /** Type */
    type?: string;
	
    @IsString()
    @IsOptional()
    /** A Radiance Modifier identifier (default: None). */
    modifier?: string;
	
    @IsString()
    @IsOptional()
    /** A Radiance Modifier identifier (default: None). */
    modifier_direct?: string;
	
    @IsArray()
    @IsInstance(StateGeometryAbridged, { each: true })
    @Type(() => StateGeometryAbridged)
    @ValidateNested({ each: true })
    @IsOptional()
    /** A list of StateGeometryAbridged objects (default: None). */
    shades?: StateGeometryAbridged[];
	

    constructor() {
        super();
        this.type = "RadianceShadeStateAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(RadianceShadeStateAbridged, _data, { enableImplicitConversion: true });
            this.type = obj.type;
            this.modifier = obj.modifier;
            this.modifier_direct = obj.modifier_direct;
            this.shades = obj.shades;
        }
    }


    static override fromJS(data: any): RadianceShadeStateAbridged {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new RadianceShadeStateAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["type"] = this.type;
        data["modifier"] = this.modifier;
        data["modifier_direct"] = this.modifier_direct;
        data["shades"] = this.shades;
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

