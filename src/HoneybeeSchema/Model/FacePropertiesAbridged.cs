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
    /// FacePropertiesAbridged
    /// </summary>
    [DataContract]
    public partial class FacePropertiesAbridged :  IEquatable<FacePropertiesAbridged>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FacePropertiesAbridged" /> class.
        /// </summary>
        /// <param name="type">type (default to &quot;FacePropertiesAbridged&quot;).</param>
        /// <param name="energy">energy.</param>
        public FacePropertiesAbridged(string type = "FacePropertiesAbridged", FaceEnergyPropertiesAbridged energy = default)
        {
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "FacePropertiesAbridged";
            }
            else
            {
                this.Type = type;
            }
            this.Energy = energy;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Energy
        /// </summary>
        [DataMember(Name="energy", EmitDefaultValue=false)]
        [JsonProperty("energy")]
        public FaceEnergyPropertiesAbridged Energy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FacePropertiesAbridged {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Energy: ").Append(Energy).Append("\n");
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
        /// <returns>FacePropertiesAbridged object</returns>
        public static FacePropertiesAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<FacePropertiesAbridged>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FacePropertiesAbridged);
        }

        /// <summary>
        /// Returns true if FacePropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of FacePropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FacePropertiesAbridged input)
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
                    this.Energy == input.Energy ||
                    (this.Energy != null &&
                    this.Energy.Equals(input.Energy))
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
                if (this.Energy != null)
                    hashCode = hashCode * 59 + this.Energy.GetHashCode();
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
            Regex regexType = new Regex(@"^FacePropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
