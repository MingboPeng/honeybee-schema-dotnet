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
    /// Radiance mirror material.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Mirror")]
    public partial class Mirror : ModifierBase, IEquatable<Mirror>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mirror" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Mirror() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "Mirror";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Mirror" /> class.
        /// </summary>
        /// <param name="modifier">Material modifier..</param>
        /// <param name="dependencies">List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers..</param>
        /// <param name="rReflectance">A value between 0 and 1 for the red channel reflectance. (default to 1D).</param>
        /// <param name="gReflectance">A value between 0 and 1 for the green channel reflectance. (default to 1D).</param>
        /// <param name="bReflectance">A value between 0 and 1 for the blue channel reflectance. (default to 1D).</param>
        /// <param name="alternateMaterial">An optional material (like the illum type) that may be used to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance..</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Mirror
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> modifier= default, List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> dependencies= default, double rReflectance = 1D, double gReflectance = 1D, double bReflectance = 1D, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> alternateMaterial= default // Optional parameters
        ) : base(identifier: identifier, displayName: displayName)// BaseClass
        {
            this.Modifier = modifier;
            this.Dependencies = dependencies;
            this.RReflectance = rReflectance;
            this.GReflectance = gReflectance;
            this.BReflectance = bReflectance;
            this.AlternateMaterial = alternateMaterial;

            // Set non-required readonly properties with defaultValue
            this.Type = "Mirror";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Mirror))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Mirror";

        /// <summary>
        /// Material modifier.
        /// </summary>
        /// <value>Material modifier.</value>
        [DataMember(Name = "modifier")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> Modifier { get; set; } 
        /// <summary>
        /// List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers.
        /// </summary>
        /// <value>List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers.</value>
        [DataMember(Name = "dependencies")]
        public List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> Dependencies { get; set; } 
        /// <summary>
        /// A value between 0 and 1 for the red channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the red channel reflectance.</value>
        [DataMember(Name = "r_reflectance")]
        public double RReflectance { get; set; }  = 1D;
        /// <summary>
        /// A value between 0 and 1 for the green channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the green channel reflectance.</value>
        [DataMember(Name = "g_reflectance")]
        public double GReflectance { get; set; }  = 1D;
        /// <summary>
        /// A value between 0 and 1 for the blue channel reflectance.
        /// </summary>
        /// <value>A value between 0 and 1 for the blue channel reflectance.</value>
        [DataMember(Name = "b_reflectance")]
        public double BReflectance { get; set; }  = 1D;
        /// <summary>
        /// An optional material (like the illum type) that may be used to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance.
        /// </summary>
        /// <value>An optional material (like the illum type) that may be used to specify a different material to be used for shading non-source rays. If None, this will keep the alternat_material as mirror. If this alternate material is given as Void, then the mirror surface will be invisible. Using Void is only appropriate if the surface hides other (more detailed) geometry with the same overall reflectance.</value>
        [DataMember(Name = "alternate_material")]
        public AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> AlternateMaterial { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Mirror";
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
            sb.Append("Mirror:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  RReflectance: ").Append(RReflectance).Append("\n");
            sb.Append("  GReflectance: ").Append(GReflectance).Append("\n");
            sb.Append("  BReflectance: ").Append(BReflectance).Append("\n");
            sb.Append("  AlternateMaterial: ").Append(AlternateMaterial).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Mirror object</returns>
        public static Mirror FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Mirror>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Mirror object</returns>
        public virtual Mirror DuplicateMirror()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateMirror();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override ModifierBase DuplicateModifierBase()
        {
            return DuplicateMirror();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Mirror);
        }

        /// <summary>
        /// Returns true if Mirror instances are equal
        /// </summary>
        /// <param name="input">Instance of Mirror to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Mirror input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                (
                    Extension.Equals(this.Modifier, input.Modifier)
                ) && base.Equals(input) && 
                (
                    this.Dependencies == input.Dependencies ||
                    Extension.AllEquals(this.Dependencies, input.Dependencies)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.RReflectance, input.RReflectance)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.GReflectance, input.GReflectance)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.BReflectance, input.BReflectance)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.AlternateMaterial, input.AlternateMaterial)
                ) && base.Equals(input) && 
                (
                    Extension.Equals(this.Type, input.Type)
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
                if (this.AlternateMaterial != null)
                    hashCode = hashCode * 59 + this.AlternateMaterial.GetHashCode();
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


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Mirror$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
