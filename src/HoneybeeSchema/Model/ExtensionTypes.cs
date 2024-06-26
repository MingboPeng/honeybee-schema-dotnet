/* 
 * Honeybee Validation Report Schema
 *
 * Honeybee validation-report schema.
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
    /// Types of Honeybee/Dragonfly extensions.
    /// </summary>
    /// <value>Types of Honeybee/Dragonfly extensions.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ExtensionTypes
    {
        /// <summary>
        /// Enum Core for value: Core
        /// </summary>
        [EnumMember(Value = "Core")]
        Core = 1,

        /// <summary>
        /// Enum Radiance for value: Radiance
        /// </summary>
        [EnumMember(Value = "Radiance")]
        Radiance = 2,

        /// <summary>
        /// Enum Energy for value: Energy
        /// </summary>
        [EnumMember(Value = "Energy")]
        Energy = 3

    }

}
