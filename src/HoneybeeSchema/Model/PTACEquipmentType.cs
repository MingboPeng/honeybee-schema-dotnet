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
    
    public enum PTACEquipmentType
    {
        /// <summary>
        /// Enum PTACElectricBaseboard for value: PTAC_ElectricBaseboard
        /// </summary>
        [EnumMember(Value = "PTAC_ElectricBaseboard")]
        PTAC_ElectricBaseboard = 1,

        /// <summary>
        /// Enum PTACBoilerBaseboard for value: PTAC_BoilerBaseboard
        /// </summary>
        [EnumMember(Value = "PTAC_BoilerBaseboard")]
        PTAC_BoilerBaseboard = 2,

        /// <summary>
        /// Enum PTACDHWBaseboard for value: PTAC_DHWBaseboard
        /// </summary>
        [EnumMember(Value = "PTAC_DHWBaseboard")]
        PTAC_DHWBaseboard = 3,

        /// <summary>
        /// Enum PTACGasHeaters for value: PTAC_GasHeaters
        /// </summary>
        [EnumMember(Value = "PTAC_GasHeaters")]
        PTAC_GasHeaters = 4,

        /// <summary>
        /// Enum PTACElectricCoil for value: PTAC_ElectricCoil
        /// </summary>
        [EnumMember(Value = "PTAC_ElectricCoil")]
        PTAC_ElectricCoil = 5,

        /// <summary>
        /// Enum PTACGasCoil for value: PTAC_GasCoil
        /// </summary>
        [EnumMember(Value = "PTAC_GasCoil")]
        PTAC_GasCoil = 6,

        /// <summary>
        /// Enum PTACBoiler for value: PTAC_Boiler
        /// </summary>
        [EnumMember(Value = "PTAC_Boiler")]
        PTAC_Boiler = 7,

        /// <summary>
        /// Enum PTACASHP for value: PTAC_ASHP
        /// </summary>
        [EnumMember(Value = "PTAC_ASHP")]
        PTAC_ASHP = 8,

        /// <summary>
        /// Enum PTACDHW for value: PTAC_DHW
        /// </summary>
        [EnumMember(Value = "PTAC_DHW")]
        PTAC_DHW = 9,

        /// <summary>
        /// Enum PTAC for value: PTAC
        /// </summary>
        [EnumMember(Value = "PTAC")]
        PTAC = 10,

        /// <summary>
        /// Enum PTHP for value: PTHP
        /// </summary>
        [EnumMember(Value = "PTHP")]
        PTHP = 11

    }

}
