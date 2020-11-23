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
    /// Abridged set containing all modifiers needed to create a radiance model.
    /// </summary>
    [DataContract(Name = "ModifierSetAbridged")]
    public partial class ModifierSetAbridged : IEquatable<ModifierSetAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierSetAbridged" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifierSetAbridged() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ModifierSetAbridged";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierSetAbridged" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        /// <param name="wallSet">Optional WallModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="floorSet">Optional FloorModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="roofCeilingSet">Optional RoofCeilingModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="apertureSet">Optional ApertureModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="doorSet">Optional DoorModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="shadeSet">Optional ShadeModifierSet object for this ModifierSet (default: None)..</param>
        /// <param name="airBoundaryModifier">Optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier..</param>
        public ModifierSetAbridged
        (
             string identifier, // Required parameters
            string displayName= default, WallModifierSetAbridged wallSet= default, FloorModifierSetAbridged floorSet= default, RoofCeilingModifierSetAbridged roofCeilingSet= default, ApertureModifierSetAbridged apertureSet= default, DoorModifierSetAbridged doorSet= default, ShadeModifierSetAbridged shadeSet= default, string airBoundaryModifier= default// Optional parameters
        )// BaseClass
        {
            // to ensure "identifier" is required (not null)
            this.Identifier = identifier ?? throw new ArgumentNullException("identifier is a required property for ModifierSetAbridged and cannot be null");
            this.DisplayName = displayName;
            this.WallSet = wallSet;
            this.FloorSet = floorSet;
            this.RoofCeilingSet = roofCeilingSet;
            this.ApertureSet = apertureSet;
            this.DoorSet = doorSet;
            this.ShadeSet = shadeSet;
            this.AirBoundaryModifier = airBoundaryModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "ModifierSetAbridged";
        }

        /// <summary>
        /// Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files.
        /// </summary>
        /// <value>Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files.</value>
        [DataMember(Name = "identifier", IsRequired = true, EmitDefaultValue = false)]
        public string Identifier { get; set; } 
        /// <summary>
        /// Display name of the object with no character restrictions.
        /// </summary>
        /// <value>Display name of the object with no character restrictions.</value>
        [DataMember(Name = "display_name", EmitDefaultValue = false)]
        public string DisplayName { get; set; } 
        /// <summary>
        /// Optional WallModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional WallModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "wall_set", EmitDefaultValue = false)]
        public WallModifierSetAbridged WallSet { get; set; } 
        /// <summary>
        /// Optional FloorModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional FloorModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "floor_set", EmitDefaultValue = false)]
        public FloorModifierSetAbridged FloorSet { get; set; } 
        /// <summary>
        /// Optional RoofCeilingModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional RoofCeilingModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "roof_ceiling_set", EmitDefaultValue = false)]
        public RoofCeilingModifierSetAbridged RoofCeilingSet { get; set; } 
        /// <summary>
        /// Optional ApertureModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional ApertureModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "aperture_set", EmitDefaultValue = false)]
        public ApertureModifierSetAbridged ApertureSet { get; set; } 
        /// <summary>
        /// Optional DoorModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional DoorModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "door_set", EmitDefaultValue = false)]
        public DoorModifierSetAbridged DoorSet { get; set; } 
        /// <summary>
        /// Optional ShadeModifierSet object for this ModifierSet (default: None).
        /// </summary>
        /// <value>Optional ShadeModifierSet object for this ModifierSet (default: None).</value>
        [DataMember(Name = "shade_set", EmitDefaultValue = false)]
        public ShadeModifierSetAbridged ShadeSet { get; set; } 
        /// <summary>
        /// Optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier.
        /// </summary>
        /// <value>Optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier.</value>
        [DataMember(Name = "air_boundary_modifier", EmitDefaultValue = false)]
        public string AirBoundaryModifier { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ModifierSetAbridged";
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
            sb.Append("ModifierSetAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  WallSet: ").Append(WallSet).Append("\n");
            sb.Append("  FloorSet: ").Append(FloorSet).Append("\n");
            sb.Append("  RoofCeilingSet: ").Append(RoofCeilingSet).Append("\n");
            sb.Append("  ApertureSet: ").Append(ApertureSet).Append("\n");
            sb.Append("  DoorSet: ").Append(DoorSet).Append("\n");
            sb.Append("  ShadeSet: ").Append(ShadeSet).Append("\n");
            sb.Append("  AirBoundaryModifier: ").Append(AirBoundaryModifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModifierSetAbridged object</returns>
        public static ModifierSetAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ModifierSetAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ModifierSetAbridged object</returns>
        public virtual ModifierSetAbridged DuplicateModifierSetAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateModifierSetAbridged();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifierSetAbridged);
        }

        /// <summary>
        /// Returns true if ModifierSetAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifierSetAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifierSetAbridged input)
        {
            if (input == null)
                return false;
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.WallSet == input.WallSet ||
                    (this.WallSet != null &&
                    this.WallSet.Equals(input.WallSet))
                ) && 
                (
                    this.FloorSet == input.FloorSet ||
                    (this.FloorSet != null &&
                    this.FloorSet.Equals(input.FloorSet))
                ) && 
                (
                    this.RoofCeilingSet == input.RoofCeilingSet ||
                    (this.RoofCeilingSet != null &&
                    this.RoofCeilingSet.Equals(input.RoofCeilingSet))
                ) && 
                (
                    this.ApertureSet == input.ApertureSet ||
                    (this.ApertureSet != null &&
                    this.ApertureSet.Equals(input.ApertureSet))
                ) && 
                (
                    this.DoorSet == input.DoorSet ||
                    (this.DoorSet != null &&
                    this.DoorSet.Equals(input.DoorSet))
                ) && 
                (
                    this.ShadeSet == input.ShadeSet ||
                    (this.ShadeSet != null &&
                    this.ShadeSet.Equals(input.ShadeSet))
                ) && 
                (
                    this.AirBoundaryModifier == input.AirBoundaryModifier ||
                    (this.AirBoundaryModifier != null &&
                    this.AirBoundaryModifier.Equals(input.AirBoundaryModifier))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
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
                if (this.ShadeSet != null)
                    hashCode = hashCode * 59 + this.ShadeSet.GetHashCode();
                if (this.AirBoundaryModifier != null)
                    hashCode = hashCode * 59 + this.AirBoundaryModifier.GetHashCode();
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

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ModifierSetAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
