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
    /// Radiance glass material.
    /// </summary>
    [DataContract]
    public partial class Glass : ModifierBase, IEquatable<Glass>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Glass" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Glass() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Glass" /> class.
        /// </summary>
        /// <param name="modifier">Material modifier (default: Void)..</param>
        /// <param name="dependencies">List of modifiers that this modifier depends on. This argument is only useful for defining advanced modifiers where the modifier is defined based on other modifiers (default: None)..</param>
        /// <param name="rTransmissivity">A value between 0 and 1 for the red channel transmissivity (default: 0). (default to 0.0D).</param>
        /// <param name="gTransmissivity">A value between 0 and 1 for the green channel transmissivity (default: 0). (default to 0.0D).</param>
        /// <param name="bTransmissivity">A value between 0 and 1 for the blue channel transmissivity (default: 0). (default to 0.0D).</param>
        /// <param name="refractionIndex">A value between 0 and 1 for the index of refraction (default: 1.52). (default to 1.52D).</param>
        /// <param name="identifier">Text string for a unique Radiance object. Must not contain spaces or special characters. This will be used to identify the object across a model and in the exported Radiance files. (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Glass
        (
            string identifier, // Required parameters
            string displayName= default, AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror> modifier= default, List<AnyOf<Plastic,Glass,BSDF,Glow,Light,Trans,Metal,Void,Mirror>> dependencies= default, double rTransmissivity = 0.0D, double gTransmissivity = 0.0D, double bTransmissivity = 0.0D, double refractionIndex = 1.52D // Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.Modifier = modifier;
            this.Dependencies = dependencies;
            // use default value if no "rTransmissivity" provided
            if (rTransmissivity == null)
            {
                this.RTransmissivity = 0.0D;
            }
            else
            {
                this.RTransmissivity = rTransmissivity;
            }
            // use default value if no "gTransmissivity" provided
            if (gTransmissivity == null)
            {
                this.GTransmissivity = 0.0D;
            }
            else
            {
                this.GTransmissivity = gTransmissivity;
            }
            // use default value if no "bTransmissivity" provided
            if (bTransmissivity == null)
            {
                this.BTransmissivity = 0.0D;
            }
            else
            {
                this.BTransmissivity = bTransmissivity;
            }
            // use default value if no "refractionIndex" provided
            if (refractionIndex == null)
            {
                this.RefractionIndex = 1.52D;
            }
            else
            {
                this.RefractionIndex = refractionIndex;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "glass";
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
        /// A value between 0 and 1 for the red channel transmissivity (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the red channel transmissivity (default: 0).</value>
        [DataMember(Name="r_transmissivity", EmitDefaultValue=false)]
        [JsonProperty("r_transmissivity")]
        public double RTransmissivity { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the green channel transmissivity (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the green channel transmissivity (default: 0).</value>
        [DataMember(Name="g_transmissivity", EmitDefaultValue=false)]
        [JsonProperty("g_transmissivity")]
        public double GTransmissivity { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the blue channel transmissivity (default: 0).
        /// </summary>
        /// <value>A value between 0 and 1 for the blue channel transmissivity (default: 0).</value>
        [DataMember(Name="b_transmissivity", EmitDefaultValue=false)]
        [JsonProperty("b_transmissivity")]
        public double BTransmissivity { get; set; }  = 0.0D;
        /// <summary>
        /// A value between 0 and 1 for the index of refraction (default: 1.52).
        /// </summary>
        /// <value>A value between 0 and 1 for the index of refraction (default: 1.52).</value>
        [DataMember(Name="refraction_index", EmitDefaultValue=false)]
        [JsonProperty("refraction_index")]
        public double RefractionIndex { get; set; }  = 1.52D;
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Glass {iDd.Identifier}";
       
            return "Glass";
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
            sb.Append("Glass:\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Modifier: ").Append(Modifier).Append("\n");
            sb.Append("  Dependencies: ").Append(Dependencies).Append("\n");
            sb.Append("  RTransmissivity: ").Append(RTransmissivity).Append("\n");
            sb.Append("  GTransmissivity: ").Append(GTransmissivity).Append("\n");
            sb.Append("  BTransmissivity: ").Append(BTransmissivity).Append("\n");
            sb.Append("  RefractionIndex: ").Append(RefractionIndex).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Glass object</returns>
        public static Glass FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Glass>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Glass object</returns>
        public Glass DuplicateGlass()
        {
            return Duplicate() as Glass;
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
            return this.Equals(input as Glass);
        }

        /// <summary>
        /// Returns true if Glass instances are equal
        /// </summary>
        /// <param name="input">Instance of Glass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Glass input)
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
                    this.RTransmissivity == input.RTransmissivity ||
                    (this.RTransmissivity != null &&
                    this.RTransmissivity.Equals(input.RTransmissivity))
                ) && base.Equals(input) && 
                (
                    this.GTransmissivity == input.GTransmissivity ||
                    (this.GTransmissivity != null &&
                    this.GTransmissivity.Equals(input.GTransmissivity))
                ) && base.Equals(input) && 
                (
                    this.BTransmissivity == input.BTransmissivity ||
                    (this.BTransmissivity != null &&
                    this.BTransmissivity.Equals(input.BTransmissivity))
                ) && base.Equals(input) && 
                (
                    this.RefractionIndex == input.RefractionIndex ||
                    (this.RefractionIndex != null &&
                    this.RefractionIndex.Equals(input.RefractionIndex))
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
                if (this.RTransmissivity != null)
                    hashCode = hashCode * 59 + this.RTransmissivity.GetHashCode();
                if (this.GTransmissivity != null)
                    hashCode = hashCode * 59 + this.GTransmissivity.GetHashCode();
                if (this.BTransmissivity != null)
                    hashCode = hashCode * 59 + this.BTransmissivity.GetHashCode();
                if (this.RefractionIndex != null)
                    hashCode = hashCode * 59 + this.RefractionIndex.GetHashCode();
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
            // RTransmissivity (double) maximum
            if(this.RTransmissivity > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RTransmissivity, must be a value less than or equal to 1.", new [] { "RTransmissivity" });
            }

            // RTransmissivity (double) minimum
            if(this.RTransmissivity < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RTransmissivity, must be a value greater than or equal to 0.", new [] { "RTransmissivity" });
            }

            // GTransmissivity (double) maximum
            if(this.GTransmissivity > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GTransmissivity, must be a value less than or equal to 1.", new [] { "GTransmissivity" });
            }

            // GTransmissivity (double) minimum
            if(this.GTransmissivity < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GTransmissivity, must be a value greater than or equal to 0.", new [] { "GTransmissivity" });
            }

            // BTransmissivity (double) maximum
            if(this.BTransmissivity > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BTransmissivity, must be a value less than or equal to 1.", new [] { "BTransmissivity" });
            }

            // BTransmissivity (double) minimum
            if(this.BTransmissivity < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BTransmissivity, must be a value greater than or equal to 0.", new [] { "BTransmissivity" });
            }

            // RefractionIndex (double) minimum
            if(this.RefractionIndex < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RefractionIndex, must be a value greater than or equal to 0.", new [] { "RefractionIndex" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^glass$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
