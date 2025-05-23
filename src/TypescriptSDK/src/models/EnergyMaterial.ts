﻿import { IsNumber, IsDefined, Max, Min, IsString, IsOptional, Matches, IsEnum, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";
import { Roughness } from "./Roughness";

/** Opaque material representing a layer within an opaque construction. */
export class EnergyMaterial extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    @Max(3)
    /** Thickness of the material layer in meters. */
    thickness!: number;
	
    @IsNumber()
    @IsDefined()
    /** Thermal conductivity of the material layer in W/m-K. */
    conductivity!: number;
	
    @IsNumber()
    @IsDefined()
    /** Density of the material layer in kg/m3. */
    density!: number;
	
    @IsNumber()
    @IsDefined()
    @Min(100)
    /** Specific heat of the material layer in J/kg-K. */
    specific_heat!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^EnergyMaterial$/)
    /** Type */
    type?: string;
	
    @IsEnum(Roughness)
    @Type(() => String)
    @IsOptional()
    /** Roughness */
    roughness?: Roughness;
	
    @IsNumber()
    @IsOptional()
    @Max(0.99999)
    /** Fraction of incident long wavelength radiation that is absorbed by the material. Default: 0.9. */
    thermal_absorptance?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** Fraction of incident solar radiation absorbed by the material. Default: 0.7. */
    solar_absorptance?: number;
	
    @IsNumber()
    @IsOptional()
    @Min(0)
    @Max(1)
    /** Fraction of incident visible wavelength radiation absorbed by the material. Default: 0.7. */
    visible_absorptance?: number;
	

    constructor() {
        super();
        this.type = "EnergyMaterial";
        this.roughness = Roughness.MediumRough;
        this.thermal_absorptance = 0.9;
        this.solar_absorptance = 0.7;
        this.visible_absorptance = 0.7;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(EnergyMaterial, _data, { enableImplicitConversion: true });
            this.thickness = obj.thickness;
            this.conductivity = obj.conductivity;
            this.density = obj.density;
            this.specific_heat = obj.specific_heat;
            this.type = obj.type;
            this.roughness = obj.roughness;
            this.thermal_absorptance = obj.thermal_absorptance;
            this.solar_absorptance = obj.solar_absorptance;
            this.visible_absorptance = obj.visible_absorptance;
        }
    }


    static override fromJS(data: any): EnergyMaterial {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new EnergyMaterial();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["thickness"] = this.thickness;
        data["conductivity"] = this.conductivity;
        data["density"] = this.density;
        data["specific_heat"] = this.specific_heat;
        data["type"] = this.type;
        data["roughness"] = this.roughness;
        data["thermal_absorptance"] = this.thermal_absorptance;
        data["solar_absorptance"] = this.solar_absorptance;
        data["visible_absorptance"] = this.visible_absorptance;
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

