﻿import { IsArray, IsNumber, IsDefined, IsString, IsOptional, Matches, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";

/** A single Radiance of sensors. */
export class Sensor extends _OpenAPIGenBaseModel {
    @IsArray()
    @IsNumber({},{ each: true })
    @IsDefined()
    /** Position of sensor in space as an array of (x, y, z) values. */
    pos!: number[];
	
    @IsArray()
    @IsNumber({},{ each: true })
    @IsDefined()
    /** Direction of sensor as an array of (x, y, z) values. */
    dir!: number[];
	
    @IsString()
    @IsOptional()
    @Matches(/^Sensor$/)
    /** Type */
    type?: string;
	

    constructor() {
        super();
        this.type = "Sensor";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(Sensor, _data, { enableImplicitConversion: true });
            this.pos = obj.pos;
            this.dir = obj.dir;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): Sensor {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new Sensor();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["pos"] = this.pos;
        data["dir"] = this.dir;
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

