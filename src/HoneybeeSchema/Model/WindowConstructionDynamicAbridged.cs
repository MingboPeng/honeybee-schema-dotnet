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
    /// Construction for window objects with an included shade layer.
    /// </summary>
    [Summary(@"Construction for window objects with an included shade layer.")]
    [Serializable]
    [DataContract(Name = "WindowConstructionDynamicAbridged")]
    public partial class WindowConstructionDynamicAbridged : IDdEnergyBaseModel, IEquatable<WindowConstructionDynamicAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstructionDynamicAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowConstructionDynamicAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "WindowConstructionDynamicAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowConstructionDynamicAbridged" /> class.
        /// </summary>
        /// <param name="constructions">A list of WindowConstructionAbridged objects that define the various states that the dynamic window can assume. (required).</param>
        /// <param name="schedule">An identifier for a control schedule that dictates which constructions are active at given times throughout the simulation. The values of the schedule should be intergers and range from 0 to one less then the number of constructions. Zero indicates that the first construction is active, one indicates that the second on is active, etc. The schedule type limits of this schedule should be \&quot;Control Level.\&quot; If building custom schedule type limits that describe a particular range of states, the type limits should be \&quot;Discrete\&quot; and the unit type should be \&quot;Mode,\&quot; \&quot;Control,\&quot; or some other fractional unit. (required).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public WindowConstructionDynamicAbridged
        (
            string identifier, List<WindowConstructionAbridged> constructions, string schedule, // Required parameters
            string displayName= default, Object userData= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "constructions" is required (not null)
            this.Constructions = constructions ?? throw new ArgumentNullException("constructions is a required property for WindowConstructionDynamicAbridged and cannot be null");
            // to ensure "schedule" is required (not null)
            this.Schedule = schedule ?? throw new ArgumentNullException("schedule is a required property for WindowConstructionDynamicAbridged and cannot be null");

            // Set non-required readonly properties with defaultValue
            this.Type = "WindowConstructionDynamicAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(WindowConstructionDynamicAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "WindowConstructionDynamicAbridged";

        /// <summary>
        /// A list of WindowConstructionAbridged objects that define the various states that the dynamic window can assume.
        /// </summary>
        /// <value>A list of WindowConstructionAbridged objects that define the various states that the dynamic window can assume.</value>
        [Summary(@"A list of WindowConstructionAbridged objects that define the various states that the dynamic window can assume.")]
        [DataMember(Name = "constructions", IsRequired = true)]
        public List<WindowConstructionAbridged> Constructions { get; set; } 
        /// <summary>
        /// An identifier for a control schedule that dictates which constructions are active at given times throughout the simulation. The values of the schedule should be intergers and range from 0 to one less then the number of constructions. Zero indicates that the first construction is active, one indicates that the second on is active, etc. The schedule type limits of this schedule should be \&quot;Control Level.\&quot; If building custom schedule type limits that describe a particular range of states, the type limits should be \&quot;Discrete\&quot; and the unit type should be \&quot;Mode,\&quot; \&quot;Control,\&quot; or some other fractional unit.
        /// </summary>
        /// <value>An identifier for a control schedule that dictates which constructions are active at given times throughout the simulation. The values of the schedule should be intergers and range from 0 to one less then the number of constructions. Zero indicates that the first construction is active, one indicates that the second on is active, etc. The schedule type limits of this schedule should be \&quot;Control Level.\&quot; If building custom schedule type limits that describe a particular range of states, the type limits should be \&quot;Discrete\&quot; and the unit type should be \&quot;Mode,\&quot; \&quot;Control,\&quot; or some other fractional unit.</value>
        [Summary(@"An identifier for a control schedule that dictates which constructions are active at given times throughout the simulation. The values of the schedule should be intergers and range from 0 to one less then the number of constructions. Zero indicates that the first construction is active, one indicates that the second on is active, etc. The schedule type limits of this schedule should be \&quot;Control Level.\&quot; If building custom schedule type limits that describe a particular range of states, the type limits should be \&quot;Discrete\&quot; and the unit type should be \&quot;Mode,\&quot; \&quot;Control,\&quot; or some other fractional unit.")]
        [DataMember(Name = "schedule", IsRequired = true)]
        public string Schedule { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "WindowConstructionDynamicAbridged";
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
            sb.Append("WindowConstructionDynamicAbridged:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  Constructions: ").Append(this.Constructions).Append("\n");
            sb.Append("  Schedule: ").Append(this.Schedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowConstructionDynamicAbridged object</returns>
        public static WindowConstructionDynamicAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WindowConstructionDynamicAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowConstructionDynamicAbridged object</returns>
        public virtual WindowConstructionDynamicAbridged DuplicateWindowConstructionDynamicAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateWindowConstructionDynamicAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateWindowConstructionDynamicAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as WindowConstructionDynamicAbridged);
        }

        /// <summary>
        /// Returns true if WindowConstructionDynamicAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowConstructionDynamicAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowConstructionDynamicAbridged input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.Constructions == input.Constructions ||
                    Extension.AllEquals(this.Constructions, input.Constructions)
                ) && 
                    Extension.Equals(this.Schedule, input.Schedule) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.Constructions != null)
                    hashCode = hashCode * 59 + this.Constructions.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
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
            // Schedule (string) maxLength
            if(this.Schedule != null && this.Schedule.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be less than 100.", new [] { "Schedule" });
            }

            // Schedule (string) minLength
            if(this.Schedule != null && this.Schedule.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Schedule, length must be greater than 1.", new [] { "Schedule" });
            }
            

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^WindowConstructionDynamicAbridged$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
