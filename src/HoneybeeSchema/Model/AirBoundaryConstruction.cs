/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.4
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
    public partial class AirBoundaryConstruction : IDdEnergyBaseModel, IEquatable<AirBoundaryConstruction>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstruction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AirBoundaryConstruction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AirBoundaryConstruction" /> class.
        /// </summary>
        /// <param name="airMixingSchedule">A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction. (required).</param>
        /// <param name="airMixingPerArea">A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system. (default to 0.1D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public AirBoundaryConstruction
        (
            string identifier, AnyOf<ScheduleRuleset,ScheduleFixedInterval> airMixingSchedule, // Required parameters
            string displayName= default, double airMixingPerArea = 0.1D// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "airMixingSchedule" is required (not null)
            if (airMixingSchedule == null)
            {
                throw new InvalidDataException("airMixingSchedule is a required property for AirBoundaryConstruction and cannot be null");
            }
            else
            {
                this.AirMixingSchedule = airMixingSchedule;
            }
            
            // use default value if no "airMixingPerArea" provided
            if (airMixingPerArea == null)
            {
                this.AirMixingPerArea = 0.1D;
            }
            else
            {
                this.AirMixingPerArea = airMixingPerArea;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "AirBoundaryConstruction";
        }
        
        /// <summary>
        /// A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction.
        /// </summary>
        /// <value>A fractional schedule as a ScheduleRuleset or ScheduleFixedInterval for the air mixing schedule across the construction.</value>
        [DataMember(Name="air_mixing_schedule", EmitDefaultValue=false)]
        [JsonProperty("air_mixing_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> AirMixingSchedule { get; set; } 
        /// <summary>
        /// A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.
        /// </summary>
        /// <value>A positive number for the amount of air mixing between Rooms across the air boundary surface [m3/s-m2]. Default: 0.1 corresponds to average indoor air speeds of 0.1 m/s (roughly 20 fpm), which is typical of what would be induced by a HVAC system.</value>
        [DataMember(Name="air_mixing_per_area", EmitDefaultValue=false)]
        [JsonProperty("air_mixing_per_area")]
        public double AirMixingPerArea { get; set; }  = 0.1D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"AirBoundaryConstruction {iDd.Identifier}";
       
            return "AirBoundaryConstruction";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("AirBoundaryConstruction:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AirMixingSchedule: ").Append(AirMixingSchedule).Append("\n");
            sb.Append("  AirMixingPerArea: ").Append(AirMixingPerArea).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>AirBoundaryConstruction object</returns>
        public static AirBoundaryConstruction FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AirBoundaryConstruction>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AirBoundaryConstruction);
        }

        /// <summary>
        /// Returns true if AirBoundaryConstruction instances are equal
        /// </summary>
        /// <param name="input">Instance of AirBoundaryConstruction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AirBoundaryConstruction input)
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^AirBoundaryConstruction$", RegexOptions.CultureInvariant);
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
