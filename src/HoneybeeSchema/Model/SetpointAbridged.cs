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
    /// Used to specify information about the setpoint schedule.
    /// </summary>
    [Summary(@"Used to specify information about the setpoint schedule.")]
    [Serializable]
    [DataContract(Name = "SetpointAbridged")]
    public partial class SetpointAbridged : IDdEnergyBaseModel, IEquatable<SetpointAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetpointAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetpointAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "SetpointAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SetpointAbridged" /> class.
        /// </summary>
        /// <param name="coolingSchedule">Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C]. (required).</param>
        /// <param name="heatingSchedule">Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C]. (required).</param>
        /// <param name="humidifyingSchedule">Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%]..</param>
        /// <param name="dehumidifyingSchedule">Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%]..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public SetpointAbridged
        (
            string identifier, string coolingSchedule, string heatingSchedule, // Required parameters
            string displayName= default, Object userData= default, string humidifyingSchedule= default, string dehumidifyingSchedule= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "coolingSchedule" is required (not null)
            this.CoolingSchedule = coolingSchedule ?? throw new ArgumentNullException("coolingSchedule is a required property for SetpointAbridged and cannot be null");
            // to ensure "heatingSchedule" is required (not null)
            this.HeatingSchedule = heatingSchedule ?? throw new ArgumentNullException("heatingSchedule is a required property for SetpointAbridged and cannot be null");
            this.HumidifyingSchedule = humidifyingSchedule;
            this.DehumidifyingSchedule = dehumidifyingSchedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "SetpointAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(SetpointAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "SetpointAbridged";

        /// <summary>
        /// Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C].</value>
        [Summary(@"Identifier of the schedule for the cooling setpoint. The values in this schedule should be temperature in [C].")]
        [DataMember(Name = "cooling_schedule", IsRequired = true)]
        public string CoolingSchedule { get; set; } 
        /// <summary>
        /// Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C].</value>
        [Summary(@"Identifier of the schedule for the heating setpoint. The values in this schedule should be temperature in [C].")]
        [DataMember(Name = "heating_schedule", IsRequired = true)]
        public string HeatingSchedule { get; set; } 
        /// <summary>
        /// Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%].</value>
        [Summary(@"Identifier of the schedule for the humidification setpoint. The values in this schedule should be in [%].")]
        [DataMember(Name = "humidifying_schedule")]
        public string HumidifyingSchedule { get; set; } 
        /// <summary>
        /// Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%].</value>
        [Summary(@"Identifier of the schedule for the dehumidification setpoint. The values in this schedule should be in [%].")]
        [DataMember(Name = "dehumidifying_schedule")]
        public string DehumidifyingSchedule { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SetpointAbridged";
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
            sb.Append("SetpointAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  CoolingSchedule: ").Append(this.CoolingSchedule).Append("\n");
            sb.Append("  HeatingSchedule: ").Append(this.HeatingSchedule).Append("\n");
            sb.Append("  HumidifyingSchedule: ").Append(this.HumidifyingSchedule).Append("\n");
            sb.Append("  DehumidifyingSchedule: ").Append(this.DehumidifyingSchedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SetpointAbridged object</returns>
        public static SetpointAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SetpointAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SetpointAbridged object</returns>
        public virtual SetpointAbridged DuplicateSetpointAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSetpointAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateSetpointAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SetpointAbridged);
        }

        /// <summary>
        /// Returns true if SetpointAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of SetpointAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetpointAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.CoolingSchedule, input.CoolingSchedule) && 
                    Extension.Equals(this.HeatingSchedule, input.HeatingSchedule) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.HumidifyingSchedule, input.HumidifyingSchedule) && 
                    Extension.Equals(this.DehumidifyingSchedule, input.DehumidifyingSchedule);
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
                if (this.CoolingSchedule != null)
                    hashCode = hashCode * 59 + this.CoolingSchedule.GetHashCode();
                if (this.HeatingSchedule != null)
                    hashCode = hashCode * 59 + this.HeatingSchedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.HumidifyingSchedule.GetHashCode();
                if (this.DehumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.DehumidifyingSchedule.GetHashCode();
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
            // CoolingSchedule (string) maxLength
            if(this.CoolingSchedule != null && this.CoolingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingSchedule, length must be less than 100.", new [] { "CoolingSchedule" });
            }

            // CoolingSchedule (string) minLength
            if(this.CoolingSchedule != null && this.CoolingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CoolingSchedule, length must be greater than 1.", new [] { "CoolingSchedule" });
            }
            
            // HeatingSchedule (string) maxLength
            if(this.HeatingSchedule != null && this.HeatingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingSchedule, length must be less than 100.", new [] { "HeatingSchedule" });
            }

            // HeatingSchedule (string) minLength
            if(this.HeatingSchedule != null && this.HeatingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeatingSchedule, length must be greater than 1.", new [] { "HeatingSchedule" });
            }
            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^SetpointAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // HumidifyingSchedule (string) maxLength
            if(this.HumidifyingSchedule != null && this.HumidifyingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HumidifyingSchedule, length must be less than 100.", new [] { "HumidifyingSchedule" });
            }

            // HumidifyingSchedule (string) minLength
            if(this.HumidifyingSchedule != null && this.HumidifyingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HumidifyingSchedule, length must be greater than 1.", new [] { "HumidifyingSchedule" });
            }
            
            // DehumidifyingSchedule (string) maxLength
            if(this.DehumidifyingSchedule != null && this.DehumidifyingSchedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DehumidifyingSchedule, length must be less than 100.", new [] { "DehumidifyingSchedule" });
            }

            // DehumidifyingSchedule (string) minLength
            if(this.DehumidifyingSchedule != null && this.DehumidifyingSchedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DehumidifyingSchedule, length must be greater than 1.", new [] { "DehumidifyingSchedule" });
            }
            
            yield break;
        }
    }
}
