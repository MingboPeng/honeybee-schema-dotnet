/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.37.0
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
    /// A grid of sensors.
    /// </summary>
    [DataContract]
    public partial class SensorGrid : RadianceAsset, IEquatable<SensorGrid>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SensorGrid" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SensorGrid() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SensorGrid" /> class.
        /// </summary>
        /// <param name="sensors">A list of sensors that belong to the grid. (required).</param>
        /// <param name="mesh">An optional Mesh3D that aligns with the sensors and can be used for visualization of the grid. Note that the number of sensors in the grid must match the number of faces or the number vertices within the Mesh3D..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="roomIdentifier">Optional text string for the Room identifier to which this object belongs. This will be used to narrow down the number of aperture groups that have to be run with this sensor grid. If None, the grid will be run with all aperture groups in the model..</param>
        /// <param name="lightPath">Get or set a list of lists for the light path from the object to the sky. Each sub-list contains identifiers of aperture groups through which light passes. (eg. [[\&quot;SouthWindow1\&quot;], [\&quot;static_apertures\&quot;, \&quot;NorthWindow2\&quot;]]).Setting this property will override any auto-calculation of the light path from the model and room_identifier upon export to the simulation..</param>
        public SensorGrid
        (
            string identifier, List<Sensor> sensors, // Required parameters
            string displayName= default, string roomIdentifier= default, List<List<string>> lightPath= default, Mesh3D mesh= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, roomIdentifier: roomIdentifier, lightPath: lightPath)// BaseClass
        {
            // to ensure "sensors" is required (not null)
            if (sensors == null)
            {
                throw new InvalidDataException("sensors is a required property for SensorGrid and cannot be null");
            }
            else
            {
                this.Sensors = sensors;
            }
            
            this.Mesh = mesh;

            // Set non-required readonly properties with defaultValue
            this.Type = "SensorGrid";
        }
        
        /// <summary>
        /// A list of sensors that belong to the grid.
        /// </summary>
        /// <value>A list of sensors that belong to the grid.</value>
        [DataMember(Name="sensors", EmitDefaultValue=false)]
        [JsonProperty("sensors")]
        public List<Sensor> Sensors { get; set; } 
        /// <summary>
        /// An optional Mesh3D that aligns with the sensors and can be used for visualization of the grid. Note that the number of sensors in the grid must match the number of faces or the number vertices within the Mesh3D.
        /// </summary>
        /// <value>An optional Mesh3D that aligns with the sensors and can be used for visualization of the grid. Note that the number of sensors in the grid must match the number of faces or the number vertices within the Mesh3D.</value>
        [DataMember(Name="mesh", EmitDefaultValue=false)]
        [JsonProperty("mesh")]
        public Mesh3D Mesh { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SensorGrid {iDd.Identifier}";
       
            return "SensorGrid";
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
            sb.Append("SensorGrid:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  RoomIdentifier: ").Append(RoomIdentifier).Append("\n");
            sb.Append("  LightPath: ").Append(LightPath).Append("\n");
            sb.Append("  Sensors: ").Append(Sensors).Append("\n");
            sb.Append("  Mesh: ").Append(Mesh).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SensorGrid object</returns>
        public static SensorGrid FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SensorGrid>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SensorGrid object</returns>
        public SensorGrid DuplicateSensorGrid()
        {
            return Duplicate() as SensorGrid;
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
            return this.Equals(input as SensorGrid);
        }

        /// <summary>
        /// Returns true if SensorGrid instances are equal
        /// </summary>
        /// <param name="input">Instance of SensorGrid to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SensorGrid input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Sensors == input.Sensors ||
                    this.Sensors != null &&
                    input.Sensors != null &&
                    this.Sensors.SequenceEqual(input.Sensors)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Mesh == input.Mesh ||
                    (this.Mesh != null &&
                    this.Mesh.Equals(input.Mesh))
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
                if (this.Sensors != null)
                    hashCode = hashCode * 59 + this.Sensors.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Mesh != null)
                    hashCode = hashCode * 59 + this.Mesh.GetHashCode();
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
            Regex regexType = new Regex(@"^SensorGrid$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
