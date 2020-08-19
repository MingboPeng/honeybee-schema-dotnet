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
    /// Radiance plastic material.
    /// </summary>
    [DataContract]
    public partial class Plastic : ModifierBase, IEquatable<Plastic>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Plastic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Plastic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Plastic" /> class.
        /// </summary>
        /// <param name="modifier">Material modifier (default: Void)..</param>
        /// <param name="dependencies">List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None)..</param>
        /// <param name="rReflectance">A value between 0 and 1 for the red channel reflectance (default: 0). (default to 0.0D).</param>
        /// <param name="gReflectance">A value between 0 and 1 for the green channel reflectance (default: 0). (default to 0.0D).</param>
        /// <param name="bReflectance">A value between 0 and 1 for the blue channel reflectance (default: 0). (default to 0.0D).</param>
        /// <param name="specularity">A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials. (default: 0). (default to 0D).</param>
        /// <param name="roughness">A value between 0 and 1 for the roughness, specified as the rms slope of surface facets. Roughness greater than 0.2 are not realistic (default: 0). (default to 0D).</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Plastic
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> modifier= default, List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> dependencies= default, double rReflectance = 0.0D, double gReflectance = 0.0D, double bReflectance = 0.0D, double specularity = 0D, double roughness = 0D // Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.Modifier = modifier;
            this.Dependencies = dependencies;
            // use default value if no "rReflectance" provided
            if (rReflectance == null)
            {
                this.RReflectance = 0.0D;
            }
            else
            {
                this.RReflectance = rReflectance;
            }
            // use default value if no "gReflectance" provided
            if (gReflectance == null)
            {
                this.GReflectance = 0.0D;
            }
            else
            {
                this.GReflectance = gReflectance;
            }
            // use default value if no "bReflectance" provided
            if (bReflectance == null)
            {
                this.BReflectance = 0.0D;
            }
            else
            {
                this.BReflectance = bReflectance;
            }
            // use default value if no "specularity" provided
            if (specularity == null)
            {
                this.Specularity = 0D;
            }
            else
            {
                this.Specularity = specularity;
            }
            // use default value if no "roughness" provided
            if (roughness == null)
            {
                this.Roughness = 0D;
            }
            else
            {
                this.Roughness = roughness;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "plastic";
        }
        
        /// <summary>
        /// Material modifier (default: Void).
        /// </summary>
        /// <value>Material modifier (default: Void).</value>
        [DataMember(Name="modifier", EmitDefaultValue=false)]
        [JsonProperty("modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> Modifier { get; set; } 
        /// <summary>
        /// List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None).
        /// </summary>
        /// <value>List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None).</value>
        [DataMember(Name="dependencies", EmitDefaultValue=false)]
        [JsonProperty("dependencies")]
        public List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> Dependencies { get; set; } 
        /// <summary>
        /// A value between 0 and 1 for the red channel reflectance (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the red channel reflectance (default: 0).</value>
        [DataMember(Name="r_reflectance", EmitDefaultValue=false)]
        [JsonProperty("r_reflectance")]
        public double RReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the green channel reflectance (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the green channel reflectance (default: 0).</value>
        [DataMember(Name="g_reflectance", EmitDefaultValue=false)]
        [JsonProperty("g_reflectance")]
        public double GReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the blue channel reflectance (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the blue channel reflectance (default: 0).</value>
        [DataMember(Name="b_reflectance", EmitDefaultValue=false)]
        [JsonProperty("b_reflectance")]
        public double BReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials. (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials. (default: 0).</value>
        [DataMember(Name="specularity", EmitDefaultValue=false)]
        [JsonProperty("specularity")]
        public double Specularity { get; set; }  = 0D;
        /// <summary>
        /// A value between 0 and 1 for the roughness, specified as the rms slope of surface facets. Roughness greater than 0.2 are not realistic (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the roughness, specified as the rms slope of surface facets. Roughness greater than 0.2 are not realistic (default: 0).</value>
        [DataMember(Name="roughness", EmitDefaultValue=false)]
        [JsonProperty("roughness")]
        public double Roughness { get; set; }  = 0D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Plastic {iDd.Identifier}";
       
            return "Plastic";
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
            sb.Append("Plastic:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  RReflectance: ").Append(RReflectance).Append("\n");
            sb.Append("  GReflectance: ").Append(GReflectance).Append("\n");
            sb.Append("  BReflectance: ").Append(BReflectance).Append("\n");
            sb.Append("  Specularity: ").Append(Specularity).Append("\n");
            sb.Append("  Roughness: ").Append(Roughness).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Plastic object</returns>
        public static Plastic FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Plastic>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Plastic object</returns>
        public Plastic DuplicatePlastic()
        {
            return Duplicate() as Plastic;
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
            return this.Equals(input as Plastic);
        }

        /// <summary>
        /// Returns true if Plastic instances are equal
        /// </summary>
        /// <param name="input">Instance of Plastic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Plastic input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Modifier == input.Modifier ||
                    (this.Modifier != null &&
                    this.Modifier.Equals(input.Modifier))
                ) && base.Equals(input) && 
                (
                    this.Dependencies == input.Dependencies ||
                    this.Dependencies != null &&
                    input.Dependencies != null &&
                    this.Dependencies.SequenceEqual(input.Dependencies)
                ) && base.Equals(input) && 
                (
                    this.RReflectance == input.RReflectance ||
                    (this.RReflectance != null &&
                    this.RReflectance.Equals(input.RReflectance))
                ) && base.Equals(input) && 
                (
                    this.GReflectance == input.GReflectance ||
                    (this.GReflectance != null &&
                    this.GReflectance.Equals(input.GReflectance))
                ) && base.Equals(input) && 
                (
                    this.BReflectance == input.BReflectance ||
                    (this.BReflectance != null &&
                    this.BReflectance.Equals(input.BReflectance))
                ) && base.Equals(input) && 
                (
                    this.Specularity == input.Specularity ||
                    (this.Specularity != null &&
                    this.Specularity.Equals(input.Specularity))
                ) && base.Equals(input) && 
                (
                    this.Roughness == input.Roughness ||
                    (this.Roughness != null &&
                    this.Roughness.Equals(input.Roughness))
                ) && base.Equals(input) && 
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
                int hashCode = base.GetHashCode();
                if (this.Modifier != null)
                    hashCode = hashCode * 59 + this.Modifier.GetHashCode();
                if (this.Dependencies != null)
                    hashCode = hashCode * 59 + this.Dependencies.GetHashCode();
                if (this.RReflectance != null)
                    hashCode = hashCode * 59 + this.RReflectance.GetHashCode();
                if (this.GReflectance != null)
                    hashCode = hashCode * 59 + this.GReflectance.GetHashCode();
                if (this.BReflectance != null)
                    hashCode = hashCode * 59 + this.BReflectance.GetHashCode();
                if (this.Specularity != null)
                    hashCode = hashCode * 59 + this.Specularity.GetHashCode();
                if (this.Roughness != null)
                    hashCode = hashCode * 59 + this.Roughness.GetHashCode();
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
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // RReflectance (double) maximum
            if(this.RReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RReflectance, must be a value less than or equal to 1.", new [] { "RReflectance" });
            }

            // RReflectance (double) minimum
            if(this.RReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RReflectance, must be a value greater than or equal to 0.", new [] { "RReflectance" });
            }

            // GReflectance (double) maximum
            if(this.GReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GReflectance, must be a value less than or equal to 1.", new [] { "GReflectance" });
            }

            // GReflectance (double) minimum
            if(this.GReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GReflectance, must be a value greater than or equal to 0.", new [] { "GReflectance" });
            }

            // BReflectance (double) maximum
            if(this.BReflectance > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BReflectance, must be a value less than or equal to 1.", new [] { "BReflectance" });
            }

            // BReflectance (double) minimum
            if(this.BReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BReflectance, must be a value greater than or equal to 0.", new [] { "BReflectance" });
            }

            // Specularity (double) maximum
            if(this.Specularity > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Specularity, must be a value less than or equal to 1.", new [] { "Specularity" });
            }

            // Specularity (double) minimum
            if(this.Specularity < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Specularity, must be a value greater than or equal to 0.", new [] { "Specularity" });
            }

            // Roughness (double) maximum
            if(this.Roughness > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Roughness, must be a value less than or equal to 1.", new [] { "Roughness" });
            }

            // Roughness (double) minimum
            if(this.Roughness < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Roughness, must be a value greater than or equal to 0.", new [] { "Roughness" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^plastic$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
