/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.30.2
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
    /// Set containing radiance modifiers needed for a model&#39;s Floors.
    /// </summary>
    [DataContract]
    public partial class FloorModifierSet : HoneybeeObject, IEquatable<FloorModifierSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FloorModifierSet" /> class.
        /// </summary>
        /// <param name="exteriorModifier">A radiance modifier object for faces with an Outdoors boundary condition..</param>
        /// <param name="interiorModifier">A radiance modifier object for faces with a boundary condition other than Outdoors..</param>
        public FloorModifierSet
        (
             // Required parameters
            AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> exteriorModifier= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> interiorModifier= default // Optional parameters
        )// BaseClass
        {
            this.ExteriorModifier = exteriorModifier;
            this.InteriorModifier = interiorModifier;

            // Set non-required readonly properties with defaultValue
            this.Type = "FloorModifierSet";
        }
        
        /// <summary>
        /// A radiance modifier object for faces with an Outdoors boundary condition.
        /// </summary>
        /// <value>A radiance modifier object for faces with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_modifier", EmitDefaultValue=false)]
        [JsonProperty("exterior_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> ExteriorModifier { get; set; } 
        /// <summary>
        /// A radiance modifier object for faces with a boundary condition other than Outdoors.
        /// </summary>
        /// <value>A radiance modifier object for faces with a boundary condition other than Outdoors.</value>
        [DataMember(Name="interior_modifier", EmitDefaultValue=false)]
        [JsonProperty("interior_modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> InteriorModifier { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"FloorModifierSet {iDd.Identifier}";
       
            return "FloorModifierSet";
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
            sb.Append("FloorModifierSet:\n");
            sb.Append("  ExteriorModifier: ").Append(ExteriorModifier).Append("\n");
            sb.Append("  InteriorModifier: ").Append(InteriorModifier).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, JsonSetting.AnyOfConvertSetting);
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>FloorModifierSet object</returns>
        public static FloorModifierSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<FloorModifierSet>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FloorModifierSet);
        }

        /// <summary>
        /// Returns true if FloorModifierSet instances are equal
        /// </summary>
        /// <param name="input">Instance of FloorModifierSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FloorModifierSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExteriorModifier == input.ExteriorModifier ||
                    (this.ExteriorModifier != null &&
                    this.ExteriorModifier.Equals(input.ExteriorModifier))
                ) && 
                (
                    this.InteriorModifier == input.InteriorModifier ||
                    (this.InteriorModifier != null &&
                    this.InteriorModifier.Equals(input.InteriorModifier))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.ExteriorModifier != null)
                    hashCode = hashCode * 59 + this.ExteriorModifier.GetHashCode();
                if (this.InteriorModifier != null)
                    hashCode = hashCode * 59 + this.InteriorModifier.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^FloorModifierSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
