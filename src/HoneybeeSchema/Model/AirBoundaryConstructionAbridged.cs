/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Construction for Air Boundary objects.
    /// </summary>
    [DataContract]
    public partial class AirBoundaryConstructionAbridged : IDdEnergyBaseModel, IEquatable<AirBoundaryConstructionAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstructionAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirBoundaryConstructionAbridged() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstructionAbridged" /> class.
        /// </summary>
        /// <param name="airMixingSchedule">Identifier of a fractional schedule for the air mixing schedule across the construction. (required).</param>
        /// <param name="airMixingPerArea">A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system. (default to 0.1D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public AirBoundaryConstructionAbridged
        (
            string identifier, string airMixingSchedule, // Required parameters
            string displayName= default, double airMixingPerArea = 0.1D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "airMixingSchedule" is required (not null)
            this.AirMixingSchedule = airMixingSchedule ?? throw new ArgumentNullException("airMixingSchedule is a required property for AirBoundaryConstructionAbridged and cannot be null");
            // use default value if no "airMixingPerArea" provided
            this.AirMixingPerArea = airMixingPerArea ?? 0.1D;

            // Set non-required readonly properties with defaultValue
            this.Type = "AirBoundaryConstructionAbridged";
        }
        
        /// <summary>
        /// Identifier of a fractional schedule for the air mixing schedule across the construction.
        /// </summary>
        /// <value>Identifier of a fractional schedule for the air mixing schedule across the construction.</value>
        [DataMember(Name="air_mixing_schedule", EmitDefaultValue=false)]
        public string AirMixingSchedule { get; set; } 
        /// <summary>
        /// A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.
        /// </summary>
        /// <value>A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.</value>
        [DataMember(Name="air_mixing_per_area", EmitDefaultValue=false)]
        public double AirMixingPerArea { get; set; }  = 0.1D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"AirBoundaryConstructionAbridged {iDd.Identifier}";
       
            return "AirBoundaryConstructionAbridged";
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
            sb.Append("AirBoundaryConstructionAbridged:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AirMixingSchedule: ").Append(AirMixingSchedule).Append("\n");
            sb.Append("  AirMixingPerArea: ").Append(AirMixingPerArea).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>AirBoundaryConstructionAbridged object</returns>
        public static AirBoundaryConstructionAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<AirBoundaryConstructionAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>AirBoundaryConstructionAbridged object</returns>
        public AirBoundaryConstructionAbridged DuplicateAirBoundaryConstructionAbridged()
        {
            return Duplicate() as AirBoundaryConstructionAbridged;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>HoneybeeObject</returns>
        public override HoneybeeObject Duplicate()
        {
            return FromJson(this.ToJson());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirBoundaryConstructionAbridged);
        }

        /// <summary>
        /// Returns true if AirBoundaryConstructionAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of AirBoundaryConstructionAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirBoundaryConstructionAbridged input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.AirMixingSchedule == input.AirMixingSchedule ||
                    (this.AirMixingSchedule != null &&
                    this.AirMixingSchedule.Equals(input.AirMixingSchedule))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.AirMixingPerArea == input.AirMixingPerArea ||
                    (this.AirMixingPerArea != null &&
                    this.AirMixingPerArea.Equals(input.AirMixingPerArea))
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
                if (this.AirMixingSchedule != null)
                    hashCode = hashCode * 59 + this.AirMixingSchedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AirMixingPerArea != null)
                    hashCode = hashCode * 59 + this.AirMixingPerArea.GetHashCode();
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
            // AirMixingSchedule (string) maxLength
            if(this.AirMixingSchedule != null && this.AirMixingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirMixingSchedule, length must be less than 100.", new [] { "AirMixingSchedule" });
            }

            // AirMixingSchedule (string) minLength
            if(this.AirMixingSchedule != null && this.AirMixingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirMixingSchedule, length must be greater than 1.", new [] { "AirMixingSchedule" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^AirBoundaryConstructionAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // AirMixingPerArea (double) minimum
            if(this.AirMixingPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirMixingPerArea, must be a value greater than or equal to 0.", new [] { "AirMixingPerArea" });
            }

            yield break;
        }
    }

}
