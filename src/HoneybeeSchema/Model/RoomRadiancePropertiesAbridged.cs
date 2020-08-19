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
    /// Abridged Radiance Properties for Honeybee Room.
    /// </summary>
    [DataContract]
    public partial class RoomRadiancePropertiesAbridged : HoneybeeObject, IEquatable<RoomRadiancePropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoomRadiancePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="modifierSet">An identifier for a unique Room-Assigned ModifierSet (default: None)..</param>
        public RoomRadiancePropertiesAbridged
        (
             // Required parameters
            string modifierSet= default// Optional parameters
        )// BaseClass
        {
            this.ModifierSet = modifierSet;

            // Set non-required readonly properties with defaultValue
            this.Type = "RoomRadiancePropertiesAbridged";
        }
        
        /// <summary>
        /// An identifier for a unique Room-Assigned ModifierSet (default: None).
        /// </summary>
        /// <value>An identifier for a unique Room-Assigned ModifierSet (default: None).</value>
        [DataMember(Name="modifier_set", EmitDefaultValue=false)]
        [JsonProperty("modifier_set")]
        public string ModifierSet { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RoomRadiancePropertiesAbridged {iDd.Identifier}";
       
            return "RoomRadiancePropertiesAbridged";
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
            sb.Append("RoomRadiancePropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ModifierSet: ").Append(ModifierSet).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>RoomRadiancePropertiesAbridged object</returns>
        public static RoomRadiancePropertiesAbridged FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<RoomRadiancePropertiesAbridged>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>RoomRadiancePropertiesAbridged object</returns>
        public RoomRadiancePropertiesAbridged DuplicateRoomRadiancePropertiesAbridged()
        {
            return Duplicate() as RoomRadiancePropertiesAbridged;
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
            return this.Equals(input as RoomRadiancePropertiesAbridged);
        }

        /// <summary>
        /// Returns true if RoomRadiancePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of RoomRadiancePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomRadiancePropertiesAbridged input)
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
                    this.ModifierSet == input.ModifierSet ||
                    (this.ModifierSet != null &&
                    this.ModifierSet.Equals(input.ModifierSet))
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
                if (this.ModifierSet != null)
                    hashCode = hashCode * 59 + this.ModifierSet.GetHashCode();
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
            Regex regexType = new Regex(@"^RoomRadiancePropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
