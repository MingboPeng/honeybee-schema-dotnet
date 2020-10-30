/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
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
    /// Used to describe the time period over which to run the simulation.
    /// </summary>
    [DataContract]
    public partial class RunPeriod : DatedBaseModel, IEquatable<RunPeriod>, IValidatableObject
    {

        /// <summary>
        /// Text for the day of the week on which the simulation starts.
        /// </summary>
        /// <value>Text for the day of the week on which the simulation starts.</value>
        [DataMember(Name="start_day_of_week", EmitDefaultValue=false)]
        public DaysOfWeek StartDayOfWeek { get; set; }   
        /// <summary>
        /// Initializes a new instance of the <see cref="RunPeriod" /> class.
        /// </summary>
        /// <param name="startDate">A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date..</param>
        /// <param name="endDate">A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date..</param>
        /// <param name="startDayOfWeek">Text for the day of the week on which the simulation starts..</param>
        /// <param name="holidays">A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied..</param>
        /// <param name="daylightSavingTime">A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation..</param>
        /// <param name="leapYear">Boolean noting whether the simulation will be run for a leap year. (default to false).</param>
        public RunPeriod
        (
             // Required parameters
            List<int> startDate= default, List<int> endDate= default, DaysOfWeek startDayOfWeek= default, List<List<int>> holidays= default, DaylightSavingTime daylightSavingTime= default, bool leapYear = false// Optional parameters
        ) : base()// BaseClass
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDayOfWeek = startDayOfWeek;
            this.Holidays = holidays;
            this.DaylightSavingTime = daylightSavingTime;
            // use default value if no "leapYear" provided
            this.LeapYear = leapYear ?? false;

            // Set non-required readonly properties with defaultValue
            this.Type = "RunPeriod";
        }
        
        /// <summary>
        /// A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date.
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the start of the run period. Must be before the end date.</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public List<int> StartDate { get; set; } 
        /// <summary>
        /// A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date.
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the end of the run period. Must be after the start date.</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public List<int> EndDate { get; set; } 
        /// <summary>
        /// A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied.
        /// </summary>
        /// <value>A list of lists where each sub-list consists of two integers for [month, day], representing a date which is a holiday within the simulation. If None, no holidays are applied.</value>
        [DataMember(Name="holidays", EmitDefaultValue=false)]
        public List<List<int>> Holidays { get; set; } 
        /// <summary>
        /// A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation.
        /// </summary>
        /// <value>A DaylightSavingTime to dictate the start and end dates of daylight saving time. If None, no daylight saving time is applied to the simulation.</value>
        [DataMember(Name="daylight_saving_time", EmitDefaultValue=false)]
        public DaylightSavingTime DaylightSavingTime { get; set; } 
        /// <summary>
        /// Boolean noting whether the simulation will be run for a leap year.
        /// </summary>
        /// <value>Boolean noting whether the simulation will be run for a leap year.</value>
        [DataMember(Name="leap_year", EmitDefaultValue=false)]
        public bool LeapYear { get; set; }  = false;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RunPeriod {iDd.Identifier}";
       
            return "RunPeriod";
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
            sb.Append("RunPeriod:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDayOfWeek: ").Append(StartDayOfWeek).Append("\n");
            sb.Append("  Holidays: ").Append(Holidays).Append("\n");
            sb.Append("  DaylightSavingTime: ").Append(DaylightSavingTime).Append("\n");
            sb.Append("  LeapYear: ").Append(LeapYear).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RunPeriod object</returns>
        public static RunPeriod FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RunPeriod>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RunPeriod object</returns>
        public RunPeriod DuplicateRunPeriod()
        {
            return Duplicate() as RunPeriod;
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
            return this.Equals(input as RunPeriod);
        }

        /// <summary>
        /// Returns true if RunPeriod instances are equal
        /// </summary>
        /// <param name="input">Instance of RunPeriod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunPeriod input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.StartDate == input.StartDate ||
                    this.StartDate != null &&
                    input.StartDate != null &&
                    this.StartDate.SequenceEqual(input.StartDate)
                ) && base.Equals(input) && 
                (
                    this.EndDate == input.EndDate ||
                    this.EndDate != null &&
                    input.EndDate != null &&
                    this.EndDate.SequenceEqual(input.EndDate)
                ) && base.Equals(input) && 
                (
                    this.StartDayOfWeek == input.StartDayOfWeek ||
                    (this.StartDayOfWeek != null &&
                    this.StartDayOfWeek.Equals(input.StartDayOfWeek))
                ) && base.Equals(input) && 
                (
                    this.Holidays == input.Holidays ||
                    this.Holidays != null &&
                    input.Holidays != null &&
                    this.Holidays.SequenceEqual(input.Holidays)
                ) && base.Equals(input) && 
                (
                    this.DaylightSavingTime == input.DaylightSavingTime ||
                    (this.DaylightSavingTime != null &&
                    this.DaylightSavingTime.Equals(input.DaylightSavingTime))
                ) && base.Equals(input) && 
                (
                    this.LeapYear == input.LeapYear ||
                    (this.LeapYear != null &&
                    this.LeapYear.Equals(input.LeapYear))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.StartDayOfWeek != null)
                    hashCode = hashCode * 59 + this.StartDayOfWeek.GetHashCode();
                if (this.Holidays != null)
                    hashCode = hashCode * 59 + this.Holidays.GetHashCode();
                if (this.DaylightSavingTime != null)
                    hashCode = hashCode * 59 + this.DaylightSavingTime.GetHashCode();
                if (this.LeapYear != null)
                    hashCode = hashCode * 59 + this.LeapYear.GetHashCode();
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
            Regex regexType = new Regex(@"^RunPeriod$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
