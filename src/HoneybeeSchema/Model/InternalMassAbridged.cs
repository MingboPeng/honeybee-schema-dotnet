/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract(Name = "InternalMassAbridged")]
    public partial class InternalMassAbridged : IDdEnergyBaseModel, IEquatable<InternalMassAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMassAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InternalMassAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "InternalMassAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalMassAbridged" /> class.
        /// </summary>
        /// <param name="construction">Identifier for an OpaqueConstruction that represents the material that the internal thermal mass is composed of. (required).</param>
        /// <param name="area">A number representing the surface area of the internal mass that is exposed to the Room air. This value should always be in square meters regardless of what units system the parent model is a part of. (required).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public InternalMassAbridged
        (
            string identifier, string construction, double area, // Required parameters
            string displayName= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            // to ensure "construction" is required (not null)
            this.Construction = construction ?? throw new ArgumentNullException("construction is a required property for InternalMassAbridged and cannot be null");
            this.Area = area;

            // Set non-required readonly properties with defaultValue
            this.Type = "InternalMassAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(InternalMassAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "InternalMassAbridged";

        /// <summary>
        /// Identifier for an OpaqueConstruction that represents the material that the internal thermal mass is composed of.
        /// </summary>
        /// <value>Identifier for an OpaqueConstruction that represents the material that the internal thermal mass is composed of.</value>
        [DataMember(Name = "construction", IsRequired = true)]
        public string Construction { get; set; } 
        /// <summary>
        /// A number representing the surface area of the internal mass that is exposed to the Room air. This value should always be in square meters regardless of what units system the parent model is a part of.
        /// </summary>
        /// <value>A number representing the surface area of the internal mass that is exposed to the Room air. This value should always be in square meters regardless of what units system the parent model is a part of.</value>
        [DataMember(Name = "area", IsRequired = true)]
        public double Area { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "InternalMassAbridged";
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
            sb.Append("InternalMassAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>InternalMassAbridged object</returns>
        public static InternalMassAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<InternalMassAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>InternalMassAbridged object</returns>
        public virtual InternalMassAbridged DuplicateInternalMassAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateInternalMassAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateInternalMassAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as InternalMassAbridged);
        }

        /// <summary>
        /// Returns true if InternalMassAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of InternalMassAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternalMassAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
                ) && base.Equals(input) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                );
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^InternalMassAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}