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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [Summary(@"Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.")]
    [Serializable]
    [DataContract(Name = "DaylightingControl")]
    public partial class DaylightingControl : OpenAPIGenBaseModel, IEquatable<DaylightingControl>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DaylightingControl" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DaylightingControl() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "DaylightingControl";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DaylightingControl" /> class.
        /// </summary>
        /// <param name="sensorPosition">A point as 3 (x, y, z) values for the position of the daylight sensor within the parent Room. This point should lie within the Room volume in order for the results to be meaningful. (required).</param>
        /// <param name="illuminanceSetpoint">A number for the illuminance setpoint in lux beyond which electric lights are dimmed if there is sufficient daylight. (default to 300D).</param>
        /// <param name="controlFraction">A number between 0 and 1 that represents the fraction of the Room lights that are dimmed when the illuminance at the sensor position is at the specified illuminance. 1 indicates that all lights are dim-able while 0 indicates that no lights are dim-able. Deeper rooms should have lower control fractions to account for the face that the lights in the back of the space do not dim in response to suitable daylight at the front of the room. (default to 1D).</param>
        /// <param name="minPowerInput">A number between 0 and 1 for the the lowest power the lighting system can dim down to, expressed as a fraction of maximum input power. (default to 0.3D).</param>
        /// <param name="minLightOutput">A number between 0 and 1 the lowest lighting output the lighting system can dim down to, expressed as a fraction of maximum light output. (default to 0.2D).</param>
        /// <param name="offAtMinimum">Boolean to note whether lights should switch off completely when they get to the minimum power input. (default to false).</param>
        public DaylightingControl
        (
           List<double> sensorPosition, // Required parameters
           double illuminanceSetpoint = 300D, double controlFraction = 1D, double minPowerInput = 0.3D, double minLightOutput = 0.2D, bool offAtMinimum = false// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "sensorPosition" is required (not null)
            this.SensorPosition = sensorPosition ?? throw new ArgumentNullException("sensorPosition is a required property for DaylightingControl and cannot be null");
            this.IlluminanceSetpoint = illuminanceSetpoint;
            this.ControlFraction = controlFraction;
            this.MinPowerInput = minPowerInput;
            this.MinLightOutput = minLightOutput;
            this.OffAtMinimum = offAtMinimum;

            // Set non-required readonly properties with defaultValue
            this.Type = "DaylightingControl";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(DaylightingControl))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "DaylightingControl";

        /// <summary>
        /// A point as 3 (x, y, z) values for the position of the daylight sensor within the parent Room. This point should lie within the Room volume in order for the results to be meaningful.
        /// </summary>
        /// <value>A point as 3 (x, y, z) values for the position of the daylight sensor within the parent Room. This point should lie within the Room volume in order for the results to be meaningful.</value>
        [Summary(@"A point as 3 (x, y, z) values for the position of the daylight sensor within the parent Room. This point should lie within the Room volume in order for the results to be meaningful.")]
        [DataMember(Name = "sensor_position", IsRequired = true)]
        public List<double> SensorPosition { get; set; } 
        /// <summary>
        /// A number for the illuminance setpoint in lux beyond which electric lights are dimmed if there is sufficient daylight.
        /// </summary>
        /// <value>A number for the illuminance setpoint in lux beyond which electric lights are dimmed if there is sufficient daylight.</value>
        [Summary(@"A number for the illuminance setpoint in lux beyond which electric lights are dimmed if there is sufficient daylight.")]
        [DataMember(Name = "illuminance_setpoint")]
        public double IlluminanceSetpoint { get; set; }  = 300D;
        /// <summary>
        /// A number between 0 and 1 that represents the fraction of the Room lights that are dimmed when the illuminance at the sensor position is at the specified illuminance. 1 indicates that all lights are dim-able while 0 indicates that no lights are dim-able. Deeper rooms should have lower control fractions to account for the face that the lights in the back of the space do not dim in response to suitable daylight at the front of the room.
        /// </summary>
        /// <value>A number between 0 and 1 that represents the fraction of the Room lights that are dimmed when the illuminance at the sensor position is at the specified illuminance. 1 indicates that all lights are dim-able while 0 indicates that no lights are dim-able. Deeper rooms should have lower control fractions to account for the face that the lights in the back of the space do not dim in response to suitable daylight at the front of the room.</value>
        [Summary(@"A number between 0 and 1 that represents the fraction of the Room lights that are dimmed when the illuminance at the sensor position is at the specified illuminance. 1 indicates that all lights are dim-able while 0 indicates that no lights are dim-able. Deeper rooms should have lower control fractions to account for the face that the lights in the back of the space do not dim in response to suitable daylight at the front of the room.")]
        [DataMember(Name = "control_fraction")]
        public double ControlFraction { get; set; }  = 1D;
        /// <summary>
        /// A number between 0 and 1 for the the lowest power the lighting system can dim down to, expressed as a fraction of maximum input power.
        /// </summary>
        /// <value>A number between 0 and 1 for the the lowest power the lighting system can dim down to, expressed as a fraction of maximum input power.</value>
        [Summary(@"A number between 0 and 1 for the the lowest power the lighting system can dim down to, expressed as a fraction of maximum input power.")]
        [DataMember(Name = "min_power_input")]
        public double MinPowerInput { get; set; }  = 0.3D;
        /// <summary>
        /// A number between 0 and 1 the lowest lighting output the lighting system can dim down to, expressed as a fraction of maximum light output.
        /// </summary>
        /// <value>A number between 0 and 1 the lowest lighting output the lighting system can dim down to, expressed as a fraction of maximum light output.</value>
        [Summary(@"A number between 0 and 1 the lowest lighting output the lighting system can dim down to, expressed as a fraction of maximum light output.")]
        [DataMember(Name = "min_light_output")]
        public double MinLightOutput { get; set; }  = 0.2D;
        /// <summary>
        /// Boolean to note whether lights should switch off completely when they get to the minimum power input.
        /// </summary>
        /// <value>Boolean to note whether lights should switch off completely when they get to the minimum power input.</value>
        [Summary(@"Boolean to note whether lights should switch off completely when they get to the minimum power input.")]
        [DataMember(Name = "off_at_minimum")]
        public bool OffAtMinimum { get; set; }  = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "DaylightingControl";
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
            sb.Append("DaylightingControl:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  SensorPosition: ").Append(this.SensorPosition).Append("\n");
            sb.Append("  IlluminanceSetpoint: ").Append(this.IlluminanceSetpoint).Append("\n");
            sb.Append("  ControlFraction: ").Append(this.ControlFraction).Append("\n");
            sb.Append("  MinPowerInput: ").Append(this.MinPowerInput).Append("\n");
            sb.Append("  MinLightOutput: ").Append(this.MinLightOutput).Append("\n");
            sb.Append("  OffAtMinimum: ").Append(this.OffAtMinimum).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>DaylightingControl object</returns>
        public static DaylightingControl FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<DaylightingControl>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>DaylightingControl object</returns>
        public virtual DaylightingControl DuplicateDaylightingControl()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateDaylightingControl();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateDaylightingControl();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as DaylightingControl);
        }

        /// <summary>
        /// Returns true if DaylightingControl instances are equal
        /// </summary>
        /// <param name="input">Instance of DaylightingControl to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DaylightingControl input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    this.SensorPosition == input.SensorPosition ||
                    Extension.AllEquals(this.SensorPosition, input.SensorPosition)
                ) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.IlluminanceSetpoint, input.IlluminanceSetpoint) && 
                    Extension.Equals(this.ControlFraction, input.ControlFraction) && 
                    Extension.Equals(this.MinPowerInput, input.MinPowerInput) && 
                    Extension.Equals(this.MinLightOutput, input.MinLightOutput) && 
                    Extension.Equals(this.OffAtMinimum, input.OffAtMinimum);
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
                if (this.SensorPosition != null)
                    hashCode = hashCode * 59 + this.SensorPosition.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IlluminanceSetpoint != null)
                    hashCode = hashCode * 59 + this.IlluminanceSetpoint.GetHashCode();
                if (this.ControlFraction != null)
                    hashCode = hashCode * 59 + this.ControlFraction.GetHashCode();
                if (this.MinPowerInput != null)
                    hashCode = hashCode * 59 + this.MinPowerInput.GetHashCode();
                if (this.MinLightOutput != null)
                    hashCode = hashCode * 59 + this.MinLightOutput.GetHashCode();
                if (this.OffAtMinimum != null)
                    hashCode = hashCode * 59 + this.OffAtMinimum.GetHashCode();
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
            Regex regexType = new Regex(@"^DaylightingControl$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // ControlFraction (double) maximum
            if(this.ControlFraction > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ControlFraction, must be a value less than or equal to 1.", new [] { "ControlFraction" });
            }

            // ControlFraction (double) minimum
            if(this.ControlFraction < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ControlFraction, must be a value greater than or equal to 0.", new [] { "ControlFraction" });
            }


            
            // MinPowerInput (double) maximum
            if(this.MinPowerInput > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinPowerInput, must be a value less than or equal to 1.", new [] { "MinPowerInput" });
            }

            // MinPowerInput (double) minimum
            if(this.MinPowerInput < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinPowerInput, must be a value greater than or equal to 0.", new [] { "MinPowerInput" });
            }


            
            // MinLightOutput (double) maximum
            if(this.MinLightOutput > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinLightOutput, must be a value less than or equal to 1.", new [] { "MinLightOutput" });
            }

            // MinLightOutput (double) minimum
            if(this.MinLightOutput < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinLightOutput, must be a value greater than or equal to 0.", new [] { "MinLightOutput" });
            }

            yield break;
        }
    }
}
