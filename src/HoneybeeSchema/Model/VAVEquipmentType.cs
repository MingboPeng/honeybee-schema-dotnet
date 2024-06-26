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
    
    public enum VAVEquipmentType
    {
        /// <summary>
        /// Enum ChillerBoiler for value: VAV_Chiller_Boiler
        /// </summary>
        [EnumMember(Value = "VAV_Chiller_Boiler")]
        VAV_Chiller_Boiler = 1,

        /// <summary>
        /// Enum ChillerASHP for value: VAV_Chiller_ASHP
        /// </summary>
        [EnumMember(Value = "VAV_Chiller_ASHP")]
        VAV_Chiller_ASHP = 2,

        /// <summary>
        /// Enum ChillerDHW for value: VAV_Chiller_DHW
        /// </summary>
        [EnumMember(Value = "VAV_Chiller_DHW")]
        VAV_Chiller_DHW = 3,

        /// <summary>
        /// Enum ChillerPFP for value: VAV_Chiller_PFP
        /// </summary>
        [EnumMember(Value = "VAV_Chiller_PFP")]
        VAV_Chiller_PFP = 4,

        /// <summary>
        /// Enum ChillerGasCoil for value: VAV_Chiller_GasCoil
        /// </summary>
        [EnumMember(Value = "VAV_Chiller_GasCoil")]
        VAV_Chiller_GasCoil = 5,

        /// <summary>
        /// Enum ACChillerBoiler for value: VAV_ACChiller_Boiler
        /// </summary>
        [EnumMember(Value = "VAV_ACChiller_Boiler")]
        VAV_ACChiller_Boiler = 6,

        /// <summary>
        /// Enum ACChillerASHP for value: VAV_ACChiller_ASHP
        /// </summary>
        [EnumMember(Value = "VAV_ACChiller_ASHP")]
        VAV_ACChiller_ASHP = 7,

        /// <summary>
        /// Enum ACChillerDHW for value: VAV_ACChiller_DHW
        /// </summary>
        [EnumMember(Value = "VAV_ACChiller_DHW")]
        VAV_ACChiller_DHW = 8,

        /// <summary>
        /// Enum ACChillerPFP for value: VAV_ACChiller_PFP
        /// </summary>
        [EnumMember(Value = "VAV_ACChiller_PFP")]
        VAV_ACChiller_PFP = 9,

        /// <summary>
        /// Enum ACChillerGasCoil for value: VAV_ACChiller_GasCoil
        /// </summary>
        [EnumMember(Value = "VAV_ACChiller_GasCoil")]
        VAV_ACChiller_GasCoil = 10,

        /// <summary>
        /// Enum DCWBoiler for value: VAV_DCW_Boiler
        /// </summary>
        [EnumMember(Value = "VAV_DCW_Boiler")]
        VAV_DCW_Boiler = 11,

        /// <summary>
        /// Enum DCWASHP for value: VAV_DCW_ASHP
        /// </summary>
        [EnumMember(Value = "VAV_DCW_ASHP")]
        VAV_DCW_ASHP = 12,

        /// <summary>
        /// Enum DCWDHW for value: VAV_DCW_DHW
        /// </summary>
        [EnumMember(Value = "VAV_DCW_DHW")]
        VAV_DCW_DHW = 13,

        /// <summary>
        /// Enum DCWPFP for value: VAV_DCW_PFP
        /// </summary>
        [EnumMember(Value = "VAV_DCW_PFP")]
        VAV_DCW_PFP = 14,

        /// <summary>
        /// Enum DCWGasCoil for value: VAV_DCW_GasCoil
        /// </summary>
        [EnumMember(Value = "VAV_DCW_GasCoil")]
        VAV_DCW_GasCoil = 15

    }

}
