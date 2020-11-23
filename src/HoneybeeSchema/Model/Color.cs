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
    /// A mesh in 3D space.
    /// </summary>
    [DataContract(Name = "Color")]
    public partial class Color : IEquatable<Color>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Color() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Color";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Color" /> class.
        /// </summary>
        /// <param name="r">Integer for red value. (required).</param>
        /// <param name="g">Integer for green value. (required).</param>
        /// <param name="b">Integer for blue value. (required).</param>
        public Color
        (
             int r, int g, int b// Required parameters
             // Optional parameters
        )// BaseClass
        {
            this.R = r;
            this.G = g;
            this.B = b;

            // Set non-required readonly properties with defaultValue
            this.Type = "Color";
        }

        /// <summary>
        /// Integer for red value.
        /// </summary>
        /// <value>Integer for red value.</value>
        [DataMember(Name = "r", IsRequired = true, EmitDefaultValue = false)]
        public int R { get; set; } 
        /// <summary>
        /// Integer for green value.
        /// </summary>
        /// <value>Integer for green value.</value>
        [DataMember(Name = "g", IsRequired = true, EmitDefaultValue = false)]
        public int G { get; set; } 
        /// <summary>
        /// Integer for blue value.
        /// </summary>
        /// <value>Integer for blue value.</value>
        [DataMember(Name = "b", IsRequired = true, EmitDefaultValue = false)]
        public int B { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Color";
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
            sb.Append("Color:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  R: ").Append(R).Append("\n");
            sb.Append("  G: ").Append(G).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Color object</returns>
        public static Color FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Color>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Color object</returns>
        public virtual Color DuplicateColor()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateColor();
        }

     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Color);
        }

        /// <summary>
        /// Returns true if Color instances are equal
        /// </summary>
        /// <param name="input">Instance of Color to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Color input)
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
                    this.R == input.R ||
                    (this.R != null &&
                    this.R.Equals(input.R))
                ) && 
                (
                    this.G == input.G ||
                    (this.G != null &&
                    this.G.Equals(input.G))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
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
                if (this.R != null)
                    hashCode = hashCode * 59 + this.R.GetHashCode();
                if (this.G != null)
                    hashCode = hashCode * 59 + this.G.GetHashCode();
                if (this.B != null)
                    hashCode = hashCode * 59 + this.B.GetHashCode();
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
            Regex regexType = new Regex(@"^Color$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // R (int) maximum
            if(this.R > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for R, must be a value less than or equal to 255.", new [] { "R" });
            }

            // R (int) minimum
            if(this.R < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for R, must be a value greater than or equal to 0.", new [] { "R" });
            }


            
            // G (int) maximum
            if(this.G > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for G, must be a value less than or equal to 255.", new [] { "G" });
            }

            // G (int) minimum
            if(this.G < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for G, must be a value greater than or equal to 0.", new [] { "G" });
            }


            
            // B (int) maximum
            if(this.B > (int)255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for B, must be a value less than or equal to 255.", new [] { "B" });
            }

            // B (int) minimum
            if(this.B < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for B, must be a value greater than or equal to 0.", new [] { "B" });
            }

            yield break;
        }
    }
}
