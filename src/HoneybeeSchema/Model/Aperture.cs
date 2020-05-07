/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.4
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
    /// Base class for all objects requiring a identifiers acceptable for all engines.
    /// </summary>
    [DataContract]
    public partial class Aperture : IDdBaseModel, IEquatable<Aperture>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Aperture" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Aperture() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Aperture" /> class.
        /// </summary>
        /// <param name="geometry">Planar Face3D for the geometry. (required).</param>
        /// <param name="boundaryCondition">boundaryCondition (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="isOperable">Boolean to note whether the Aperture can be opened for ventilation. (default to false).</param>
        /// <param name="indoorShades">Shades assigned to the interior side of this object (eg. window sill, light shelf)..</param>
        /// <param name="outdoorShades">Shades assigned to the exterior side of this object (eg. mullions, louvers)..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, rad). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters and not contain any spaces or special characters. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list)..</param>
        public Aperture
        (
            string identifier, Face3D geometry, AnyOf<Outdoors,Surface> boundaryCondition, AperturePropertiesAbridged properties, // Required parameters
            string displayName= default, Object userData= default, bool isOperable = false, List<Shade> indoorShades= default, List<Shade> outdoorShades= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName, userData: userData )// BaseClass
        {
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new InvalidDataException("geometry is a required property for Aperture and cannot be null");
            }
            else
            {
                this.Geometry = geometry;
            }
            
            // to ensure "boundaryCondition" is required (not null)
            if (boundaryCondition == null)
            {
                throw new InvalidDataException("boundaryCondition is a required property for Aperture and cannot be null");
            }
            else
            {
                this.BoundaryCondition = boundaryCondition;
            }
            
            // to ensure "properties" is required (not null)
            if (properties == null)
            {
                throw new InvalidDataException("properties is a required property for Aperture and cannot be null");
            }
            else
            {
                this.Properties = properties;
            }
            
            // use default value if no "isOperable" provided
            if (isOperable == null)
            {
                this.IsOperable = false;
            }
            else
            {
                this.IsOperable = isOperable;
            }
            this.IndoorShades = indoorShades;
            this.OutdoorShades = outdoorShades;

            // Set non-required readonly properties with defaultValue
            this.Type = "Aperture";
        }
        
        /// <summary>
        /// Planar Face3D for the geometry.
        /// </summary>
        /// <value>Planar Face3D for the geometry.</value>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        [JsonProperty("geometry")]
        public Face3D Geometry { get; set; } 
        /// <summary>
        /// Gets or Sets BoundaryCondition
        /// </summary>
        [DataMember(Name="boundary_condition", EmitDefaultValue=false)]
        [JsonProperty("boundary_condition")]
        public AnyOf<Outdoors,Surface> BoundaryCondition { get; set; } 
        /// <summary>
        /// Extension properties for particular simulation engines (Radiance, EnergyPlus).
        /// </summary>
        /// <value>Extension properties for particular simulation engines (Radiance, EnergyPlus).</value>
        [DataMember(Name="properties", EmitDefaultValue=false)]
        [JsonProperty("properties")]
        public AperturePropertiesAbridged Properties { get; set; } 
        /// <summary>
        /// Boolean to note whether the Aperture can be opened for ventilation.
        /// </summary>
        /// <value>Boolean to note whether the Aperture can be opened for ventilation.</value>
        [DataMember(Name="is_operable", EmitDefaultValue=false)]
        [JsonProperty("is_operable")]
        public bool IsOperable { get; set; }  = false;
        /// <summary>
        /// Shades assigned to the interior side of this object (eg. window sill, light shelf).
        /// </summary>
        /// <value>Shades assigned to the interior side of this object (eg. window sill, light shelf).</value>
        [DataMember(Name="indoor_shades", EmitDefaultValue=false)]
        [JsonProperty("indoor_shades")]
        public List<Shade> IndoorShades { get; set; } 
        /// <summary>
        /// Shades assigned to the exterior side of this object (eg. mullions, louvers).
        /// </summary>
        /// <value>Shades assigned to the exterior side of this object (eg. mullions, louvers).</value>
        [DataMember(Name="outdoor_shades", EmitDefaultValue=false)]
        [JsonProperty("outdoor_shades")]
        public List<Shade> OutdoorShades { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Aperture {iDd.Identifier}";
       
            return "Aperture";
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
            sb.Append("Aperture:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(UserData).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  BoundaryCondition: ").Append(BoundaryCondition).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  IsOperable: ").Append(IsOperable).Append("\n");
            sb.Append("  IndoorShades: ").Append(IndoorShades).Append("\n");
            sb.Append("  OutdoorShades: ").Append(OutdoorShades).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Aperture object</returns>
        public static Aperture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Aperture>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Aperture);
        }

        /// <summary>
        /// Returns true if Aperture instances are equal
        /// </summary>
        /// <param name="input">Instance of Aperture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Aperture input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && base.Equals(input) && 
                (
                    this.BoundaryCondition == input.BoundaryCondition ||
                    (this.BoundaryCondition != null &&
                    this.BoundaryCondition.Equals(input.BoundaryCondition))
                ) && base.Equals(input) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.IsOperable == input.IsOperable ||
                    (this.IsOperable != null &&
                    this.IsOperable.Equals(input.IsOperable))
                ) && base.Equals(input) && 
                (
                    this.IndoorShades == input.IndoorShades ||
                    this.IndoorShades != null &&
                    input.IndoorShades != null &&
                    this.IndoorShades.SequenceEqual(input.IndoorShades)
                ) && base.Equals(input) && 
                (
                    this.OutdoorShades == input.OutdoorShades ||
                    this.OutdoorShades != null &&
                    input.OutdoorShades != null &&
                    this.OutdoorShades.SequenceEqual(input.OutdoorShades)
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.BoundaryCondition != null)
                    hashCode = hashCode * 59 + this.BoundaryCondition.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.IsOperable != null)
                    hashCode = hashCode * 59 + this.IsOperable.GetHashCode();
                if (this.IndoorShades != null)
                    hashCode = hashCode * 59 + this.IndoorShades.GetHashCode();
                if (this.OutdoorShades != null)
                    hashCode = hashCode * 59 + this.OutdoorShades.GetHashCode();
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
            Regex regexType = new Regex(@"^Aperture$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
