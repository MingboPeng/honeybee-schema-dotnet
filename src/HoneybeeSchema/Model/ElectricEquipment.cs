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
    /// Base class for all objects requiring an EnergyPlus identifier and user_data.
    /// </summary>
    [Serializable]
    [DataContract(Name = "ElectricEquipment")]
    public partial class ElectricEquipment : IDdEnergyBaseModel, IEquatable<ElectricEquipment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ElectricEquipment() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ElectricEquipment";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricEquipment" /> class.
        /// </summary>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2]. (required).</param>
        /// <param name="schedule">The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile. (required).</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0. (default to 0D).</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by electricequipment. Default value is 0. (default to 0D).</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0. (default to 0D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public ElectricEquipment
        (
            string identifier, double wattsPerArea, AnyOf<ScheduleRuleset,ScheduleFixedInterval> schedule, // Required parameters
            string displayName= default, Object userData= default, double radiantFraction = 0D, double latentFraction = 0D, double lostFraction = 0D // Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData)// BaseClass
        {
            this.WattsPerArea = wattsPerArea;
            // to ensure "schedule" is required (not null)
            this.Schedule = schedule ?? throw new ArgumentNullException("schedule is a required property for ElectricEquipment and cannot be null");
            this.RadiantFraction = radiantFraction;
            this.LatentFraction = latentFraction;
            this.LostFraction = lostFraction;

            // Set non-required readonly properties with defaultValue
            this.Type = "ElectricEquipment";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ElectricEquipment))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ElectricEquipment";

        /// <summary>
        /// Equipment level per floor area as [W/m2].
        /// </summary>
        /// <value>Equipment level per floor area as [W/m2].</value>
        [DataMember(Name = "watts_per_area", IsRequired = true)]
        public double WattsPerArea { get; set; } 
        /// <summary>
        /// The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.
        /// </summary>
        /// <value>The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.</value>
        [DataMember(Name = "schedule", IsRequired = true)]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> Schedule { get; set; } 
        /// <summary>
        /// Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of long-wave radiation heat given off by electric equipment. Default value is 0.</value>
        [DataMember(Name = "radiant_fraction")]
        public double RadiantFraction { get; set; }  = 0D;
        /// <summary>
        /// Number for the amount of latent heat given off by electricequipment. Default value is 0.
        /// </summary>
        /// <value>Number for the amount of latent heat given off by electricequipment. Default value is 0.</value>
        [DataMember(Name = "latent_fraction")]
        public double LatentFraction { get; set; }  = 0D;
        /// <summary>
        /// Number for the amount of “lost” heat being given off by equipment. The default value is 0.
        /// </summary>
        /// <value>Number for the amount of “lost” heat being given off by equipment. The default value is 0.</value>
        [DataMember(Name = "lost_fraction")]
        public double LostFraction { get; set; }  = 0D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ElectricEquipment";
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
            sb.Append("ElectricEquipment:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  WattsPerArea: ").Append(WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(LostFraction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ElectricEquipment object</returns>
        public static ElectricEquipment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ElectricEquipment>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ElectricEquipment object</returns>
        public virtual ElectricEquipment DuplicateElectricEquipment()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateElectricEquipment();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateElectricEquipment();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ElectricEquipment);
        }

        /// <summary>
        /// Returns true if ElectricEquipment instances are equal
        /// </summary>
        /// <param name="input">Instance of ElectricEquipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ElectricEquipment input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    Extension.Equals(this.WattsPerArea, input.WattsPerArea)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Schedule, input.Schedule)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.RadiantFraction, input.RadiantFraction)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.LatentFraction, input.LatentFraction)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.LostFraction, input.LostFraction)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Type, input.Type)
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
                if (this.WattsPerArea != null)
                    hashCode = hashCode * 59 + this.WattsPerArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                if (this.LostFraction != null)
                    hashCode = hashCode * 59 + this.LostFraction.GetHashCode();
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

            
            // WattsPerArea (double) minimum
            if(this.WattsPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WattsPerArea, must be a value greater than or equal to 0.", new [] { "WattsPerArea" });
            }


            
            // RadiantFraction (double) maximum
            if(this.RadiantFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value less than or equal to 1.", new [] { "RadiantFraction" });
            }

            // RadiantFraction (double) minimum
            if(this.RadiantFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RadiantFraction, must be a value greater than or equal to 0.", new [] { "RadiantFraction" });
            }


            
            // LatentFraction (double) maximum
            if(this.LatentFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value less than or equal to 1.", new [] { "LatentFraction" });
            }

            // LatentFraction (double) minimum
            if(this.LatentFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LatentFraction, must be a value greater than or equal to 0.", new [] { "LatentFraction" });
            }


            
            // LostFraction (double) maximum
            if(this.LostFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value less than or equal to 1.", new [] { "LostFraction" });
            }

            // LostFraction (double) minimum
            if(this.LostFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LostFraction, must be a value greater than or equal to 0.", new [] { "LostFraction" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ElectricEquipment$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
