﻿import { IsNumber, IsDefined, Min, Max, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { IDdEnergyBaseModel } from "./IDdEnergyBaseModel";

/** Create single layer of custom gas. */
export class EnergyWindowMaterialGasCustom extends IDdEnergyBaseModel {
    @IsNumber()
    @IsDefined()
    /** The A coefficient for gas conductivity in W/(m-K). */
    conductivity_coeff_a!: number;
	
    @IsNumber()
    @IsDefined()
    /** The A coefficient for gas viscosity in kg/(m-s). */
    viscosity_coeff_a!: number;
	
    @IsNumber()
    @IsDefined()
    /** The A coefficient for gas specific heat in J/(kg-K). */
    specific_heat_coeff_a!: number;
	
    @IsNumber()
    @IsDefined()
    /** The specific heat ratio for gas. */
    specific_heat_ratio!: number;
	
    @IsNumber()
    @IsDefined()
    @Min(20)
    @Max(200)
    /** The molecular weight for gas in g/mol. */
    molecular_weight!: number;
	
    @IsString()
    @IsOptional()
    @Matches(/^EnergyWindowMaterialGasCustom$/)
    /** Type */
    type?: string;
	
    @IsNumber()
    @IsOptional()
    /** Thickness of the gas layer in meters. Default: 0.0125. */
    thickness?: number;
	
    @IsNumber()
    @IsOptional()
    /** The B coefficient for gas conductivity in W/(m-K2). */
    conductivity_coeff_b?: number;
	
    @IsNumber()
    @IsOptional()
    /** The C coefficient for gas conductivity in W/(m-K3). */
    conductivity_coeff_c?: number;
	
    @IsNumber()
    @IsOptional()
    /** The B coefficient for gas viscosity in kg/(m-s-K). */
    viscosity_coeff_b?: number;
	
    @IsNumber()
    @IsOptional()
    /** The C coefficient for gas viscosity in kg/(m-s-K2). */
    viscosity_coeff_c?: number;
	
    @IsNumber()
    @IsOptional()
    /** The B coefficient for gas specific heat in J/(kg-K2). */
    specific_heat_coeff_b?: number;
	
    @IsNumber()
    @IsOptional()
    /** The C coefficient for gas specific heat in J/(kg-K3). */
    specific_heat_coeff_c?: number;
	

    constructor() {
        super();
        this.type = "EnergyWindowMaterialGasCustom";
        this.thickness = 0.0125;
        this.conductivity_coeff_b = 0;
        this.conductivity_coeff_c = 0;
        this.viscosity_coeff_b = 0;
        this.viscosity_coeff_c = 0;
        this.specific_heat_coeff_b = 0;
        this.specific_heat_coeff_c = 0;
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(EnergyWindowMaterialGasCustom, _data, { enableImplicitConversion: true });
            this.conductivity_coeff_a = obj.conductivity_coeff_a;
            this.viscosity_coeff_a = obj.viscosity_coeff_a;
            this.specific_heat_coeff_a = obj.specific_heat_coeff_a;
            this.specific_heat_ratio = obj.specific_heat_ratio;
            this.molecular_weight = obj.molecular_weight;
            this.type = obj.type;
            this.thickness = obj.thickness;
            this.conductivity_coeff_b = obj.conductivity_coeff_b;
            this.conductivity_coeff_c = obj.conductivity_coeff_c;
            this.viscosity_coeff_b = obj.viscosity_coeff_b;
            this.viscosity_coeff_c = obj.viscosity_coeff_c;
            this.specific_heat_coeff_b = obj.specific_heat_coeff_b;
            this.specific_heat_coeff_c = obj.specific_heat_coeff_c;
        }
    }


    static override fromJS(data: any): EnergyWindowMaterialGasCustom {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new EnergyWindowMaterialGasCustom();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["conductivity_coeff_a"] = this.conductivity_coeff_a;
        data["viscosity_coeff_a"] = this.viscosity_coeff_a;
        data["specific_heat_coeff_a"] = this.specific_heat_coeff_a;
        data["specific_heat_ratio"] = this.specific_heat_ratio;
        data["molecular_weight"] = this.molecular_weight;
        data["type"] = this.type;
        data["thickness"] = this.thickness;
        data["conductivity_coeff_b"] = this.conductivity_coeff_b;
        data["conductivity_coeff_c"] = this.conductivity_coeff_c;
        data["viscosity_coeff_b"] = this.viscosity_coeff_b;
        data["viscosity_coeff_c"] = this.viscosity_coeff_c;
        data["specific_heat_coeff_b"] = this.specific_heat_coeff_b;
        data["specific_heat_coeff_c"] = this.specific_heat_coeff_c;
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

