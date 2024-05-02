/* 
 * Honeybee Simulation Parameter Schema
 *
 * Documentation for Honeybee simulation-parameter schema
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
    /// Lists the outputs to report from the simulation and their format.
    /// </summary>
    [Summary(@"Lists the outputs to report from the simulation and their format.")]
    [Serializable]
    [DataContract(Name = "SimulationOutput")]
    public partial class SimulationOutput : OpenAPIGenBaseModel, IEquatable<SimulationOutput>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ReportingFrequency
        /// </summary>
        [Summary(@"ReportingFrequency")]
        [DataMember(Name="reporting_frequency")]
        public ReportingFrequency ReportingFrequency { get; set; } = ReportingFrequency.Hourly;
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationOutput" /> class.
        /// </summary>
        /// <param name="reportingFrequency">reportingFrequency.</param>
        /// <param name="outputs">A list of EnergyPlus output names as strings, which are requested from the simulation..</param>
        /// <param name="summaryReports">A list of EnergyPlus summary report names as strings..</param>
        /// <param name="unmetSetpointTolerance">A number in degrees Celsius for the difference that the zone conditions must be from the thermostat setpoint in order for the setpoint to be considered unmet. This will affect how unmet hours are reported in the output. ASHRAE 90.1 uses a tolerance of 1.11C, which is equivalent to 1.8F. (default to 1.11D).</param>
        public SimulationOutput
        (
            // Required parameters
           ReportingFrequency reportingFrequency= ReportingFrequency.Hourly, List<string> outputs= default, List<string> summaryReports= default, double unmetSetpointTolerance = 1.11D// Optional parameters
        ) : base()// BaseClass
        {
            this.ReportingFrequency = reportingFrequency;
            this.Outputs = outputs;
            this.SummaryReports = summaryReports;
            this.UnmetSetpointTolerance = unmetSetpointTolerance;

            // Set non-required readonly properties with defaultValue
            this.Type = "SimulationOutput";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(SimulationOutput))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [Summary(@"Type")]
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "SimulationOutput";

        /// <summary>
        /// A list of EnergyPlus output names as strings, which are requested from the simulation.
        /// </summary>
        /// <value>A list of EnergyPlus output names as strings, which are requested from the simulation.</value>
        [Summary(@"A list of EnergyPlus output names as strings, which are requested from the simulation.")]
        [DataMember(Name = "outputs")]
        public List<string> Outputs { get; set; } 
        /// <summary>
        /// A list of EnergyPlus summary report names as strings.
        /// </summary>
        /// <value>A list of EnergyPlus summary report names as strings.</value>
        [Summary(@"A list of EnergyPlus summary report names as strings.")]
        [DataMember(Name = "summary_reports")]
        public List<string> SummaryReports { get; set; } 
        /// <summary>
        /// A number in degrees Celsius for the difference that the zone conditions must be from the thermostat setpoint in order for the setpoint to be considered unmet. This will affect how unmet hours are reported in the output. ASHRAE 90.1 uses a tolerance of 1.11C, which is equivalent to 1.8F.
        /// </summary>
        /// <value>A number in degrees Celsius for the difference that the zone conditions must be from the thermostat setpoint in order for the setpoint to be considered unmet. This will affect how unmet hours are reported in the output. ASHRAE 90.1 uses a tolerance of 1.11C, which is equivalent to 1.8F.</value>
        [Summary(@"A number in degrees Celsius for the difference that the zone conditions must be from the thermostat setpoint in order for the setpoint to be considered unmet. This will affect how unmet hours are reported in the output. ASHRAE 90.1 uses a tolerance of 1.11C, which is equivalent to 1.8F.")]
        [DataMember(Name = "unmet_setpoint_tolerance")]
        public double UnmetSetpointTolerance { get; set; }  = 1.11D;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "SimulationOutput";
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
            sb.Append("SimulationOutput:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  ReportingFrequency: ").Append(this.ReportingFrequency).Append("\n");
            sb.Append("  Outputs: ").Append(this.Outputs).Append("\n");
            sb.Append("  SummaryReports: ").Append(this.SummaryReports).Append("\n");
            sb.Append("  UnmetSetpointTolerance: ").Append(this.UnmetSetpointTolerance).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SimulationOutput object</returns>
        public static SimulationOutput FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<SimulationOutput>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>SimulationOutput object</returns>
        public virtual SimulationOutput DuplicateSimulationOutput()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateSimulationOutput();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateSimulationOutput();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as SimulationOutput);
        }

        /// <summary>
        /// Returns true if SimulationOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationOutput input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.ReportingFrequency, input.ReportingFrequency) && 
                (
                    this.Outputs == input.Outputs ||
                    Extension.AllEquals(this.Outputs, input.Outputs)
                ) && 
                (
                    this.SummaryReports == input.SummaryReports ||
                    Extension.AllEquals(this.SummaryReports, input.SummaryReports)
                ) && 
                    Extension.Equals(this.UnmetSetpointTolerance, input.UnmetSetpointTolerance);
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ReportingFrequency != null)
                    hashCode = hashCode * 59 + this.ReportingFrequency.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                if (this.SummaryReports != null)
                    hashCode = hashCode * 59 + this.SummaryReports.GetHashCode();
                if (this.UnmetSetpointTolerance != null)
                    hashCode = hashCode * 59 + this.UnmetSetpointTolerance.GetHashCode();
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

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^SimulationOutput$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }


            
            // UnmetSetpointTolerance (double) maximum
            if(this.UnmetSetpointTolerance > (double)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnmetSetpointTolerance, must be a value less than or equal to 10.", new [] { "UnmetSetpointTolerance" });
            }

            // UnmetSetpointTolerance (double) minimum
            if(this.UnmetSetpointTolerance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnmetSetpointTolerance, must be a value greater than or equal to 0.", new [] { "UnmetSetpointTolerance" });
            }

            yield break;
        }
    }
}
