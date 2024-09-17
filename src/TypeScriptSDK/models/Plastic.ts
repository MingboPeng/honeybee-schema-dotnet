﻿import { IsOptional, IsArray, IsNumber, Min, Max, IsString, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain } from 'class-transformer';
import { BSDF } from "./BSDF";
import { Glass } from "./Glass";
import { Glow } from "./Glow";
import { Light } from "./Light";
import { Metal } from "./Metal";
import { Mirror } from "./Mirror";
import { ModifierBase } from "./ModifierBase";
import { Trans } from "./Trans";
import { Void } from "./Void";

/** Radiance plastic material. */
export class Plastic extends ModifierBase {
    @IsOptional()
    /** Material modifier. */
    modifier?: (Plastic | Glass | BSDF | Glow | Light | Trans | Metal | Void | Mirror);
	
    @IsArray()
    @IsOptional()
    /** List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers. */
    dependencies?: (Plastic | Glass | BSDF | Glow | Light | Trans | Metal | Void | Mirror) [];
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** A value between 0 and 1 for the red channel reflectance. */
    r_reflectance?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** A value between 0 and 1 for the green channel reflectance. */
    g_reflectance?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** A value between 0 and 1 for the blue channel reflectance. */
    b_reflectance?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials. */
    specularity?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** A value between 0 and 1 for the roughness, specified as the RMS slope of surface facets. Roughness greater than 0.2 are not realistic. */
    roughness?: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^Plastic$/)
    type?: string;
	

    constructor() {
        super();
        this.modifier = new Void();
        this.r_reflectance = 0;
        this.g_reflectance = 0;
        this.b_reflectance = 0;
        this.specularity = 0;
        this.roughness = 0;
        this.type = "Plastic";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Plastic, _data);
            this.modifier = obj.modifier;
            this.dependencies = obj.dependencies;
            this.r_reflectance = obj.r_reflectance;
            this.g_reflectance = obj.g_reflectance;
            this.b_reflectance = obj.b_reflectance;
            this.specularity = obj.specularity;
            this.roughness = obj.roughness;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): Plastic {
        data = typeof data === 'object' ? data : {};

        let result = new Plastic();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        for (var property in this) {
            if (this.hasOwnProperty(property))
                data[property] = this[property];
        }

        data["modifier"] = this.modifier;
        data["dependencies"] = this.dependencies;
        data["r_reflectance"] = this.r_reflectance;
        data["g_reflectance"] = this.g_reflectance;
        data["b_reflectance"] = this.b_reflectance;
        data["specularity"] = this.specularity;
        data["roughness"] = this.roughness;
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
