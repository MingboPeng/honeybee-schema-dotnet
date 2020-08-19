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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum WindowACEquipmentType
    {
        /// <summary>
        /// Enum Baseboardelectric for value: Window AC with baseboard electric
        /// </summary>
        [EnumMember(Value = "Window AC with baseboard electric")]
        Baseboardelectric = 1,

        /// <summary>
        /// Enum Baseboardgasboiler for value: Window AC with baseboard gas boiler
        /// </summary>
        [EnumMember(Value = "Window AC with baseboard gas boiler")]
        Baseboardgasboiler = 2,

        /// <summary>
        /// Enum Baseboardcentralairsourceheatpump for value: Window AC with baseboard central air source heat pump
        /// </summary>
        [EnumMember(Value = "Window AC with baseboard central air source heat pump")]
        Baseboardcentralairsourceheatpump = 3,

        /// <summary>
        /// Enum Baseboarddistricthotwater for value: Window AC with baseboard district hot water
        /// </summary>
        [EnumMember(Value = "Window AC with baseboard district hot water")]
        Baseboarddistricthotwater = 4,

        /// <summary>
        /// Enum Forcedairfurnace for value: Window AC with forced air furnace
        /// </summary>
        [EnumMember(Value = "Window AC with forced air furnace")]
        Forcedairfurnace = 5,

        /// <summary>
        /// Enum Unitheaters for value: Window AC with unit heaters
        /// </summary>
        [EnumMember(Value = "Window AC with unit heaters")]
        Unitheaters = 6,

        /// <summary>
        /// Enum Noheat for value: Window AC with no heat
        /// </summary>
        [EnumMember(Value = "Window AC with no heat")]
        Noheat = 7

    }

}
