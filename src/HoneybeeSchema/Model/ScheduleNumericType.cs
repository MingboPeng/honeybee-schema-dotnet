/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonSoft; using System;
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
    /// Designates how the range values are validated.
    /// </summary>
    /// <value>Designates how the range values are validated.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ScheduleNumericType
    {
        /// <summary>
        /// Enum Continuous for value: Continuous
        /// </summary>
        [EnumMember(Value = "Continuous")]
        Continuous = 1,

        /// <summary>
        /// Enum Discrete for value: Discrete
        /// </summary>
        [EnumMember(Value = "Discrete")]
        Discrete = 2

    }

}
