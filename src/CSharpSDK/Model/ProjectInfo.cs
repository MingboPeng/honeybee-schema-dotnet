﻿/* 
 * HoneybeeSchema
 *
 * Contact: info@ladybug.tools
 */

extern alias LBTNewtonSoft;
//using System;
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
    /// Project information.
    /// </summary>
    [Summary(@"Project information.")]
    [System.Serializable]
    [DataContract(Name = "ProjectInfo")]
    public partial class ProjectInfo : OpenAPIGenBaseModel, System.IEquatable<ProjectInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectInfo" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected ProjectInfo() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "ProjectInfo";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectInfo" /> class.
        /// </summary>
        /// <param name="north">A number between -360 to 360 where positive values rotate the compass counterclockwise (towards the West) and negative values rotate the compass clockwise (towards the East).</param>
        /// <param name="weatherUrls">A list of URLs to zip files that includes EPW, DDY and STAT files. You can find these URLs from the EPWMAP. The first URL will be used as the primary weather file.</param>
        /// <param name="location">Project location. This value is usually generated from the information in the weather files.</param>
        /// <param name="ashraeClimateZone">Project location climate zone.</param>
        /// <param name="buildingType">A list of building types for the project. The first building type is considered the primary type for the project.</param>
        /// <param name="vintage">A list of building vintages (e.g. ASHRAE_2019, ASHRAE_2016).</param>
        public ProjectInfo
        (
            double north = 0D, List<string> weatherUrls = default, Location location = default, ClimateZones ashraeClimateZone = default, List<BuildingTypes> buildingType = default, List<EfficiencyStandards> vintage = default
        ) : base()
        {
            this.North = north;
            this.WeatherUrls = weatherUrls;
            this.Location = location;
            this.AshraeClimateZone = ashraeClimateZone;
            this.BuildingType = buildingType;
            this.Vintage = vintage;

            // Set readonly properties with defaultValue
            this.Type = "ProjectInfo";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(ProjectInfo))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// A number between -360 to 360 where positive values rotate the compass counterclockwise (towards the West) and negative values rotate the compass clockwise (towards the East).
        /// </summary>
        [Summary(@"A number between -360 to 360 where positive values rotate the compass counterclockwise (towards the West) and negative values rotate the compass clockwise (towards the East).")]
        [Range(-360, 360)]
        [DataMember(Name = "north")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("north")] // For System.Text.Json
        public double North { get; set; } = 0D;

        /// <summary>
        /// A list of URLs to zip files that includes EPW, DDY and STAT files. You can find these URLs from the EPWMAP. The first URL will be used as the primary weather file.
        /// </summary>
        [Summary(@"A list of URLs to zip files that includes EPW, DDY and STAT files. You can find these URLs from the EPWMAP. The first URL will be used as the primary weather file.")]
        [DataMember(Name = "weather_urls")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("weather_urls")] // For System.Text.Json
        public List<string> WeatherUrls { get; set; }

        /// <summary>
        /// Project location. This value is usually generated from the information in the weather files.
        /// </summary>
        [Summary(@"Project location. This value is usually generated from the information in the weather files.")]
        [DataMember(Name = "location")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("location")] // For System.Text.Json
        public Location Location { get; set; }

        /// <summary>
        /// Project location climate zone.
        /// </summary>
        [Summary(@"Project location climate zone.")]
        [DataMember(Name = "ashrae_climate_zone")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("ashrae_climate_zone")] // For System.Text.Json
        public ClimateZones AshraeClimateZone { get; set; }

        /// <summary>
        /// A list of building types for the project. The first building type is considered the primary type for the project.
        /// </summary>
        [Summary(@"A list of building types for the project. The first building type is considered the primary type for the project.")]
        [DataMember(Name = "building_type")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("building_type")] // For System.Text.Json
        public List<BuildingTypes> BuildingType { get; set; }

        /// <summary>
        /// A list of building vintages (e.g. ASHRAE_2019, ASHRAE_2016).
        /// </summary>
        [Summary(@"A list of building vintages (e.g. ASHRAE_2019, ASHRAE_2016).")]
        [DataMember(Name = "vintage")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("vintage")] // For System.Text.Json
        public List<EfficiencyStandards> Vintage { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "ProjectInfo";
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
            sb.Append("ProjectInfo:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  North: ").Append(this.North).Append("\n");
            sb.Append("  WeatherUrls: ").Append(this.WeatherUrls).Append("\n");
            sb.Append("  Location: ").Append(this.Location).Append("\n");
            sb.Append("  AshraeClimateZone: ").Append(this.AshraeClimateZone).Append("\n");
            sb.Append("  BuildingType: ").Append(this.BuildingType).Append("\n");
            sb.Append("  Vintage: ").Append(this.Vintage).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>ProjectInfo object</returns>
        public static ProjectInfo FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<ProjectInfo>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>ProjectInfo object</returns>
        public virtual ProjectInfo DuplicateProjectInfo()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateProjectInfo();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as ProjectInfo);
        }


        /// <summary>
        /// Returns true if ProjectInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ProjectInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProjectInfo input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.North, input.North) && 
                    Extension.AllEquals(this.WeatherUrls, input.WeatherUrls) && 
                    Extension.Equals(this.Location, input.Location) && 
                    Extension.Equals(this.AshraeClimateZone, input.AshraeClimateZone) && 
                    Extension.AllEquals(this.BuildingType, input.BuildingType) && 
                    Extension.AllEquals(this.Vintage, input.Vintage);
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
                if (this.North != null)
                    hashCode = hashCode * 59 + this.North.GetHashCode();
                if (this.WeatherUrls != null)
                    hashCode = hashCode * 59 + this.WeatherUrls.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.AshraeClimateZone != null)
                    hashCode = hashCode * 59 + this.AshraeClimateZone.GetHashCode();
                if (this.BuildingType != null)
                    hashCode = hashCode * 59 + this.BuildingType.GetHashCode();
                if (this.Vintage != null)
                    hashCode = hashCode * 59 + this.Vintage.GetHashCode();
                return hashCode;
            }
        }


    }
}
