﻿
using NJsonSchema;
using System.Collections.Generic;
using System.Linq;

namespace TemplateModels;

public class PropertyTemplateModel
{
    public string PropertyName { get; set; }
    public string Type { get; set; }
    public bool IsReadOnly { get; set; }
    public bool IsRequired { get; set; }
    public bool HasDescription => !string.IsNullOrEmpty(Description);
    public string Description { get; set; }
    public string ConvertToJavaScriptCode { get; set; } // for TS: property value to JS object
    public string ConvertToClassCode { get; set; } // for TS: JSON object to class property

    public bool IsAnyOf { get; set; }
    public List<JsonSchema> AnyOf { get; set; }

    public List<string> TsImports { get; set; } = new List<string>();
    public bool HasTsImports => TsImports.Any();
    public object? Default {  get; set; }
    public string DefaultCodeFormat { get; set; }
    public bool HasDefault => Default != null;

    public bool HasValidationDecorators => ValidationDecorators.Any();
    public List<string> ValidationDecorators { get; set; }

    public PropertyTemplateModel(string name, JsonSchemaProperty json)
    {
        
        PropertyName = name;
        Default = json.Default;
        DefaultCodeFormat = ConvertTsDefaultValue(Default);

        Description = json.Description;

        AnyOf = json.AnyOf?.ToList();
        IsAnyOf = (AnyOf?.Any()).GetValueOrDefault();
        IsReadOnly = json.IsReadOnly;
        IsRequired = json.IsRequired;

        // check types
        if (IsAnyOf)
        {
            var types = new List<string>();
            foreach (var item in AnyOf)
            {
                var typeName = string.Empty;
                if (item.HasReference)
                {
                    typeName = item.ActualSchema.Title;
                    AddTsInputTypes(typeName);
                }
                else
                {
                    typeName = item.Type.ToString();
                }
                types.Add(typeName);
            }

            var tps = types.Select(_=> ConvertToTypeScriptType(_)).ToList();
            Type = string.Join(" | ", tps);
        }
        else
        {
            if (json.IsArray)
            {
                var arrayItem = json.Item;
                var itemType = arrayItem.Type.ToString();
                if (arrayItem.HasReference)
                {
                    itemType = arrayItem.ActualSchema.Title;
                    AddTsInputTypes(itemType);
                }

                Type = $"{ConvertToTypeScriptType(itemType)} []"; 
            }
            else
            {
                var propType = json.Type.ToString();
                if (json.HasReference)
                {
                    propType = json.ActualSchema.Title;
                    AddTsInputTypes(propType);
                }
                Type = ConvertToTypeScriptType(propType);
            }
            
        }




        ConvertToJavaScriptCode = $"data[\"{PropertyName}\"] = this.{PropertyName};";
        ConvertToClassCode = Default == null ? $"this.{PropertyName} = _data[\"{PropertyName}\"];" : $"this.{PropertyName} = _data[\"{PropertyName}\"] !== undefined ? _data[\"{PropertyName}\"] : {DefaultCodeFormat};";

        //validation decorators
        ValidationDecorators = GetValidationDecorators(json);


    }

    public static string ConvertToTypeScriptType(string type)
    {
        return TsTypeMapper.TryGetValue(type, out var result)? result: type;
    }

    public static Dictionary<string, string> TsTypeMapper = new Dictionary<string, string>
    {
        {"String", "string" },
        {"Integer", "number" },
        {"Number", "number" },
        {"Boolean", "boolean" }
    };

    public static List<string> GetValidationDecorators(JsonSchemaProperty json)
    {
        var result = new List<string>();
        if (json.IsArray)
        {
            result.Add("@IsArray()");
            result.Add("@ValidateNested({ each: true })");
        }
        else
        {
            var propType = json.Type.ToString();
            if (json.HasReference)
            {
                //result.Add("@IsObject()");
                var refPropType = json.ActualSchema.Title;
                result.Add($"@IsInstance({refPropType})");
                result.Add("@ValidateNested()");
            }
            else if (propType == "Integer")
            {
                result.Add($"@IsInt()");
            }
            else if (propType == "Number")
            {
                result.Add($"@IsNumber()");
            }
            else if (propType == "String")
            {
                result.Add($"@IsString()");
            }
            else
            {
                //result.Add($"@IsObject()");
            }
        }

        if (json.IsRequired)
        {
            result.Add($"@IsDefined()");
        }
        else
        {
            result.Add($"@IsOptional()");
        }


        return result;
      
    }

    public void AddTsInputTypes(string type)
    {
        if (type == Type)
            return;
        TsImports.Add(type);
    }

    private static string ConvertTsDefaultValue(object? _defualt)
    {
        var _defaultCodeFormat = string.Empty;
        if (_defualt is string)
        {
            _defaultCodeFormat = $"\"{_defualt}\"";
        }
        else if (_defualt is Newtonsoft.Json.Linq.JObject jObj)
        {
            if (jObj.TryGetValue("type", out var vType))
            {
                _defaultCodeFormat = $"new {vType}();";
            }
        }
        else
        {
            _defaultCodeFormat = _defualt?.ToString();
        }

        return _defaultCodeFormat;
    }
}