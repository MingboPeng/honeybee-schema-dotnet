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
    /// Radiance Properties for Honeybee Aperture Abridged.
    /// </summary>
    [DataContract(Name = "ApertureRadiancePropertiesAbridged")]
    public partial class ApertureRadiancePropertiesAbridged : IEquatable<ApertureRadiancePropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApertureRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifier">A string for a Honeybee Radiance Modifier (default: None)..</param>
        /// <param name="modifierBlk">A string for a Honeybee Radiance Modifier to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None)..</param>
        /// <param name="dynamicGroupIdentifier">An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None)..</param>
        /// <param name="states">An optional list of abridged states (default: None)..</param>
        public ApertureRadiancePropertiesAbridged
        (
             // Required parameters
            string modifier= default, string modifierBlk= default, string dynamicGroupIdentifier= default, List<RadianceSubFaceStateAbridged> states= default// Optional parameters
        )// BaseClass
        {
            this.Modifier = modifier;
            this.ModifierBlk = modifierBlk;
            this.DynamicGroupIdentifier = dynamicGroupIdentifier;
            this.States = states;

            // Set non-required readonly properties with defaultValue
            this.Type = "ApertureRadiancePropertiesAbridged";
        }

        /// <summary>
        /// A string for a Honeybee Radiance Modifier (default: None).
        /// </summary>
        /// <value>A string for a Honeybee Radiance Modifier (default: None).</value>
        [DataMember(Name = "modifier", EmitDefaultValue = false)]
        public string Modifier { get; set; } 
        /// <summary>
        /// A string for a Honeybee Radiance Modifier to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None).
        /// </summary>
        /// <value>A string for a Honeybee Radiance Modifier to be used in direct solar simulations and in isolation studies (assessingthe contribution of individual objects) (default: None).</value>
        [DataMember(Name = "modifier_blk", EmitDefaultValue = false)]
        public string ModifierBlk { get; set; } 
        /// <summary>
        /// An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None).
        /// </summary>
        /// <value>An optional string to note the dynamic group &#39;             &#39;to which the Aperture is a part of. Apertures sharing the same &#39;             &#39;dynamic_group_identifier will have their states change in unison. &#39;             &#39;If None, the Aperture is assumed to be static. (default: None).</value>
        [DataMember(Name = "dynamic_group_identifier", EmitDefaultValue = false)]
        public string DynamicGroupIdentifier { get; set; } 
        /// <summary>
        /// An optional list of abridged states (default: None).
        /// </summary>
        /// <value>An optional list of abridged states (default: None).</value>
        [DataMember(Name = "states", EmitDefaultValue = false)]
        public List<RadianceSubFaceStateAbridged> States { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ApertureRadiancePropertiesAbridged";
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
            sb.Append("ApertureRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  ModifierBlk: ").Append(ModifierBlk).Append("\n");
            sb.Append("  DynamicGroupIdentifier: ").Append(DynamicGroupIdentifier).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ApertureRadiancePropertiesAbridged object</returns>
        public static ApertureRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ApertureRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ApertureRadiancePropertiesAbridged object</returns>
        public virtual ApertureRadiancePropertiesAbridged DuplicateApertureRadiancePropertiesAbridged()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateApertureRadiancePropertiesAbridged();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApertureRadiancePropertiesAbridged);
        }

        /// <summary>
        /// Returns true if ApertureRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of ApertureRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApertureRadiancePropertiesAbridged input)
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
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && 
                (
                    this.ModifierBlk == input.ModifierBlk ||
                    (this.ModifierBlk != null &&
                    this.ModifierBlk.Equals(input.ModifierBlk))
                ) && 
                (
                    this.DynamicGroupIdentifier == input.DynamicGroupIdentifier ||
                    (this.DynamicGroupIdentifier != null &&
                    this.DynamicGroupIdentifier.Equals(input.DynamicGroupIdentifier))
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
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
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.ModifierBlk != null)
                    hashCode = hashCode * 59 + this.ModifierBlk.GetHashCode();
                if (this.DynamicGroupIdentifier != null)
                    hashCode = hashCode * 59 + this.DynamicGroupIdentifier.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
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
            Regex regexType = new Regex(@"^ApertureRadiancePropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
