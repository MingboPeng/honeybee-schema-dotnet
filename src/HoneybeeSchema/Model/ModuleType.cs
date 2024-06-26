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
    
    public enum ModuleType
    {
        /// <summary>
        /// Enum Standard for value: Standard
        /// </summary>
        [EnumMember(Value = "Standard")]
        Standard = 1,

        /// <summary>
        /// Enum Premium for value: Premium
        /// </summary>
        [EnumMember(Value = "Premium")]
        Premium = 2,

        /// <summary>
        /// Enum ThinFilm for value: ThinFilm
        /// </summary>
        [EnumMember(Value = "ThinFilm")]
        ThinFilm = 3

    }

}
