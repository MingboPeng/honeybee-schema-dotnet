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
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract(Name = "ProgramTypeAbridged")]
    public partial class ProgramTypeAbridged : IDdEnergyBaseModel, IEquatable<ProgramTypeAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramTypeAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProgramTypeAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ProgramTypeAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ProgramTypeAbridged" /> class.
        /// </summary>
        /// <param name="people">People to describe the occupancy of the program. If None, no occupancy will be assumed for the program..</param>
        /// <param name="lighting">Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program..</param>
        /// <param name="electricEquipment">ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed..</param>
        /// <param name="gasEquipment">GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed..</param>
        /// <param name="serviceHotWater">ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed..</param>
        /// <param name="infiltration">Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program..</param>
        /// <param name="ventilation">Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed..</param>
        /// <param name="setpoint">Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ProgramTypeAbridged
        (
            string identifier, // Required parameters
            string displayName= default, PeopleAbridged people= default, LightingAbridged lighting= default, ElectricEquipmentAbridged electricEquipment= default, GasEquipmentAbridged gasEquipment= default, ServiceHotWaterAbridged serviceHotWater= default, InfiltrationAbridged infiltration= default, VentilationAbridged ventilation= default, SetpointAbridged setpoint= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            this.People = people;
            this.Lighting = lighting;
            this.ElectricEquipment = electricEquipment;
            this.GasEquipment = gasEquipment;
            this.ServiceHotWater = serviceHotWater;
            this.Infiltration = infiltration;
            this.Ventilation = ventilation;
            this.Setpoint = setpoint;

            // Set non-required readonly properties with defaultValue
            this.Type = "ProgramTypeAbridged";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ProgramTypeAbridged))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ProgramTypeAbridged";

        /// <summary>
        /// People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.
        /// </summary>
        /// <value>People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.</value>
        [DataMember(Name = "people")]
        public PeopleAbridged People { get; set; } 
        /// <summary>
        /// Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.
        /// </summary>
        /// <value>Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.</value>
        [DataMember(Name = "lighting")]
        public LightingAbridged Lighting { get; set; } 
        /// <summary>
        /// ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.
        /// </summary>
        /// <value>ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.</value>
        [DataMember(Name = "electric_equipment")]
        public ElectricEquipmentAbridged ElectricEquipment { get; set; } 
        /// <summary>
        /// GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.
        /// </summary>
        /// <value>GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.</value>
        [DataMember(Name = "gas_equipment")]
        public GasEquipmentAbridged GasEquipment { get; set; } 
        /// <summary>
        /// ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed.
        /// </summary>
        /// <value>ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed.</value>
        [DataMember(Name = "service_hot_water")]
        public ServiceHotWaterAbridged ServiceHotWater { get; set; } 
        /// <summary>
        /// Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.
        /// </summary>
        /// <value>Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.</value>
        [DataMember(Name = "infiltration")]
        public InfiltrationAbridged Infiltration { get; set; } 
        /// <summary>
        /// Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.
        /// </summary>
        /// <value>Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.</value>
        [DataMember(Name = "ventilation")]
        public VentilationAbridged Ventilation { get; set; } 
        /// <summary>
        /// Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.
        /// </summary>
        /// <value>Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.</value>
        [DataMember(Name = "setpoint")]
        public SetpointAbridged Setpoint { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ProgramTypeAbridged";
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
            sb.Append("ProgramTypeAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  People: ").Append(People).Append("\n");
            sb.Append("  Lighting: ").Append(Lighting).Append("\n");
            sb.Append("  ElectricEquipment: ").Append(ElectricEquipment).Append("\n");
            sb.Append("  GasEquipment: ").Append(GasEquipment).Append("\n");
            sb.Append("  ServiceHotWater: ").Append(ServiceHotWater).Append("\n");
            sb.Append("  Infiltration: ").Append(Infiltration).Append("\n");
            sb.Append("  Ventilation: ").Append(Ventilation).Append("\n");
            sb.Append("  Setpoint: ").Append(Setpoint).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProgramTypeAbridged object</returns>
        public static ProgramTypeAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProgramTypeAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProgramTypeAbridged object</returns>
        public virtual ProgramTypeAbridged DuplicateProgramTypeAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateProgramTypeAbridged();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateProgramTypeAbridged();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ProgramTypeAbridged);
        }

        /// <summary>
        /// Returns true if ProgramTypeAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ProgramTypeAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProgramTypeAbridged input)
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
                    this.People == input.People ||
                    (this.People != null &&
                    this.People.Equals(input.People))
                ) && base.Equals(input) && 
                (
                    this.Lighting == input.Lighting ||
                    (this.Lighting != null &&
                    this.Lighting.Equals(input.Lighting))
                ) && base.Equals(input) && 
                (
                    this.ElectricEquipment == input.ElectricEquipment ||
                    (this.ElectricEquipment != null &&
                    this.ElectricEquipment.Equals(input.ElectricEquipment))
                ) && base.Equals(input) && 
                (
                    this.GasEquipment == input.GasEquipment ||
                    (this.GasEquipment != null &&
                    this.GasEquipment.Equals(input.GasEquipment))
                ) && base.Equals(input) && 
                (
                    this.ServiceHotWater == input.ServiceHotWater ||
                    (this.ServiceHotWater != null &&
                    this.ServiceHotWater.Equals(input.ServiceHotWater))
                ) && base.Equals(input) && 
                (
                    this.Infiltration == input.Infiltration ||
                    (this.Infiltration != null &&
                    this.Infiltration.Equals(input.Infiltration))
                ) && base.Equals(input) && 
                (
                    this.Ventilation == input.Ventilation ||
                    (this.Ventilation != null &&
                    this.Ventilation.Equals(input.Ventilation))
                ) && base.Equals(input) && 
                (
                    this.Setpoint == input.Setpoint ||
                    (this.Setpoint != null &&
                    this.Setpoint.Equals(input.Setpoint))
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
                if (this.People != null)
                    hashCode = hashCode * 59 + this.People.GetHashCode();
                if (this.Lighting != null)
                    hashCode = hashCode * 59 + this.Lighting.GetHashCode();
                if (this.ElectricEquipment != null)
                    hashCode = hashCode * 59 + this.ElectricEquipment.GetHashCode();
                if (this.GasEquipment != null)
                    hashCode = hashCode * 59 + this.GasEquipment.GetHashCode();
                if (this.ServiceHotWater != null)
                    hashCode = hashCode * 59 + this.ServiceHotWater.GetHashCode();
                if (this.Infiltration != null)
                    hashCode = hashCode * 59 + this.Infiltration.GetHashCode();
                if (this.Ventilation != null)
                    hashCode = hashCode * 59 + this.Ventilation.GetHashCode();
                if (this.Setpoint != null)
                    hashCode = hashCode * 59 + this.Setpoint.GetHashCode();
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
            Regex regexType = new Regex(@"^ProgramTypeAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
