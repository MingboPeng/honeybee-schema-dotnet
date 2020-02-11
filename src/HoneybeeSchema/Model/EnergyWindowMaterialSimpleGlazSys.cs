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
    /// Describe an entire glazing system rather than individual layers.  Used when only very limited information is available on the glazing layers or when specific performance levels are being targeted.
    /// </summary>
    [DataContract]
    public partial class EnergyWindowMaterialSimpleGlazSys :  IEquatable<EnergyWindowMaterialSimpleGlazSys>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialSimpleGlazSys" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialSimpleGlazSys() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialSimpleGlazSys" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="uFactor">Used to describe the value for window system U-Factor, or overall heat transfer coefficient in W/(m2-K). (required).</param>
        /// <param name="shgc">Unitless  quantity describing Solar Heat Gain Coefficient for normal incidence and vertical orientation. (required).</param>
        /// <param name="type">type (default to &quot;EnergyWindowMaterialSimpleGlazSys&quot;).</param>
        /// <param name="vt">The fraction of visible light falling on the window that makes it through the glass at normal incidence. (default to 0.54).</param>
        public EnergyWindowMaterialSimpleGlazSys(string name, double uFactor, double shgc, string type = "EnergyWindowMaterialSimpleGlazSys", double vt = 0.54)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EnergyWindowMaterialSimpleGlazSys and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "uFactor" is required (not null)
            if (uFactor == null)
            {
                throw new InvalidDataException("uFactor is a required property for EnergyWindowMaterialSimpleGlazSys and cannot be null");
            }
            else
            {
                this.UFactor = uFactor;
            }
            
            // to ensure "shgc" is required (not null)
            if (shgc == null)
            {
                throw new InvalidDataException("shgc is a required property for EnergyWindowMaterialSimpleGlazSys and cannot be null");
            }
            else
            {
                this.Shgc = shgc;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "EnergyWindowMaterialSimpleGlazSys";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "vt" provided
            if (vt == null)
            {
                this.Vt = 0.54;
            }
            else
            {
                this.Vt = vt;
            }
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Used to describe the value for window system U-Factor, or overall heat transfer coefficient in W/(m2-K).
        /// </summary>
        /// <value>Used to describe the value for window system U-Factor, or overall heat transfer coefficient in W/(m2-K).</value>
        [DataMember(Name="u_factor", EmitDefaultValue=false)]
        [JsonProperty("u_factor")]
        public double UFactor { get; set; }

        /// <summary>
        /// Unitless  quantity describing Solar Heat Gain Coefficient for normal incidence and vertical orientation.
        /// </summary>
        /// <value>Unitless  quantity describing Solar Heat Gain Coefficient for normal incidence and vertical orientation.</value>
        [DataMember(Name="shgc", EmitDefaultValue=false)]
        [JsonProperty("shgc")]
        public double Shgc { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The fraction of visible light falling on the window that makes it through the glass at normal incidence.
        /// </summary>
        /// <value>The fraction of visible light falling on the window that makes it through the glass at normal incidence.</value>
        [DataMember(Name="vt", EmitDefaultValue=false)]
        [JsonProperty("vt")]
        public double Vt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyWindowMaterialSimpleGlazSys {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UFactor: ").Append(UFactor).Append("\n");
            sb.Append("  Shgc: ").Append(Shgc).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Vt: ").Append(Vt).Append("\n");
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
        /// <returns>EnergyWindowMaterialSimpleGlazSys object</returns>
        public static EnergyWindowMaterialSimpleGlazSys FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyWindowMaterialSimpleGlazSys>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyWindowMaterialSimpleGlazSys);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialSimpleGlazSys instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialSimpleGlazSys to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialSimpleGlazSys input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UFactor == input.UFactor ||
                    (this.UFactor != null &&
                    this.UFactor.Equals(input.UFactor))
                ) && 
                (
                    this.Shgc == input.Shgc ||
                    (this.Shgc != null &&
                    this.Shgc.Equals(input.Shgc))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Vt == input.Vt ||
                    (this.Vt != null &&
                    this.Vt.Equals(input.Vt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UFactor != null)
                    hashCode = hashCode * 59 + this.UFactor.GetHashCode();
                if (this.Shgc != null)
                    hashCode = hashCode * 59 + this.Shgc.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vt != null)
                    hashCode = hashCode * 59 + this.Vt.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // UFactor (double) maximum
            if(this.UFactor > (double)5.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UFactor, must be a value less than or equal to 5.8.", new [] { "UFactor" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyWindowMaterialSimpleGlazSys$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
