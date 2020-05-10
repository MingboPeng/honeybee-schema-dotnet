/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.5
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
    /// Used to specify a start date and a list of values for a period of analysis.
    /// </summary>
    [DataContract]
    public partial class ScheduleFixedInterval : IDdEnergyBaseModel, IEquatable<ScheduleFixedInterval>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleFixedInterval" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleFixedInterval() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleFixedInterval" /> class.
        /// </summary>
        /// <param name="values">A list of timeseries values occuring at each timestep over the course of the simulation. (required).</param>
        /// <param name="scheduleTypeLimit">ScheduleTypeLimit object that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur..</param>
        /// <param name="timestep">An integer for the number of steps per hour that the input values correspond to.  For example, if each value represents 30 minutes, the timestep is 2. For 15 minutes, it is 4. (default to 1).</param>
        /// <param name="startDate">A list of two integers for [month, day], representing the start date when the schedule values begin to take effect.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case)..</param>
        /// <param name="placeholderValue"> A value that will be used for all times not covered by the input values. Typically, your simulation should not need to use this value if the input values completely cover the simulation period. (default to 0D).</param>
        /// <param name="interpolate">Boolean to note whether values in between intervals should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them. (default to false).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ScheduleFixedInterval
        (
            string identifier, List<double> values, // Required parameters
            string displayName= default, ScheduleTypeLimit scheduleTypeLimit= default, int timestep = 1, List<int> startDate= default, double placeholderValue = 0D, bool interpolate = false// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for ScheduleFixedInterval and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            
            this.ScheduleTypeLimit = scheduleTypeLimit;
            // use default value if no "timestep" provided
            if (timestep == null)
            {
                this.Timestep = 1;
            }
            else
            {
                this.Timestep = timestep;
            }
            this.StartDate = startDate;
            // use default value if no "placeholderValue" provided
            if (placeholderValue == null)
            {
                this.PlaceholderValue = 0D;
            }
            else
            {
                this.PlaceholderValue = placeholderValue;
            }
            // use default value if no "interpolate" provided
            if (interpolate == null)
            {
                this.Interpolate = false;
            }
            else
            {
                this.Interpolate = interpolate;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleFixedInterval";
        }
        
        /// <summary>
        /// A list of timeseries values occuring at each timestep over the course of the simulation.
        /// </summary>
        /// <value>A list of timeseries values occuring at each timestep over the course of the simulation.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        [JsonProperty("values")]
        public List<double> Values { get; set; } 
        /// <summary>
        /// ScheduleTypeLimit object that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur.
        /// </summary>
        /// <value>ScheduleTypeLimit object that will be used to validate schedule values against upper/lower limits and assign units to the schedule values. If None, no validation will occur.</value>
        [DataMember(Name="schedule_type_limit", EmitDefaultValue=false)]
        [JsonProperty("schedule_type_limit")]
        public ScheduleTypeLimit ScheduleTypeLimit { get; set; } 
        /// <summary>
        /// An integer for the number of steps per hour that the input values correspond to.  For example, if each value represents 30 minutes, the timestep is 2. For 15 minutes, it is 4.
        /// </summary>
        /// <value>An integer for the number of steps per hour that the input values correspond to.  For example, if each value represents 30 minutes, the timestep is 2. For 15 minutes, it is 4.</value>
        [DataMember(Name="timestep", EmitDefaultValue=false)]
        [JsonProperty("timestep")]
        public int Timestep { get; set; }  = 1;
        /// <summary>
        /// A list of two integers for [month, day], representing the start date when the schedule values begin to take effect.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the start date when the schedule values begin to take effect.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        [JsonProperty("start_date")]
        public List<int> StartDate { get; set; } 
        /// <summary>
        ///  A value that will be used for all times not covered by the input values. Typically, your simulation should not need to use this value if the input values completely cover the simulation period.
        /// </summary>
        /// <value> A value that will be used for all times not covered by the input values. Typically, your simulation should not need to use this value if the input values completely cover the simulation period.</value>
        [DataMember(Name="placeholder_value", EmitDefaultValue=false)]
        [JsonProperty("placeholder_value")]
        public double PlaceholderValue { get; set; }  = 0D;
        /// <summary>
        /// Boolean to note whether values in between intervals should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them.
        /// </summary>
        /// <value>Boolean to note whether values in between intervals should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them.</value>
        [DataMember(Name="interpolate", EmitDefaultValue=false)]
        [JsonProperty("interpolate")]
        public bool Interpolate { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ScheduleFixedInterval {iDd.Identifier}";
       
            return "ScheduleFixedInterval";
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
            sb.Append("ScheduleFixedInterval:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  ScheduleTypeLimit: ").Append(ScheduleTypeLimit).Append("\n");
            sb.Append("  Timestep: ").Append(Timestep).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  PlaceholderValue: ").Append(PlaceholderValue).Append("\n");
            sb.Append("  Interpolate: ").Append(Interpolate).Append("\n");
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
        /// <returns>ScheduleFixedInterval object</returns>
        public static ScheduleFixedInterval FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ScheduleFixedInterval>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleFixedInterval);
        }

        /// <summary>
        /// Returns true if ScheduleFixedInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleFixedInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleFixedInterval input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.ScheduleTypeLimit == input.ScheduleTypeLimit ||
                    (this.ScheduleTypeLimit != null &&
                    this.ScheduleTypeLimit.Equals(input.ScheduleTypeLimit))
                ) && base.Equals(input) && 
                (
                    this.Timestep == input.Timestep ||
                    (this.Timestep != null &&
                    this.Timestep.Equals(input.Timestep))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate != null &&
                    input.StartDate != null &&
                    this.StartDate.SequenceEqual(input.StartDate)
                ) && base.Equals(input) && 
                (
                    this.PlaceholderValue == input.PlaceholderValue ||
                    (this.PlaceholderValue != null &&
                    this.PlaceholderValue.Equals(input.PlaceholderValue))
                ) && base.Equals(input) && 
                (
                    this.Interpolate == input.Interpolate ||
                    (this.Interpolate != null &&
                    this.Interpolate.Equals(input.Interpolate))
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ScheduleTypeLimit != null)
                    hashCode = hashCode * 59 + this.ScheduleTypeLimit.GetHashCode();
                if (this.Timestep != null)
                    hashCode = hashCode * 59 + this.Timestep.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.PlaceholderValue != null)
                    hashCode = hashCode * 59 + this.PlaceholderValue.GetHashCode();
                if (this.Interpolate != null)
                    hashCode = hashCode * 59 + this.Interpolate.GetHashCode();
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
            Regex regexType = new Regex(@"^ScheduleFixedInterval$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
