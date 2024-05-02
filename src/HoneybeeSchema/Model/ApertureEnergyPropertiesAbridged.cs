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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.")]
    [Serializable]
    [DataContract(Name = "ApertureEnergyPropertiesAbridged")]
    public partial class ApertureEnergyPropertiesAbridged : OpenAPIGenBaseModel, IEquatable<ApertureEnergyPropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Identifier of a WindowConstruction for the aperture. If None, the construction is set by the parent Room construction_set or the Model global_construction_set..</param>
        /// <param name="ventOpening">An optional VentilationOpening to specify the operable portion of the Aperture..</param>
        public ApertureEnergyPropertiesAbridged
        (
            // Required parameters
           string construction= default, VentilationOpening ventOpening= default// Optional parameters
        ) : base()// BaseClass
        {
            this.Construction = construction;
            this.VentOpening = ventOpening;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureEnergyPropertiesAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ApertureEnergyPropertiesAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ApertureEnergyPropertiesAbridged";

        /// <summary>
        /// Identifier of a WindowConstruction for the aperture. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.
        /// </summary>
        /// <value>Identifier of a WindowConstruction for the aperture. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.</value>
        [Summary(@"Identifier of a WindowConstruction for the aperture. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.")]
        [DataMember(Name = "construction")]
        public string Construction { get; set; } 
        /// <summary>
        /// An optional VentilationOpening to specify the operable portion of the Aperture.
        /// </summary>
        /// <value>An optional VentilationOpening to specify the operable portion of the Aperture.</value>
        [Summary(@"An optional VentilationOpening to specify the operable portion of the Aperture.")]
        [DataMember(Name = "vent_opening")]
        public VentilationOpening VentOpening { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ApertureEnergyPropertiesAbridged";
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
            sb.Append("ApertureEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Construction: ").Append(this.Construction).Append("\n");
            sb.Append("  VentOpening: ").Append(this.VentOpening).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureEnergyPropertiesAbridged object</returns>
        public static ApertureEnergyPropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureEnergyPropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureEnergyPropertiesAbridged object</returns>
        public virtual ApertureEnergyPropertiesAbridged DuplicateApertureEnergyPropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateApertureEnergyPropertiesAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateApertureEnergyPropertiesAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ApertureEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ApertureEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureEnergyPropertiesAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.Construction, input.Construction) && 
                    Extension.Equals(this.VentOpening, input.VentOpening);
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.VentOpening != null)
                    hashCode = hashCode * 59 + this.VentOpening.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }
            
            yield break;
        }
    }
}
