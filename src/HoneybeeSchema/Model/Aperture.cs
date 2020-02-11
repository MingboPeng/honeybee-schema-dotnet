/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.16.1
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
    /// Base class for all objects requiring a valid names for all engines.
    /// </summary>
    [DataContract]
    public partial class Aperture :  IEquatable<Aperture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Aperture" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Aperture() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Aperture" /> class.
        /// </summary>
        /// <param name="name">Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters. (required).</param>
        /// <param name="geometry">Planar Face3D for the geometry. (required).</param>
        /// <param name="boundaryCondition">boundaryCondition (required).</param>
        /// <param name="properties">Extension properties for particular simulation engines (Radiance, EnergyPlus). (required).</param>
        /// <param name="displayName">Display name of the object with no restrictions..</param>
        /// <param name="type">type (default to &quot;Aperture&quot;).</param>
        /// <param name="isOperable">Boolean to note whether the Aperture can be opened for ventilation. (default to false).</param>
        /// <param name="indoorShades">Shades assigned to the interior side of this object (eg. window sill, light shelf)..</param>
        /// <param name="outdoorShades">Shades assigned to the exterior side of this object (eg. mullions, louvers)..</param>
        public Aperture(string name, Face3D geometry, AnyOf<Outdoors,Surface> boundaryCondition, AperturePropertiesAbridged properties, string displayName = default, string type = "Aperture", bool isOperable = false, List<Shade> indoorShades = default, List<Shade> outdoorShades = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Aperture and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
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
            
            this.DisplayName = displayName;
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "Aperture";
            }
            else
            {
                this.Type = type;
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
        }
        
        /// <summary>
        /// Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object used in all simulation engines. Must not contain spaces and use only letters, digits and underscores/dashes. It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

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
        /// Display name of the object with no restrictions.
        /// </summary>
        /// <value>Display name of the object with no restrictions.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Boolean to note whether the Aperture can be opened for ventilation.
        /// </summary>
        /// <value>Boolean to note whether the Aperture can be opened for ventilation.</value>
        [DataMember(Name="is_operable", EmitDefaultValue=false)]
        [JsonProperty("is_operable")]
        public bool IsOperable { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class Aperture {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  BoundaryCondition: ").Append(BoundaryCondition).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IsOperable: ").Append(IsOperable).Append("\n");
            sb.Append("  IndoorShades: ").Append(IndoorShades).Append("\n");
            sb.Append("  OutdoorShades: ").Append(OutdoorShades).Append("\n");
            sb.Append("}\n");
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
        /// <returns>Aperture object</returns>
        public static Aperture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Aperture>(json, new AnyOfJsonConverter());
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

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.BoundaryCondition == input.BoundaryCondition ||
                    (this.BoundaryCondition != null &&
                    this.BoundaryCondition.Equals(input.BoundaryCondition))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.IsOperable == input.IsOperable ||
                    (this.IsOperable != null &&
                    this.IsOperable.Equals(input.IsOperable))
                ) && 
                (
                    this.IndoorShades == input.IndoorShades ||
                    this.IndoorShades != null &&
                    input.IndoorShades != null &&
                    this.IndoorShades.SequenceEqual(input.IndoorShades)
                ) && 
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
                int hashCode = 41;
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.BoundaryCondition != null)
                    hashCode = hashCode * 59 + this.BoundaryCondition.GetHashCode();
                if (this.Properties != null)
                    hashCode = hashCode * 59 + this.Properties.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Name (string) pattern
            Regex regexName = new Regex(@"[A-Za-z0-9_-]", RegexOptions.CultureInvariant);
            if (false == regexName.Match(this.Name).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, must match a pattern of " + regexName, new [] { "Name" });
            }

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
