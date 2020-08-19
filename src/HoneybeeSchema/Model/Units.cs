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
    
    public enum Units
    {
        /// <summary>
        /// Enum Meters for value: Meters
        /// </summary>
        [EnumMember(Value = "Meters")]
        Meters = 1,

        /// <summary>
        /// Enum Millimeters for value: Millimeters
        /// </summary>
        [EnumMember(Value = "Millimeters")]
        Millimeters = 2,

        /// <summary>
        /// Enum Feet for value: Feet
        /// </summary>
        [EnumMember(Value = "Feet")]
        Feet = 3,

        /// <summary>
        /// Enum Inches for value: Inches
        /// </summary>
        [EnumMember(Value = "Inches")]
        Inches = 4,

        /// <summary>
        /// Enum Centimeters for value: Centimeters
        /// </summary>
        [EnumMember(Value = "Centimeters")]
        Centimeters = 5

    }

}
