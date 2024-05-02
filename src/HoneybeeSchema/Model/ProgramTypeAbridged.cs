/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonSoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonSoft::Newtonsoft.Json;
using LBTNewtonSoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects requiring an EnergyPlus identifier and user_data.
    /// </summary>
    [Summary(@"Base class for all objects requiring an EnergyPlus identifier and user_data.")]
    [Serializable]
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
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public ProgramTypeAbridged
        (
            string identifier, // Required parameters
            string displayName= default, Object userData= default, PeopleAbridged people= default, LightingAbridged lighting= default, ElectricEquipmentAbridged electricEquipment= default, GasEquipmentAbridged gasEquipment= default, ServiceHotWaterAbridged serviceHotWater= default, InfiltrationAbridged infiltration= default, VentilationAbridged ventilation= default, SetpointAbridged setpoint= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
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
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ProgramTypeAbridged";

        /// <summary>
        /// People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.
        /// </summary>
        /// <value>People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.</value>
        [Summary(@"People to describe the occupancy of the program. If None, no occupancy will be assumed for the program.")]
        [DataMember(Name = "people")]
        public PeopleAbridged People { get; set; } 
        /// <summary>
        /// Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.
        /// </summary>
        /// <value>Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.</value>
        [Summary(@"Lighting to describe the lighting usage of the program. If None, no lighting will be assumed for the program.")]
        [DataMember(Name = "lighting")]
        public LightingAbridged Lighting { get; set; } 
        /// <summary>
        /// ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.
        /// </summary>
        /// <value>ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.</value>
        [Summary(@"ElectricEquipment to describe the usage of electric equipment within the program. If None, no electric equipment will be assumed.")]
        [DataMember(Name = "electric_equipment")]
        public ElectricEquipmentAbridged ElectricEquipment { get; set; } 
        /// <summary>
        /// GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.
        /// </summary>
        /// <value>GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.</value>
        [Summary(@"GasEquipment to describe the usage of gas equipment within the program. If None, no gas equipment will be assumed.")]
        [DataMember(Name = "gas_equipment")]
        public GasEquipmentAbridged GasEquipment { get; set; } 
        /// <summary>
        /// ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed.
        /// </summary>
        /// <value>ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed.</value>
        [Summary(@"ServiceHotWater object to describe the usage of hot water within the program. If None, no hot water will be assumed.")]
        [DataMember(Name = "service_hot_water")]
        public ServiceHotWaterAbridged ServiceHotWater { get; set; } 
        /// <summary>
        /// Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.
        /// </summary>
        /// <value>Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.</value>
        [Summary(@"Infiltration to describe the outdoor air leakage of the program. If None, no infiltration will be assumed for the program.")]
        [DataMember(Name = "infiltration")]
        public InfiltrationAbridged Infiltration { get; set; } 
        /// <summary>
        /// Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.
        /// </summary>
        /// <value>Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.</value>
        [Summary(@"Ventilation to describe the minimum outdoor air requirement of the program. If None, no ventilation requirement will be assumed.")]
        [DataMember(Name = "ventilation")]
        public VentilationAbridged Ventilation { get; set; } 
        /// <summary>
        /// Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.
        /// </summary>
        /// <value>Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.</value>
        [Summary(@"Setpoint object to describe the temperature and humidity setpoints of the program.  If None, the ProgramType cannot be assigned to a Room that is conditioned.")]
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
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  People: ").Append(this.People).Append("\n");
            sb.Append("  Lighting: ").Append(this.Lighting).Append("\n");
            sb.Append("  ElectricEquipment: ").Append(this.ElectricEquipment).Append("\n");
            sb.Append("  GasEquipment: ").Append(this.GasEquipment).Append("\n");
            sb.Append("  ServiceHotWater: ").Append(this.ServiceHotWater).Append("\n");
            sb.Append("  Infiltration: ").Append(this.Infiltration).Append("\n");
            sb.Append("  Ventilation: ").Append(this.Ventilation).Append("\n");
            sb.Append("  Setpoint: ").Append(this.Setpoint).Append("\n");
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
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.People, input.People) && 
                    Extension.Equals(this.Lighting, input.Lighting) && 
                    Extension.Equals(this.ElectricEquipment, input.ElectricEquipment) && 
                    Extension.Equals(this.GasEquipment, input.GasEquipment) && 
                    Extension.Equals(this.ServiceHotWater, input.ServiceHotWater) && 
                    Extension.Equals(this.Infiltration, input.Infiltration) && 
                    Extension.Equals(this.Ventilation, input.Ventilation) && 
                    Extension.Equals(this.Setpoint, input.Setpoint);
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
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
