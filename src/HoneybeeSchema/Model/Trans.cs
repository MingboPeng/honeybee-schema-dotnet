/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonSoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonSoft::Newtonsoft.Json;
using LBTNewtonSoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Radiance Translucent material.
    /// </summary>
    [Summary(@"Radiance Translucent material.")]
    [Serializable]
    [DataContract(Name = "Trans")]
    public partial class Trans : ModifierBase, IEquatable<Trans>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trans" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Trans() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Trans";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Trans" /> class.
        /// </summary>
        /// <param name="modifier">Material modifier..</param>
        /// <param name="dependencies">List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers..</param>
        /// <param name="rReflectance">A value between 0 and 1 for the red channel reflectance. (default to 0.0D).</param>
        /// <param name="gReflectance">A value between 0 and 1 for the green channel reflectance. (default to 0.0D).</param>
        /// <param name="bReflectance">A value between 0 and 1 for the blue channel reflectance. (default to 0.0D).</param>
        /// <param name="specularity">A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials. (default to 0D).</param>
        /// <param name="roughness">A value between 0 and 1 for the roughness, specified as the RMS slope of surface facets. Roughness greater than 0.2 are not realistic. (default to 0D).</param>
        /// <param name="transmittedDiff">The fraction of transmitted light that is transmitted diffusely in a scattering fashion. (default to 0D).</param>
        /// <param name="transmittedSpec">The fraction of transmitted light that is not diffusely scattered. (default to 0D).</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Trans
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror> modifier= default, List<AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror>> dependencies= default, double rReflectance = 0.0D, double gReflectance = 0.0D, double bReflectance = 0.0D, double specularity = 0D, double roughness = 0D, double transmittedDiff = 0D, double transmittedSpec = 0D // Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.Modifier = modifier;
            this.Dependencies = dependencies;
            this.RReflectance = rReflectance;
            this.GReflectance = gReflectance;
            this.BReflectance = bReflectance;
            this.Specularity = specularity;
            this.Roughness = roughness;
            this.TransmittedDiff = transmittedDiff;
            this.TransmittedSpec = transmittedSpec;

            // Set non-required readonly properties with defaultValue
            this.Type = "Trans";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Trans))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Trans";

        /// <summary>
        /// Material modifier.
        /// </summary>
        /// <value>Material modifier.</value>
        [Summary(@"Material modifier.")]
        [DataMember(Name = "modifier")]
        public AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror> Modifier { get; set; } 
        /// <summary>
        /// List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers.
        /// </summary>
        /// <value>List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers.</value>
        [Summary(@"List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers.")]
        [DataMember(Name = "dependencies")]
        public List<AnyOf<Plastic, Glass, BSDF, Glow, Light, Trans, Metal, Void, Mirror>> Dependencies { get; set; } 
        /// <summary>
        /// A value between 0 and 1 for the red channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the red channel reflectance.</value>
        [Summary(@"A value between 0 and 1 for the red channel reflectance.")]
        [DataMember(Name = "r_reflectance")]
        public double RReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the green channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the green channel reflectance.</value>
        [Summary(@"A value between 0 and 1 for the green channel reflectance.")]
        [DataMember(Name = "g_reflectance")]
        public double GReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the blue channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the blue channel reflectance.</value>
        [Summary(@"A value between 0 and 1 for the blue channel reflectance.")]
        [DataMember(Name = "b_reflectance")]
        public double BReflectance { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials.
        /// </summary>
        /// <value>A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials.</value>
        [Summary(@"A value between 0 and 1 for the fraction of specularity. Specularity fractions greater than 0.1 are not realistic for non-metallic materials.")]
        [DataMember(Name = "specularity")]
        public double Specularity { get; set; }  = 0D;
        /// <summary>
        /// A value between 0 and 1 for the roughness, specified as the RMS slope of surface facets. Roughness greater than 0.2 are not realistic.
        /// </summary>
        /// <value>A value between 0 and 1 for the roughness, specified as the RMS slope of surface facets. Roughness greater than 0.2 are not realistic.</value>
        [Summary(@"A value between 0 and 1 for the roughness, specified as the RMS slope of surface facets. Roughness greater than 0.2 are not realistic.")]
        [DataMember(Name = "roughness")]
        public double Roughness { get; set; }  = 0D;
        /// <summary>
        /// The fraction of transmitted light that is transmitted diffusely in a scattering fashion.
        /// </summary>
        /// <value>The fraction of transmitted light that is transmitted diffusely in a scattering fashion.</value>
        [Summary(@"The fraction of transmitted light that is transmitted diffusely in a scattering fashion.")]
        [DataMember(Name = "transmitted_diff")]
        public double TransmittedDiff { get; set; }  = 0D;
        /// <summary>
        /// The fraction of transmitted light that is not diffusely scattered.
        /// </summary>
        /// <value>The fraction of transmitted light that is not diffusely scattered.</value>
        [Summary(@"The fraction of transmitted light that is not diffusely scattered.")]
        [DataMember(Name = "transmitted_spec")]
        public double TransmittedSpec { get; set; }  = 0D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Trans";
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
            sb.Append("Trans:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  Modifier: ").Append(this.Modifier).Append("\n");
            sb.Append("  Dependencies: ").Append(this.Dependencies).Append("\n");
            sb.Append("  RReflectance: ").Append(this.RReflectance).Append("\n");
            sb.Append("  GReflectance: ").Append(this.GReflectance).Append("\n");
            sb.Append("  BReflectance: ").Append(this.BReflectance).Append("\n");
            sb.Append("  Specularity: ").Append(this.Specularity).Append("\n");
            sb.Append("  Roughness: ").Append(this.Roughness).Append("\n");
            sb.Append("  TransmittedDiff: ").Append(this.TransmittedDiff).Append("\n");
            sb.Append("  TransmittedSpec: ").Append(this.TransmittedSpec).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Trans object</returns>
        public static Trans FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Trans>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Trans object</returns>
        public virtual Trans DuplicateTrans()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateTrans();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override ModifierBase DuplicateModifierBase()
        {
            return DuplicateTrans();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Trans);
        }

        /// <summary>
        /// Returns true if Trans instances are equal
        /// </summary>
        /// <param name="input">Instance of Trans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Trans input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Modifier, input.Modifier) && 
                (
                    this.Dependencies == input.Dependencies ||
                    Extension.AllEquals(this.Dependencies, input.Dependencies)
                ) && 
                    Extension.Equals(this.RReflectance, input.RReflectance) && 
                    Extension.Equals(this.GReflectance, input.GReflectance) && 
                    Extension.Equals(this.BReflectance, input.BReflectance) && 
                    Extension.Equals(this.Specularity, input.Specularity) && 
                    Extension.Equals(this.Roughness, input.Roughness) && 
                    Extension.Equals(this.TransmittedDiff, input.TransmittedDiff) && 
                    Extension.Equals(this.TransmittedSpec, input.TransmittedSpec) && 
                    Extension.Equals(this.Type, input.Type);
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
                if (this.TransmittedDiff != null)
                    hashCode = hashCode * 59 + this.TransmittedDiff.GetHashCode();
                if (this.TransmittedSpec != null)
                    hashCode = hashCode * 59 + this.TransmittedSpec.GetHashCode();
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


            
            // TransmittedDiff (double) maximum
            if(this.TransmittedDiff > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittedDiff, must be a value less than or equal to 1.", new [] { "TransmittedDiff" });
            }

            // TransmittedDiff (double) minimum
            if(this.TransmittedDiff < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittedDiff, must be a value greater than or equal to 0.", new [] { "TransmittedDiff" });
            }


            
            // TransmittedSpec (double) maximum
            if(this.TransmittedSpec > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittedSpec, must be a value less than or equal to 1.", new [] { "TransmittedSpec" });
            }

            // TransmittedSpec (double) minimum
            if(this.TransmittedSpec < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransmittedSpec, must be a value greater than or equal to 0.", new [] { "TransmittedSpec" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Trans$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
