/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
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
    /// Defines ReportingFrequency
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReportingFrequency
    {
        /// <summary>
        /// Enum Timestep for value: Timestep
        /// </summary>
        [EnumMember(Value = "Timestep")]
        Timestep = 1,

        /// <summary>
        /// Enum Hourly for value: Hourly
        /// </summary>
        [EnumMember(Value = "Hourly")]
        Hourly = 2,

        /// <summary>
        /// Enum Daily for value: Daily
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily = 3,

        /// <summary>
        /// Enum Monthly for value: Monthly
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly = 4,

        /// <summary>
        /// Enum Annual for value: Annual
        /// </summary>
        [EnumMember(Value = "Annual")]
        Annual = 5

    }

}