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
    /// Specifies the data types and limits for values contained in schedules.
    /// </summary>
    [DataContract(Name = "ScheduleTypeLimit")]
    public partial class ScheduleTypeLimit : IEquatable<ScheduleTypeLimit>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets NumericType
        /// </summary>
        [DataMember(Name="numeric_type", EmitDefaultValue=false)]
        public ScheduleNumericType NumericType { get; set; } = ScheduleNumericType.Continuous;
        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unit_type", EmitDefaultValue=false)]
        public ScheduleUnitType UnitType { get; set; } = ScheduleUnitType.Dimensionless;
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTypeLimit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleTypeLimit() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleTypeLimit";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleTypeLimit" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="lowerLimit">Lower limit for the schedule type or NoLimit..</param>
        /// <param name="upperLimit">Upper limit for the schedule type or NoLimit..</param>
        /// <param name="numericType">numericType.</param>
        /// <param name="unitType">unitType.</param>
        public ScheduleTypeLimit
        (
             string identifier, // Required parameters
            string displayName= default, AnyOf<NoLimit,double> lowerLimit= default, AnyOf<NoLimit,double> upperLimit= default, ScheduleNumericType numericType= ScheduleNumericType.Continuous, ScheduleUnitType unitType= ScheduleUnitType.Dimensionless// Optional parameters
        )// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for ScheduleTypeLimit and cannot be null");
            this.DisplayName = displayName;
            this.LowerLimit = lowerLimit;
            this.UpperLimit = upperLimit;
            this.NumericType = numericType;
            this.UnitType = unitType;

            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleTypeLimit";
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public override string Type { get; protected internal set; }  = "ScheduleTypeLimit";

        /// <summary>
        /// Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).
        /// </summary>
        /// <value>Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t).</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Lower limit for the schedule type or NoLimit.
        /// </summary>
        /// <value>Lower limit for the schedule type or NoLimit.</value>
        [DataMember(Name = "lower_limit", EmitDefaultValue = false)]
        public AnyOf<NoLimit,double> LowerLimit { get; set; } 
        /// <summary>
        /// Upper limit for the schedule type or NoLimit.
        /// </summary>
        /// <value>Upper limit for the schedule type or NoLimit.</value>
        [DataMember(Name = "upper_limit", EmitDefaultValue = false)]
        public AnyOf<NoLimit,double> UpperLimit { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ScheduleTypeLimit";
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
            sb.Append("ScheduleTypeLimit:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  LowerLimit: ").Append(LowerLimit).Append("\n");
            sb.Append("  UpperLimit: ").Append(UpperLimit).Append("\n");
            sb.Append("  NumericType: ").Append(NumericType).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ScheduleTypeLimit object</returns>
        public static ScheduleTypeLimit FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ScheduleTypeLimit>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ScheduleTypeLimit object</returns>
        public virtual ScheduleTypeLimit DuplicateScheduleTypeLimit()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateScheduleTypeLimit();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ScheduleTypeLimit);
        }

        /// <summary>
        /// Returns true if ScheduleTypeLimit instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleTypeLimit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleTypeLimit input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.LowerLimit == input.LowerLimit ||
                    (this.LowerLimit != null &&
                    this.LowerLimit.Equals(input.LowerLimit))
                ) && 
                (
                    this.UpperLimit == input.UpperLimit ||
                    (this.UpperLimit != null &&
                    this.UpperLimit.Equals(input.UpperLimit))
                ) && 
                (
                    this.NumericType == input.NumericType ||
                    (this.NumericType != null &&
                    this.NumericType.Equals(input.NumericType))
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
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
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.LowerLimit != null)
                    hashCode = hashCode * 59 + this.LowerLimit.GetHashCode();
                if (this.UpperLimit != null)
                    hashCode = hashCode * 59 + this.UpperLimit.GetHashCode();
                if (this.NumericType != null)
                    hashCode = hashCode * 59 + this.NumericType.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
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

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ScheduleTypeLimit$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Identifier (string) maxLength
            if(this.Identifier != null && this.Identifier.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be less than 100.", new [] { "Identifier" });
            }

            // Identifier (string) minLength
            if(this.Identifier != null && this.Identifier.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identifier, length must be greater than 1.", new [] { "Identifier" });
            }
            
            yield break;
        }
    }
}
