/* 
 * Honeybee Simulation Parameter Schema
 *
 * Documentation for Honeybee simulation-parameter schema
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
    /// An enumeration.
    /// </summary>
    /// <value>An enumeration.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ClimateZones
    {
        /// <summary>
        /// Enum _0A for value: 0A
        /// </summary>
        [EnumMember(Value = "0A")]
        ZeroA = 1,

        /// <summary>
        /// Enum _1A for value: 1A
        /// </summary>
        [EnumMember(Value = "1A")]
        OneA = 2,

        /// <summary>
        /// Enum _2A for value: 2A
        /// </summary>
        [EnumMember(Value = "2A")]
        TwoA = 3,

        /// <summary>
        /// Enum _3A for value: 3A
        /// </summary>
        [EnumMember(Value = "3A")]
        ThreeA = 4,

        /// <summary>
        /// Enum _4A for value: 4A
        /// </summary>
        [EnumMember(Value = "4A")]
        FourA = 5,

        /// <summary>
        /// Enum _5A for value: 5A
        /// </summary>
        [EnumMember(Value = "5A")]
        FiveA = 6,

        /// <summary>
        /// Enum _6A for value: 6A
        /// </summary>
        [EnumMember(Value = "6A")]
        SixA = 7,

        /// <summary>
        /// Enum _0B for value: 0B
        /// </summary>
        [EnumMember(Value = "0B")]
        ZeroB = 8,

        /// <summary>
        /// Enum _1B for value: 1B
        /// </summary>
        [EnumMember(Value = "1B")]
        OneB = 9,

        /// <summary>
        /// Enum _2B for value: 2B
        /// </summary>
        [EnumMember(Value = "2B")]
        TwoB = 10,

        /// <summary>
        /// Enum _3B for value: 3B
        /// </summary>
        [EnumMember(Value = "3B")]
        ThreeB = 11,

        /// <summary>
        /// Enum _4B for value: 4B
        /// </summary>
        [EnumMember(Value = "4B")]
        FourB = 12,

        /// <summary>
        /// Enum _5B for value: 5B
        /// </summary>
        [EnumMember(Value = "5B")]
        FiveB = 13,

        /// <summary>
        /// Enum _6B for value: 6B
        /// </summary>
        [EnumMember(Value = "6B")]
        SixB = 14,

        /// <summary>
        /// Enum _3C for value: 3C
        /// </summary>
        [EnumMember(Value = "3C")]
        ThreeC = 15,

        /// <summary>
        /// Enum _4C for value: 4C
        /// </summary>
        [EnumMember(Value = "4C")]
        FourC = 16,

        /// <summary>
        /// Enum _5C for value: 5C
        /// </summary>
        [EnumMember(Value = "5C")]
        FiveC = 17,

        /// <summary>
        /// Enum _7 for value: 7
        /// </summary>
        [EnumMember(Value = "7")]
        Seven = 18,

        /// <summary>
        /// Enum _8 for value: 8
        /// </summary>
        [EnumMember(Value = "8")]
        Eight = 19

    }

}