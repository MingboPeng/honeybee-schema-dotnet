/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
 *
 * The version of the OpenAPI document: 1.31.0
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
    /// Defines CalculationMethod
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CalculationMethod
    {
        /// <summary>
        /// Enum AverageOverDaysInFrequency for value: AverageOverDaysInFrequency
        /// </summary>
        [EnumMember(Value = "AverageOverDaysInFrequency")]
        AverageOverDaysInFrequency = 1,

        /// <summary>
        /// Enum TimestepFrequency for value: TimestepFrequency
        /// </summary>
        [EnumMember(Value = "TimestepFrequency")]
        TimestepFrequency = 2

    }

}
