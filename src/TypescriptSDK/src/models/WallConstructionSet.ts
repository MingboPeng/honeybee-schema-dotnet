﻿import { IsInstance, ValidateNested, IsOptional, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { OpaqueConstruction } from "./OpaqueConstruction";

/** A set of constructions for wall assemblies. */
export class WallConstructionSet extends _OpenAPIGenBaseModel {
    @IsInstance(OpaqueConstruction)
    @Type(() => OpaqueConstruction)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "interior_construction" })
    /** An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition. */
    interiorConstruction?: OpaqueConstruction;
	
    @IsInstance(OpaqueConstruction)
    @Type(() => OpaqueConstruction)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "exterior_construction" })
    /** An OpaqueConstruction for walls with an Outdoors boundary condition. */
    exteriorConstruction?: OpaqueConstruction;
	
    @IsInstance(OpaqueConstruction)
    @Type(() => OpaqueConstruction)
    @ValidateNested()
    @IsOptional()
    @Expose({ name: "ground_construction" })
    /** An OpaqueConstruction for walls with a Ground boundary condition. */
    groundConstruction?: OpaqueConstruction;
	
    @IsString()
    @IsOptional()
    @Matches(/^WallConstructionSet$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "WallConstructionSet";
	

    constructor() {
        super();
        this.type = "WallConstructionSet";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(WallConstructionSet, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.interiorConstruction = obj.interiorConstruction;
            this.exteriorConstruction = obj.exteriorConstruction;
            this.groundConstruction = obj.groundConstruction;
            this.type = obj.type ?? "WallConstructionSet";
        }
    }


    static override fromJS(data: any): WallConstructionSet {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new WallConstructionSet();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["interior_construction"] = this.interiorConstruction;
        data["exterior_construction"] = this.exteriorConstruction;
        data["ground_construction"] = this.groundConstruction;
        data["type"] = this.type ?? "WallConstructionSet";
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
