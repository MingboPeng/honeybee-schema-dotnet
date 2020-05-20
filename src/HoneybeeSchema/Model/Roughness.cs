/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
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
    /// Defines Roughness
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Roughness
    {
        /// <summary>
        /// Enum VeryRough for value: VeryRough
        /// </summary>
        [EnumMember(Value = "VeryRough")]
        VeryRough = 1,

        /// <summary>
        /// Enum Rough for value: Rough
        /// </summary>
        [EnumMember(Value = "Rough")]
        Rough = 2,

        /// <summary>
        /// Enum MediumRough for value: MediumRough
        /// </summary>
        [EnumMember(Value = "MediumRough")]
        MediumRough = 3,

        /// <summary>
        /// Enum MediumSmooth for value: MediumSmooth
        /// </summary>
        [EnumMember(Value = "MediumSmooth")]
        MediumSmooth = 4,

        /// <summary>
        /// Enum Smooth for value: Smooth
        /// </summary>
        [EnumMember(Value = "Smooth")]
        Smooth = 5,

        /// <summary>
        /// Enum VerySmooth for value: VerySmooth
        /// </summary>
        [EnumMember(Value = "VerySmooth")]
        VerySmooth = 6

    }

}
