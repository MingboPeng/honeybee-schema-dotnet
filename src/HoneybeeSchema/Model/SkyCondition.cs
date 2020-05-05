/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.27.3
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
    /// Used to specify sky conditions on a design day.
    /// </summary>
    [DataContract]
    public partial class SkyCondition : HoneybeeObject, IEquatable<SkyCondition>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SkyCondition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SkyCondition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SkyCondition" /> class.
        /// </summary>
        /// <param name="date">A list of two integers for [month, day], representing the date for the day of the year on which the design day occurs.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case). (required).</param>
        /// <param name="daylightSavings">Boolean to indicate whether daylight savings time is active on the design day. (default to false).</param>
        public SkyCondition
        (
             List<int> date, // Required parameters
            bool daylightSavings = false // Optional parameters
        )// BaseClass
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for SkyCondition and cannot be null");
            }
            else
            {
                this.Date = date;
            }
            
            // use default value if no "daylightSavings" provided
            if (daylightSavings == null)
            {
                this.DaylightSavings = false;
            }
            else
            {
                this.DaylightSavings = daylightSavings;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "_SkyCondition";
        }
        
        /// <summary>
        /// A list of two integers for [month, day], representing the date for the day of the year on which the design day occurs.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).
        /// </summary>
        /// <value>A list of two integers for [month, day], representing the date for the day of the year on which the design day occurs.A third integer may be added to denote whether the date should be re-serialized for a leap year (it should be a 1 in this case).</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonProperty("date")]
        public List<int> Date { get; set; }
        /// <summary>
        /// Boolean to indicate whether daylight savings time is active on the design day.
        /// </summary>
        /// <value>Boolean to indicate whether daylight savings time is active on the design day.</value>
        [DataMember(Name="daylight_savings", EmitDefaultValue=false)]
        [JsonProperty("daylight_savings")]
        public bool DaylightSavings { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SkyCondition {iDd.Identifier}";
       
            return "SkyCondition";
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
            sb.Append("SkyCondition:\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DaylightSavings: ").Append(DaylightSavings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SkyCondition object</returns>
        public static SkyCondition FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SkyCondition>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SkyCondition);
        }

        /// <summary>
        /// Returns true if SkyCondition instances are equal
        /// </summary>
        /// <param name="input">Instance of SkyCondition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SkyCondition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    this.Date != null &&
                    input.Date != null &&
                    this.Date.SequenceEqual(input.Date)
                ) && 
                (
                    this.DaylightSavings == input.DaylightSavings ||
                    (this.DaylightSavings != null &&
                    this.DaylightSavings.Equals(input.DaylightSavings))
                ) && 
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
                int hashCode = 41;
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.DaylightSavings != null)
                    hashCode = hashCode * 59 + this.DaylightSavings.GetHashCode();
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            // Type (string) pattern
            Regex regexType = new Regex(@"^_SkyCondition$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
