﻿import { IsEnum, IsDefined, IsString, Matches, MinLength, MaxLength, IsArray, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { GeometryObjectTypes } from "./GeometryObjectTypes";

export class DeletedObject extends _OpenAPIGenBaseModel {
    @IsEnum(GeometryObjectTypes)
    @Type(() => String)
    @IsDefined()
    /** Text for the type of object that has been changed. */
    element_type!: GeometryObjectTypes;
	
    @IsString()
    @IsDefined()
    @Matches(/^[^,;!\n\t]+$/)
    @MinLength(1)
    @MaxLength(100)
    /** Text string for the unique object ID that has changed. */
    element_id!: string;
	
    @IsArray()
    @IsDefined()
    /** A list of DisplayFace3D dictionaries for the deleted geometry. The schema of DisplayFace3D can be found in the ladybug-display-schema documentation (https://www.ladybug.tools/ladybug-display-schema) and these objects can be used to generate visualizations of individual objects that have been deleted. */
    geometry!: Object[];
	
    @IsString()
    @IsOptional()
    /** Text string for the display name of the object that has changed. */
    element_name?: string;
	
    @IsString()
    @IsOptional()
    @Matches(/^DeletedObject$/)
    /** Type */
    type?: string;
	

    constructor() {
        super();
        this.type = "DeletedObject";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(DeletedObject, _data, { enableImplicitConversion: true });
            this.element_type = obj.element_type;
            this.element_id = obj.element_id;
            this.geometry = obj.geometry;
            this.element_name = obj.element_name;
            this.type = obj.type;
        }
    }


    static override fromJS(data: any): DeletedObject {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new DeletedObject();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["element_type"] = this.element_type;
        data["element_id"] = this.element_id;
        data["geometry"] = this.geometry;
        data["element_name"] = this.element_name;
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

