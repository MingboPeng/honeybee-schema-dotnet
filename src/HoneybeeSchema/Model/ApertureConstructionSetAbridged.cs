/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonSoft; using System;
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
    /// <summary>
    /// A set of constructions for aperture assemblies.
    /// </summary>
    [Summary(@"A set of constructions for aperture assemblies.")]
    [Serializable]
    [DataContract(Name = "ApertureConstructionSetAbridged")]
    public partial class ApertureConstructionSetAbridged : OpenAPIGenBaseModel, IEquatable<ApertureConstructionSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureConstructionSetAbridged" /> class.
        /// </summary>
        /// <param name="interiorConstruction">Identifier for a WindowConstruction for all apertures with a Surface boundary condition..</param>
        /// <param name="windowConstruction">Identifier for a WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face..</param>
        /// <param name="skylightConstruction">Identifier for a WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face..</param>
        /// <param name="operableConstruction">Identifier for a WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property..</param>
        public ApertureConstructionSetAbridged
        (
            // Required parameters
           string interiorConstruction= default, string windowConstruction= default, string skylightConstruction= default, string operableConstruction= default// Optional parameters
        ) : base()// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.WindowConstruction = windowConstruction;
            this.SkylightConstruction = skylightConstruction;
            this.OperableConstruction = operableConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureConstructionSetAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ApertureConstructionSetAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ApertureConstructionSetAbridged";

        /// <summary>
        /// Identifier for a WindowConstruction for all apertures with a Surface boundary condition.
        /// </summary>
        /// <value>Identifier for a WindowConstruction for all apertures with a Surface boundary condition.</value>
        [Summary(@"Identifier for a WindowConstruction for all apertures with a Surface boundary condition.")]
        [DataMember(Name = "interior_construction")]
        public string InteriorConstruction { get; set; } 
        /// <summary>
        /// Identifier for a WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face.
        /// </summary>
        /// <value>Identifier for a WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face.</value>
        [Summary(@"Identifier for a WindowConstruction for apertures with an Outdoors boundary condition, False is_operable property, and a Wall face type for their parent face.")]
        [DataMember(Name = "window_construction")]
        public string WindowConstruction { get; set; } 
        /// <summary>
        /// Identifier for a WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.
        /// </summary>
        /// <value>Identifier for a WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.</value>
        [Summary(@"Identifier for a WindowConstruction for apertures with a Outdoors boundary condition, False is_operable property, and a RoofCeiling or Floor face type for their parent face.")]
        [DataMember(Name = "skylight_construction")]
        public string SkylightConstruction { get; set; } 
        /// <summary>
        /// Identifier for a WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property.
        /// </summary>
        /// <value>Identifier for a WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property.</value>
        [Summary(@"Identifier for a WindowConstruction for all apertures with an Outdoors boundary condition and True is_operable property.")]
        [DataMember(Name = "operable_construction")]
        public string OperableConstruction { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ApertureConstructionSetAbridged";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("ApertureConstructionSetAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  InteriorConstruction: ").Append(this.InteriorConstruction).Append("\n");
            sb.Append("  WindowConstruction: ").Append(this.WindowConstruction).Append("\n");
            sb.Append("  SkylightConstruction: ").Append(this.SkylightConstruction).Append("\n");
            sb.Append("  OperableConstruction: ").Append(this.OperableConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureConstructionSetAbridged object</returns>
        public static ApertureConstructionSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureConstructionSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureConstructionSetAbridged object</returns>
        public virtual ApertureConstructionSetAbridged DuplicateApertureConstructionSetAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateApertureConstructionSetAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateApertureConstructionSetAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ApertureConstructionSetAbridged);
        }

        /// <summary>
        /// Returns true if ApertureConstructionSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureConstructionSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureConstructionSetAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.InteriorConstruction, input.InteriorConstruction) && 
                    Extension.Equals(this.WindowConstruction, input.WindowConstruction) && 
                    Extension.Equals(this.SkylightConstruction, input.SkylightConstruction) && 
                    Extension.Equals(this.OperableConstruction, input.OperableConstruction);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InteriorConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorConstruction.GetHashCode();
                if (this.WindowConstruction != null)
                    hashCode = hashCode * 59 + this.WindowConstruction.GetHashCode();
                if (this.SkylightConstruction != null)
                    hashCode = hashCode * 59 + this.SkylightConstruction.GetHashCode();
                if (this.OperableConstruction != null)
                    hashCode = hashCode * 59 + this.OperableConstruction.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ApertureConstructionSetAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // InteriorConstruction (string) maxLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be less than 100.", new [] { "InteriorConstruction" });
            }

            // InteriorConstruction (string) minLength
            if(this.InteriorConstruction != null && this.InteriorConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InteriorConstruction, length must be greater than 1.", new [] { "InteriorConstruction" });
            }
            
            // WindowConstruction (string) maxLength
            if(this.WindowConstruction != null && this.WindowConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WindowConstruction, length must be less than 100.", new [] { "WindowConstruction" });
            }

            // WindowConstruction (string) minLength
            if(this.WindowConstruction != null && this.WindowConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WindowConstruction, length must be greater than 1.", new [] { "WindowConstruction" });
            }
            
            // SkylightConstruction (string) maxLength
            if(this.SkylightConstruction != null && this.SkylightConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SkylightConstruction, length must be less than 100.", new [] { "SkylightConstruction" });
            }

            // SkylightConstruction (string) minLength
            if(this.SkylightConstruction != null && this.SkylightConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SkylightConstruction, length must be greater than 1.", new [] { "SkylightConstruction" });
            }
            
            // OperableConstruction (string) maxLength
            if(this.OperableConstruction != null && this.OperableConstruction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperableConstruction, length must be less than 100.", new [] { "OperableConstruction" });
            }

            // OperableConstruction (string) minLength
            if(this.OperableConstruction != null && this.OperableConstruction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperableConstruction, length must be greater than 1.", new [] { "OperableConstruction" });
            }
            
            yield break;
        }
    }
}
