﻿import { IsEnum, IsDefined, IsString, Matches, MinLength, MaxLength, IsOptional, validate, ValidationError as TsValidationError } from 'class-validator';
import { Type, plainToClass, instanceToPlain, Expose, Transform } from 'class-transformer';
import { _OpenAPIGenBaseModel } from "./_OpenAPIGenBaseModel";
import { GeometryObjectTypes } from "./GeometryObjectTypes";

export class AddedInstruction extends _OpenAPIGenBaseModel {
    @IsEnum(GeometryObjectTypes)
    @Type(() => String)
    @IsDefined()
    @Expose({ name: "element_type" })
    /** Text for the type of object that has been changed. */
    elementType!: GeometryObjectTypes;
	
    @IsString()
    @IsDefined()
    @Matches(/^[^,;!\n\t]+$/)
    @MinLength(1)
    @MaxLength(100)
    @Expose({ name: "element_id" })
    /** Text string for the unique object ID that has changed. */
    elementId!: string;
	
    @IsString()
    @IsOptional()
    @Expose({ name: "element_name" })
    /** Text string for the display name of the object that has changed. */
    elementName?: string;
	
    @IsString()
    @IsOptional()
    @Matches(/^AddedInstruction$/)
    @Expose({ name: "type" })
    /** type */
    type: string = "AddedInstruction";
	

    constructor() {
        super();
        this.type = "AddedInstruction";
    }


    override init(_data?: any) {
        super.init(_data);
        if (_data) {
            const obj = plainToClass(AddedInstruction, _data, { enableImplicitConversion: true, exposeUnsetFields: false, exposeDefaultValues: true });
            this.elementType = obj.elementType;
            this.elementId = obj.elementId;
            this.elementName = obj.elementName;
            this.type = obj.type ?? "AddedInstruction";
        }
    }


    static override fromJS(data: any): AddedInstruction {
        data = typeof data === 'object' ? data : {};

        if (Array.isArray(data)) {
            const obj:any = {};
            for (var property in data) {
                obj[property] = data[property];
            }
            data = obj;
        }
        let result = new AddedInstruction();
        result.init(data);
        return result;
    }

	override toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["element_type"] = this.elementType;
        data["element_id"] = this.elementId;
        data["element_name"] = this.elementName;
        data["type"] = this.type ?? "AddedInstruction";
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
