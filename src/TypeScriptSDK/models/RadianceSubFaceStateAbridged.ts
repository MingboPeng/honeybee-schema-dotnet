﻿import { IsInstance, ValidateNested, IsOptional, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { Face3D } from "./Face3D";
import { RadianceShadeStateAbridged } from "./RadianceShadeStateAbridged";

/** RadianceSubFaceStateAbridged is an abridged state for a dynamic Aperture or Door.\n     */
export class RadianceSubFaceStateAbridged extends RadianceShadeStateAbridged {
    @IsInstance(Face3D)
    @Type(() => Face3D)
    @ValidateNested()
    @IsOptional()
    /** A Face3D for the view matrix geometry (default: None). */
    vmtx_geometry?: Face3D;
	
    @IsInstance(Face3D)
    @Type(() => Face3D)
    @ValidateNested()
    @IsOptional()
    /** A Face3D for the daylight matrix geometry (default: None). */
    dmtx_geometry?: Face3D;
	
    @IsString()
    @IsOptional()
    @Matches(/^RadianceSubFaceStateAbridged$/)
    type?: string;
	

    constructor() {
        super();
        this.type = "RadianceSubFaceStateAbridged";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(RadianceSubFaceStateAbridged, _data);
            this.vmtx_geometry = obj.vmtx_geometry;
            this.dmtx_geometry = obj.dmtx_geometry;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): RadianceSubFaceStateAbridged {
        data = typeof data === 'object' ? data : {};

        let result = new RadianceSubFaceStateAbridged();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["vmtx_geometry"] = this.vmtx_geometry;
        data["dmtx_geometry"] = this.dmtx_geometry;
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
