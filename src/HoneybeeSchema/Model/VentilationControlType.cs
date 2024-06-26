/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonSoft;
using System;
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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VentilationControlType
    {
        /// <summary>
        /// Enum SingleZone for value: SingleZone
        /// </summary>
        [EnumMember(Value = "SingleZone")]
        SingleZone = 1,

        /// <summary>
        /// Enum MultiZoneWithDistribution for value: MultiZoneWithDistribution
        /// </summary>
        [EnumMember(Value = "MultiZoneWithDistribution")]
        MultiZoneWithDistribution = 2,

        /// <summary>
        /// Enum MultiZoneWithoutDistribution for value: MultiZoneWithoutDistribution
        /// </summary>
        [EnumMember(Value = "MultiZoneWithoutDistribution")]
        MultiZoneWithoutDistribution = 3

    }

}
