/* 
 * Honeybee Sync Instructions Schema
 *
 * Documentation for Honeybee sync-instructions schema
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
    /// Types of Honeybee geometry objects.
    /// </summary>
    /// <value>Types of Honeybee geometry objects.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum GeometryObjectTypes
    {
        /// <summary>
        /// Enum Shade for value: Shade
        /// </summary>
        [EnumMember(Value = "Shade")]
        Shade = 1,

        /// <summary>
        /// Enum Aperture for value: Aperture
        /// </summary>
        [EnumMember(Value = "Aperture")]
        Aperture = 2,

        /// <summary>
        /// Enum Door for value: Door
        /// </summary>
        [EnumMember(Value = "Door")]
        Door = 3,

        /// <summary>
        /// Enum Face for value: Face
        /// </summary>
        [EnumMember(Value = "Face")]
        Face = 4,

        /// <summary>
        /// Enum Room for value: Room
        /// </summary>
        [EnumMember(Value = "Room")]
        Room = 5

    }

}
