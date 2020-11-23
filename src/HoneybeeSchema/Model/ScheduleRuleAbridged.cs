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
    /// Schedule rule including a ScheduleDay and when it should be applied..
    /// </summary>
    [DataContract(Name = "ScheduleRuleAbridged")]
    public partial class ScheduleRuleAbridged : IEquatable<ScheduleRuleAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRuleAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleRuleAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleRuleAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRuleAbridged" /> class.
        /// </summary>
        /// <param name="scheduleDay">The identifier of a ScheduleDay object associated with this rule. (required).</param>
        /// <param name="applySunday">Boolean noting whether to apply schedule_day on Sundays. (default to false).</param>
        /// <param name="applyMonday">Boolean noting whether to apply schedule_day on Mondays. (default to false).</param>
        /// <param name="applyTuesday">Boolean noting whether to apply schedule_day on Tuesdays. (default to false).</param>
        /// <param name="applyWednesday">Boolean noting whether to apply schedule_day on Wednesdays. (default to false).</param>
        /// <param name="applyThursday">Boolean noting whether to apply schedule_day on Thursdays. (default to false).</param>
        /// <param name="applyFriday">Boolean noting whether to apply schedule_day on Fridays. (default to false).</param>
        /// <param name="applySaturday">Boolean noting whether to apply schedule_day on Saturdays. (default to false).</param>
        /// <param name="startDate">A list of two integers for [month, day], representing the start date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case)..</param>
        /// <param name="endDate">A list of two integers for [month, day], representing the end date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case)..</param>
        public ScheduleRuleAbridged
        (
             string scheduleDay, // Required parameters
            bool applySunday = false, bool applyMonday = false, bool applyTuesday = false, bool applyWednesday = false, bool applyThursday = false, bool applyFriday = false, bool applySaturday = false, List<int> startDate= default, List<int> endDate= default// Optional parameters
        )// BaseClass
        {
            // to ensure "scheduleDay" is required (not null)
            this.ScheduleDay = scheduleDay ?? throw new ArgumentNullException("scheduleDay is a required property for ScheduleRuleAbridged and cannot be null");
            this.ApplySunday = applySunday;
            this.ApplyMonday = applyMonday;
            this.ApplyTuesday = applyTuesday;
            this.ApplyWednesday = applyWednesday;
            this.ApplyThursday = applyThursday;
            this.ApplyFriday = applyFriday;
            this.ApplySaturday = applySaturday;
            this.StartDate = startDate;
            this.EndDate = endDate;

            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleRuleAbridged";
        }

        /// <summary>
        /// The identifier of a ScheduleDay object associated with this rule.
        /// </summary>
        /// <value>The identifier of a ScheduleDay object associated with this rule.</value>
        [DataMember(Name = "schedule_day", IsRequired = true, EmitDefaultValue = false)]
        public string ScheduleDay { get; set; } 
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Sundays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Sundays.</value>
        [DataMember(Name = "apply_sunday", EmitDefaultValue = true)]
        public bool ApplySunday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Mondays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Mondays.</value>
        [DataMember(Name = "apply_monday", EmitDefaultValue = true)]
        public bool ApplyMonday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Tuesdays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Tuesdays.</value>
        [DataMember(Name = "apply_tuesday", EmitDefaultValue = true)]
        public bool ApplyTuesday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Wednesdays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Wednesdays.</value>
        [DataMember(Name = "apply_wednesday", EmitDefaultValue = true)]
        public bool ApplyWednesday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Thursdays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Thursdays.</value>
        [DataMember(Name = "apply_thursday", EmitDefaultValue = true)]
        public bool ApplyThursday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Fridays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Fridays.</value>
        [DataMember(Name = "apply_friday", EmitDefaultValue = true)]
        public bool ApplyFriday { get; set; }  = false;
        /// <summary>
        /// Boolean noting whether to apply schedule_day on Saturdays.
        /// </summary>
        /// <value>Boolean noting whether to apply schedule_day on Saturdays.</value>
        [DataMember(Name = "apply_saturday", EmitDefaultValue = true)]
        public bool ApplySaturday { get; set; }  = false;
        /// <summary>
        /// A list of two integers for [month, day], representing the start date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the start date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public List<int> StartDate { get; set; } 
        /// <summary>
        /// A list of two integers for [month, day], representing the end date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the end date of the period over which the schedule_day will be applied.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public List<int> EndDate { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ScheduleRuleAbridged";
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
            sb.Append("ScheduleRuleAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ScheduleDay: ").Append(ScheduleDay).Append("\n");
            sb.Append("  ApplySunday: ").Append(ApplySunday).Append("\n");
            sb.Append("  ApplyMonday: ").Append(ApplyMonday).Append("\n");
            sb.Append("  ApplyTuesday: ").Append(ApplyTuesday).Append("\n");
            sb.Append("  ApplyWednesday: ").Append(ApplyWednesday).Append("\n");
            sb.Append("  ApplyThursday: ").Append(ApplyThursday).Append("\n");
            sb.Append("  ApplyFriday: ").Append(ApplyFriday).Append("\n");
            sb.Append("  ApplySaturday: ").Append(ApplySaturday).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ScheduleRuleAbridged object</returns>
        public static ScheduleRuleAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ScheduleRuleAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ScheduleRuleAbridged object</returns>
        public virtual ScheduleRuleAbridged DuplicateScheduleRuleAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateScheduleRuleAbridged();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleRuleAbridged);
        }

        /// <summary>
        /// Returns true if ScheduleRuleAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleRuleAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleRuleAbridged input)
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
                    this.ScheduleDay == input.ScheduleDay ||
                    (this.ScheduleDay != null &&
                    this.ScheduleDay.Equals(input.ScheduleDay))
                ) && 
                (
                    this.ApplySunday == input.ApplySunday ||
                    (this.ApplySunday != null &&
                    this.ApplySunday.Equals(input.ApplySunday))
                ) && 
                (
                    this.ApplyMonday == input.ApplyMonday ||
                    (this.ApplyMonday != null &&
                    this.ApplyMonday.Equals(input.ApplyMonday))
                ) && 
                (
                    this.ApplyTuesday == input.ApplyTuesday ||
                    (this.ApplyTuesday != null &&
                    this.ApplyTuesday.Equals(input.ApplyTuesday))
                ) && 
                (
                    this.ApplyWednesday == input.ApplyWednesday ||
                    (this.ApplyWednesday != null &&
                    this.ApplyWednesday.Equals(input.ApplyWednesday))
                ) && 
                (
                    this.ApplyThursday == input.ApplyThursday ||
                    (this.ApplyThursday != null &&
                    this.ApplyThursday.Equals(input.ApplyThursday))
                ) && 
                (
                    this.ApplyFriday == input.ApplyFriday ||
                    (this.ApplyFriday != null &&
                    this.ApplyFriday.Equals(input.ApplyFriday))
                ) && 
                (
                    this.ApplySaturday == input.ApplySaturday ||
                    (this.ApplySaturday != null &&
                    this.ApplySaturday.Equals(input.ApplySaturday))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate != null &&
                    input.StartDate != null &&
                    this.StartDate.SequenceEqual(input.StartDate)
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    this.EndDate != null &&
                    input.EndDate != null &&
                    this.EndDate.SequenceEqual(input.EndDate)
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
                if (this.ScheduleDay != null)
                    hashCode = hashCode * 59 + this.ScheduleDay.GetHashCode();
                if (this.ApplySunday != null)
                    hashCode = hashCode * 59 + this.ApplySunday.GetHashCode();
                if (this.ApplyMonday != null)
                    hashCode = hashCode * 59 + this.ApplyMonday.GetHashCode();
                if (this.ApplyTuesday != null)
                    hashCode = hashCode * 59 + this.ApplyTuesday.GetHashCode();
                if (this.ApplyWednesday != null)
                    hashCode = hashCode * 59 + this.ApplyWednesday.GetHashCode();
                if (this.ApplyThursday != null)
                    hashCode = hashCode * 59 + this.ApplyThursday.GetHashCode();
                if (this.ApplyFriday != null)
                    hashCode = hashCode * 59 + this.ApplyFriday.GetHashCode();
                if (this.ApplySaturday != null)
                    hashCode = hashCode * 59 + this.ApplySaturday.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
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
            Regex regexType = new Regex(@"^ScheduleRuleAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // ScheduleDay (string) maxLength
            if(this.ScheduleDay != null && this.ScheduleDay.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScheduleDay, length must be less than 100.", new [] { "ScheduleDay" });
            }

            // ScheduleDay (string) minLength
            if(this.ScheduleDay != null && this.ScheduleDay.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ScheduleDay, length must be greater than 1.", new [] { "ScheduleDay" });
            }
            
            yield break;
        }
    }
}
