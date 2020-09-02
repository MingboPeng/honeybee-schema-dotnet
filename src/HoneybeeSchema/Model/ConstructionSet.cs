/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.38.2
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
    /// A set of constructions for different surface types and boundary conditions.
    /// </summary>
    [DataContract]
    public partial class ConstructionSet : IDdEnergyBaseModel, IEquatable<ConstructionSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConstructionSet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructionSet" /> class.
        /// </summary>
        /// <param name="wallSet">A WallConstructionSet object for this ConstructionSet..</param>
        /// <param name="floorSet">A FloorConstructionSet object for this ConstructionSet..</param>
        /// <param name="roofCeilingSet">A RoofCeilingConstructionSet object for this ConstructionSet..</param>
        /// <param name="apertureSet">A ApertureConstructionSet object for this ConstructionSet..</param>
        /// <param name="doorSet">A DoorConstructionSet object for this ConstructionSet..</param>
        /// <param name="shadeConstruction">A ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned..</param>
        /// <param name="airBoundaryConstruction">An AirBoundaryConstruction to set the properties of Faces with an AirBoundary type..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ConstructionSet
        (
            string identifier, // Required parameters
            string displayName= default, WallConstructionSet wallSet= default, FloorConstructionSet floorSet= default, RoofCeilingConstructionSet roofCeilingSet= default, ApertureConstructionSet apertureSet= default, DoorConstructionSet doorSet= default, ShadeConstruction shadeConstruction= default, AirBoundaryConstruction airBoundaryConstruction= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.WallSet = wallSet;
            this.FloorSet = floorSet;
            this.RoofCeilingSet = roofCeilingSet;
            this.ApertureSet = apertureSet;
            this.DoorSet = doorSet;
            this.ShadeConstruction = shadeConstruction;
            this.AirBoundaryConstruction = airBoundaryConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "ConstructionSet";
        }
        
        /// <summary>
        /// A WallConstructionSet object for this ConstructionSet.
        /// </summary>
        /// <value>A WallConstructionSet object for this ConstructionSet.</value>
        [DataMember(Name="wall_set", EmitDefaultValue=false)]
        [JsonProperty("wall_set")]
        public WallConstructionSet WallSet { get; set; } 
        /// <summary>
        /// A FloorConstructionSet object for this ConstructionSet.
        /// </summary>
        /// <value>A FloorConstructionSet object for this ConstructionSet.</value>
        [DataMember(Name="floor_set", EmitDefaultValue=false)]
        [JsonProperty("floor_set")]
        public FloorConstructionSet FloorSet { get; set; } 
        /// <summary>
        /// A RoofCeilingConstructionSet object for this ConstructionSet.
        /// </summary>
        /// <value>A RoofCeilingConstructionSet object for this ConstructionSet.</value>
        [DataMember(Name="roof_ceiling_set", EmitDefaultValue=false)]
        [JsonProperty("roof_ceiling_set")]
        public RoofCeilingConstructionSet RoofCeilingSet { get; set; } 
        /// <summary>
        /// A ApertureConstructionSet object for this ConstructionSet.
        /// </summary>
        /// <value>A ApertureConstructionSet object for this ConstructionSet.</value>
        [DataMember(Name="aperture_set", EmitDefaultValue=false)]
        [JsonProperty("aperture_set")]
        public ApertureConstructionSet ApertureSet { get; set; } 
        /// <summary>
        /// A DoorConstructionSet object for this ConstructionSet.
        /// </summary>
        /// <value>A DoorConstructionSet object for this ConstructionSet.</value>
        [DataMember(Name="door_set", EmitDefaultValue=false)]
        [JsonProperty("door_set")]
        public DoorConstructionSet DoorSet { get; set; } 
        /// <summary>
        /// A ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.
        /// </summary>
        /// <value>A ShadeConstruction to set the reflectance properties of all outdoor shades of all objects to which this ConstructionSet is assigned.</value>
        [DataMember(Name="shade_construction", EmitDefaultValue=false)]
        [JsonProperty("shade_construction")]
        public ShadeConstruction ShadeConstruction { get; set; } 
        /// <summary>
        /// An AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.
        /// </summary>
        /// <value>An AirBoundaryConstruction to set the properties of Faces with an AirBoundary type.</value>
        [DataMember(Name="air_boundary_construction", EmitDefaultValue=false)]
        [JsonProperty("air_boundary_construction")]
        public AirBoundaryConstruction AirBoundaryConstruction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ConstructionSet {iDd.Identifier}";
       
            return "ConstructionSet";
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
            sb.Append("ConstructionSet:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WallSet: ").Append(WallSet).Append("\n");
            sb.Append("  FloorSet: ").Append(FloorSet).Append("\n");
            sb.Append("  RoofCeilingSet: ").Append(RoofCeilingSet).Append("\n");
            sb.Append("  ApertureSet: ").Append(ApertureSet).Append("\n");
            sb.Append("  DoorSet: ").Append(DoorSet).Append("\n");
            sb.Append("  ShadeConstruction: ").Append(ShadeConstruction).Append("\n");
            sb.Append("  AirBoundaryConstruction: ").Append(AirBoundaryConstruction).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ConstructionSet object</returns>
        public static ConstructionSet FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ConstructionSet>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ConstructionSet object</returns>
        public ConstructionSet DuplicateConstructionSet()
        {
            return Duplicate() as ConstructionSet;
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
            return this.Equals(input as ConstructionSet);
        }

        /// <summary>
        /// Returns true if ConstructionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ConstructionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConstructionSet input)
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
                    this.WallSet == input.WallSet ||
                    (this.WallSet != null &&
                    this.WallSet.Equals(input.WallSet))
                ) && base.Equals(input) && 
                (
                    this.FloorSet == input.FloorSet ||
                    (this.FloorSet != null &&
                    this.FloorSet.Equals(input.FloorSet))
                ) && base.Equals(input) && 
                (
                    this.RoofCeilingSet == input.RoofCeilingSet ||
                    (this.RoofCeilingSet != null &&
                    this.RoofCeilingSet.Equals(input.RoofCeilingSet))
                ) && base.Equals(input) && 
                (
                    this.ApertureSet == input.ApertureSet ||
                    (this.ApertureSet != null &&
                    this.ApertureSet.Equals(input.ApertureSet))
                ) && base.Equals(input) && 
                (
                    this.DoorSet == input.DoorSet ||
                    (this.DoorSet != null &&
                    this.DoorSet.Equals(input.DoorSet))
                ) && base.Equals(input) && 
                (
                    this.ShadeConstruction == input.ShadeConstruction ||
                    (this.ShadeConstruction != null &&
                    this.ShadeConstruction.Equals(input.ShadeConstruction))
                ) && base.Equals(input) && 
                (
                    this.AirBoundaryConstruction == input.AirBoundaryConstruction ||
                    (this.AirBoundaryConstruction != null &&
                    this.AirBoundaryConstruction.Equals(input.AirBoundaryConstruction))
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
                if (this.WallSet != null)
                    hashCode = hashCode * 59 + this.WallSet.GetHashCode();
                if (this.FloorSet != null)
                    hashCode = hashCode * 59 + this.FloorSet.GetHashCode();
                if (this.RoofCeilingSet != null)
                    hashCode = hashCode * 59 + this.RoofCeilingSet.GetHashCode();
                if (this.ApertureSet != null)
                    hashCode = hashCode * 59 + this.ApertureSet.GetHashCode();
                if (this.DoorSet != null)
                    hashCode = hashCode * 59 + this.DoorSet.GetHashCode();
                if (this.ShadeConstruction != null)
                    hashCode = hashCode * 59 + this.ShadeConstruction.GetHashCode();
                if (this.AirBoundaryConstruction != null)
                    hashCode = hashCode * 59 + this.AirBoundaryConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^ConstructionSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
