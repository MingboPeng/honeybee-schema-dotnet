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
    /// A set of constructions for roof and ceiling assemblies.
    /// </summary>
    [DataContract]
    public partial class RoofCeilingConstructionSet : HoneybeeObject, IEquatable<RoofCeilingConstructionSet>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="RoofCeilingConstructionSet" /> class.
        /// </summary>
        /// <param name="interiorConstruction">An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition..</param>
        /// <param name="exteriorConstruction">An OpaqueConstruction for walls with an Outdoors boundary condition..</param>
        /// <param name="groundConstruction">An OpaqueConstruction for walls with a Ground boundary condition..</param>
        public RoofCeilingConstructionSet
        (
             // Required parameters
            OpaqueConstruction interiorConstruction= default, OpaqueConstruction exteriorConstruction= default, OpaqueConstruction groundConstruction= default // Optional parameters
        )// BaseClass
        {
            this.InteriorConstruction = interiorConstruction;
            this.ExteriorConstruction = exteriorConstruction;
            this.GroundConstruction = groundConstruction;

            // Set non-required readonly properties with defaultValue
            this.Type = "RoofCeilingConstructionSet";
        }
        
        /// <summary>
        /// An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with a Surface or Adiabatic boundary condition.</value>
        [DataMember(Name="interior_construction", EmitDefaultValue=false)]
        [JsonProperty("interior_construction")]
        public OpaqueConstruction InteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for walls with an Outdoors boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with an Outdoors boundary condition.</value>
        [DataMember(Name="exterior_construction", EmitDefaultValue=false)]
        [JsonProperty("exterior_construction")]
        public OpaqueConstruction ExteriorConstruction { get; set; } 
        /// <summary>
        /// An OpaqueConstruction for walls with a Ground boundary condition.
        /// </summary>
        /// <value>An OpaqueConstruction for walls with a Ground boundary condition.</value>
        [DataMember(Name="ground_construction", EmitDefaultValue=false)]
        [JsonProperty("ground_construction")]
        public OpaqueConstruction GroundConstruction { get; set; } 
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"RoofCeilingConstructionSet {iDd.Identifier}";
       
            return "RoofCeilingConstructionSet";
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
            sb.Append("RoofCeilingConstructionSet:\n");
            sb.Append("  InteriorConstruction: ").Append(InteriorConstruction).Append("\n");
            sb.Append("  ExteriorConstruction: ").Append(ExteriorConstruction).Append("\n");
            sb.Append("  GroundConstruction: ").Append(GroundConstruction).Append("\n");
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
        /// <returns>RoofCeilingConstructionSet object</returns>
        public static RoofCeilingConstructionSet FromJson(string json)
        {
            return JsonConvert.DeserializeObject<RoofCeilingConstructionSet>(json, JsonSetting.AnyOfConvertSetting);
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RoofCeilingConstructionSet);
        }

        /// <summary>
        /// Returns true if RoofCeilingConstructionSet instances are equal
        /// </summary>
        /// <param name="input">Instance of RoofCeilingConstructionSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoofCeilingConstructionSet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InteriorConstruction == input.InteriorConstruction ||
                    (this.InteriorConstruction != null &&
                    this.InteriorConstruction.Equals(input.InteriorConstruction))
                ) && 
                (
                    this.ExteriorConstruction == input.ExteriorConstruction ||
                    (this.ExteriorConstruction != null &&
                    this.ExteriorConstruction.Equals(input.ExteriorConstruction))
                ) && 
                (
                    this.GroundConstruction == input.GroundConstruction ||
                    (this.GroundConstruction != null &&
                    this.GroundConstruction.Equals(input.GroundConstruction))
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
                if (this.InteriorConstruction != null)
                    hashCode = hashCode * 59 + this.InteriorConstruction.GetHashCode();
                if (this.ExteriorConstruction != null)
                    hashCode = hashCode * 59 + this.ExteriorConstruction.GetHashCode();
                if (this.GroundConstruction != null)
                    hashCode = hashCode * 59 + this.GroundConstruction.GetHashCode();
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
            Regex regexType = new Regex(@"^RoofCeilingConstructionSet$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
