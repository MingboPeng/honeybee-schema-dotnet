/* 
 * Honeybee Model Schema
 *
 * Documentation for Honeybee model schema
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
    
    public enum RadiantwithDOASEquipmentType
    {
        /// <summary>
        /// Enum ChillerBoiler for value: DOAS_Radiant_Chiller_Boiler
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_Chiller_Boiler")]
        DOAS_Radiant_Chiller_Boiler = 1,

        /// <summary>
        /// Enum ChillerASHP for value: DOAS_Radiant_Chiller_ASHP
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_Chiller_ASHP")]
        DOAS_Radiant_Chiller_ASHP = 2,

        /// <summary>
        /// Enum ChillerDHW for value: DOAS_Radiant_Chiller_DHW
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_Chiller_DHW")]
        DOAS_Radiant_Chiller_DHW = 3,

        /// <summary>
        /// Enum ACChillerBoiler for value: DOAS_Radiant_ACChiller_Boiler
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_ACChiller_Boiler")]
        DOAS_Radiant_ACChiller_Boiler = 4,

        /// <summary>
        /// Enum ACChillerASHP for value: DOAS_Radiant_ACChiller_ASHP
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_ACChiller_ASHP")]
        DOAS_Radiant_ACChiller_ASHP = 5,

        /// <summary>
        /// Enum ACChillerDHW for value: DOAS_Radiant_ACChiller_DHW
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_ACChiller_DHW")]
        DOAS_Radiant_ACChiller_DHW = 6,

        /// <summary>
        /// Enum DCWBoiler for value: DOAS_Radiant_DCW_Boiler
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_DCW_Boiler")]
        DOAS_Radiant_DCW_Boiler = 7,

        /// <summary>
        /// Enum DCWASHP for value: DOAS_Radiant_DCW_ASHP
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_DCW_ASHP")]
        DOAS_Radiant_DCW_ASHP = 8,

        /// <summary>
        /// Enum DCWDHW for value: DOAS_Radiant_DCW_DHW
        /// </summary>
        [EnumMember(Value = "DOAS_Radiant_DCW_DHW")]
        DOAS_Radiant_DCW_DHW = 9

    }

}