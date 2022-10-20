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
    /// Set containing all radiance modifiers needed to create a radiance model.
    /// </summary>
    [Summary(@"Set containing all radiance modifiers needed to create a radiance model.")]
    [Serializable]
    [DataContract(Name = "ModifierSet")]
    public partial class ModifierSet : IDdRadianceBaseModel, IEquatable<ModifierSet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierSet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModifierSet() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "ModifierSet";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ModifierSet" /> class.
        /// </summary>
        /// <param name="wallSet">An optional WallModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="floorSet">An optional FloorModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="roofCeilingSet">An optional RoofCeilingModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="apertureSet">An optional ApertureModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="doorSet">An optional DoorModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="shadeSet">An optional ShadeModifierSet object for this ModifierSet. (default: None)..</param>
        /// <param name="airBoundaryModifier">An optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ModifierSet
        (
            string identifier, // Required parameters
            string displayName= default, WallModifierSet wallSet= default, FloorModifierSet floorSet= default, RoofCeilingModifierSet roofCeilingSet= default, ApertureModifierSet apertureSet= default, DoorModifierSet doorSet= default, ShadeModifierSet shadeSet= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> airBoundaryModifier= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.WallSet = wallSet;
            this.FloorSet = floorSet;
            this.RoofCeilingSet = roofCeilingSet;
            this.ApertureSet = apertureSet;
            this.DoorSet = doorSet;
            this.ShadeSet = shadeSet;
            this.AirBoundaryModifier = airBoundaryModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "ModifierSet";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ModifierSet))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "ModifierSet";

        /// <summary>
        /// An optional WallModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional WallModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional WallModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "wall_set")]
        public WallModifierSet WallSet { get; set; } 
        /// <summary>
        /// An optional FloorModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional FloorModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional FloorModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "floor_set")]
        public FloorModifierSet FloorSet { get; set; } 
        /// <summary>
        /// An optional RoofCeilingModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional RoofCeilingModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional RoofCeilingModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "roof_ceiling_set")]
        public RoofCeilingModifierSet RoofCeilingSet { get; set; } 
        /// <summary>
        /// An optional ApertureModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional ApertureModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional ApertureModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "aperture_set")]
        public ApertureModifierSet ApertureSet { get; set; } 
        /// <summary>
        /// An optional DoorModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional DoorModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional DoorModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "door_set")]
        public DoorModifierSet DoorSet { get; set; } 
        /// <summary>
        /// An optional ShadeModifierSet object for this ModifierSet. (default: None).
        /// </summary>
        /// <value>An optional ShadeModifierSet object for this ModifierSet. (default: None).</value>
        [Summary(@"An optional ShadeModifierSet object for this ModifierSet. (default: None).")]
        [DataMember(Name = "shade_set")]
        public ShadeModifierSet ShadeSet { get; set; } 
        /// <summary>
        /// An optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier.
        /// </summary>
        /// <value>An optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier.</value>
        [Summary(@"An optional Modifier to be used for all Faces with an AirBoundary face type. If None, it will be the honeybee generic air wall modifier.")]
        [DataMember(Name = "air_boundary_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> AirBoundaryModifier { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ModifierSet";
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
            sb.Append("ModifierSet:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  WallSet: ").Append(this.WallSet).Append("\n");
            sb.Append("  FloorSet: ").Append(this.FloorSet).Append("\n");
            sb.Append("  RoofCeilingSet: ").Append(this.RoofCeilingSet).Append("\n");
            sb.Append("  ApertureSet: ").Append(this.ApertureSet).Append("\n");
            sb.Append("  DoorSet: ").Append(this.DoorSet).Append("\n");
            sb.Append("  ShadeSet: ").Append(this.ShadeSet).Append("\n");
            sb.Append("  AirBoundaryModifier: ").Append(this.AirBoundaryModifier).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ModifierSet object</returns>
        public static ModifierSet FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ModifierSet>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ModifierSet object</returns>
        public virtual ModifierSet DuplicateModifierSet()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateModifierSet();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override IDdRadianceBaseModel DuplicateIDdRadianceBaseModel()
        {
            return DuplicateModifierSet();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ModifierSet);
        }

        /// <summary>
        /// Returns true if ModifierSet instances are equal
        /// </summary>
        /// <param name="input">Instance of ModifierSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ModifierSet input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.WallSet, input.WallSet) && 
                    Extension.Equals(this.FloorSet, input.FloorSet) && 
                    Extension.Equals(this.RoofCeilingSet, input.RoofCeilingSet) && 
                    Extension.Equals(this.ApertureSet, input.ApertureSet) && 
                    Extension.Equals(this.DoorSet, input.DoorSet) && 
                    Extension.Equals(this.ShadeSet, input.ShadeSet) && 
                    Extension.Equals(this.AirBoundaryModifier, input.AirBoundaryModifier);
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^ModifierSet$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
