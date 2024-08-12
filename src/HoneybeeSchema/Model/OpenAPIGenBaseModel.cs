﻿/* 
 * Honeybee Schema
 *
 * Contact: info@ladybug.tools
 */

extern alias LBTNewtonSoft;
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonSoft::Newtonsoft.Json;
using LBTNewtonSoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    [Summary(@"")]
    [Serializable]
    [DataContract(Name = "_OpenAPIGenBaseModel")]
    public partial class OpenAPIGenBaseModel : IEquatable<OpenAPIGenBaseModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIGenBaseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public OpenAPIGenBaseModel
        (
            
        )
        {

            // Set readonly properties with defaultValue
            this.Type = "InvalidType";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(OpenAPIGenBaseModel))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A base class to use when there is no baseclass available to fall on.
        /// </summary>
        [Summary(@"A base class to use when there is no baseclass available to fall on.")]
        [DataMember(Name = "type")]
        public string Type { get; protected set; } = "InvalidType";


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "OpenAPIGenBaseModel";
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public virtual string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("OpenAPIGenBaseModel:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>OpenAPIGenBaseModel object</returns>
        public static OpenAPIGenBaseModel FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<OpenAPIGenBaseModel>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }


        public virtual string ToJson(bool indented = false)
        {
            var format = indented ? Formatting.Indented : Formatting.None;
            return JsonConvert.SerializeObject(this, format, JsonSetting.AnyOfConvertSetting);
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel object</returns>
        public virtual OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateOpenAPIGenBaseModel();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as OpenAPIGenBaseModel);
        }


        /// <summary>
        /// Returns true if OpenAPIGenBaseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenAPIGenBaseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenAPIGenBaseModel input)
        {
            if (input == null)
                return false;
            var isSame = base.Equals(input);
                  isSame =  Extension.Equals(this.Type, input.Type);
            return isSame;
        }


        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        public bool IsValid(bool throwException = false)
        {
            var res = this.Validate();
            var isValid = !res.Any();
            if (isValid)
                return true;

            var resMsgs = string.Join( "; ", res.Select(_ => _.ErrorMessage));
            if (throwException)
                throw new ArgumentException($"This is an invalid {this.Type} object! Error: {resMsgs}");
            else
                return false;
        }

        public IEnumerable<ValidationResult> Validate()
        {
            var vResults = new List<ValidationResult>();

            var vc = new ValidationContext(instance: this, serviceProvider: null, items: null);
            var isValid = Validator.TryValidateObject(instance: vc.ObjectInstance, validationContext: vc, validationResults: vResults, validateAllProperties: true);
            if (!isValid)
            {
                foreach (var validationResult in vResults)
                {
                    // skip Type
                    if (validationResult.MemberNames.Contains("Type") && validationResult.ErrorMessage.StartsWith("Invalid value for Type, must match a pattern of"))
                        continue;
                    yield return validationResult;
                }
            }

            yield break;
        }

    }
}
