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
    
    public enum FCUEquipmentType
    {
        /// <summary>
        /// Enum Chillerwithboiler for value: Fan coil chiller with boiler
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with boiler")]
        Chillerwithboiler = 1,

        /// <summary>
        /// Enum Chillerwithcentralairsourceheatpump for value: Fan coil chiller with central air source heat pump
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with central air source heat pump")]
        Chillerwithcentralairsourceheatpump = 2,

        /// <summary>
        /// Enum Chillerwithdistricthotwater for value: Fan coil chiller with district hot water
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with district hot water")]
        Chillerwithdistricthotwater = 3,

        /// <summary>
        /// Enum Chillerwithbaseboardelectric for value: Fan coil chiller with baseboard electric
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with baseboard electric")]
        Chillerwithbaseboardelectric = 4,

        /// <summary>
        /// Enum Chillerwithgasunitheaters for value: Fan coil chiller with gas unit heaters
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with gas unit heaters")]
        Chillerwithgasunitheaters = 5,

        /// <summary>
        /// Enum Chillerwithnoheat for value: Fan coil chiller with no heat
        /// </summary>
        [EnumMember(Value = "Fan coil chiller with no heat")]
        Chillerwithnoheat = 6,

        /// <summary>
        /// Enum AirCooledchillerwithboiler for value: Fan coil air-cooled chiller with boiler
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with boiler")]
        AirCooledchillerwithboiler = 7,

        /// <summary>
        /// Enum AirCooledchillerwithcentralairsourceheatpump for value: Fan coil air-cooled chiller with central air source heat pump
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with central air source heat pump")]
        AirCooledchillerwithcentralairsourceheatpump = 8,

        /// <summary>
        /// Enum AirCooledchillerwithdistricthotwater for value: Fan coil air-cooled chiller with district hot water
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with district hot water")]
        AirCooledchillerwithdistricthotwater = 9,

        /// <summary>
        /// Enum AirCooledchillerwithbaseboardelectric for value: Fan coil air-cooled chiller with baseboard electric
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with baseboard electric")]
        AirCooledchillerwithbaseboardelectric = 10,

        /// <summary>
        /// Enum AirCooledchillerwithgasunitheaters for value: Fan coil air-cooled chiller with gas unit heaters
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with gas unit heaters")]
        AirCooledchillerwithgasunitheaters = 11,

        /// <summary>
        /// Enum AirCooledchillerwithnoheat for value: Fan coil air-cooled chiller with no heat
        /// </summary>
        [EnumMember(Value = "Fan coil air-cooled chiller with no heat")]
        AirCooledchillerwithnoheat = 12,

        /// <summary>
        /// Enum Districtchilledwaterwithboiler for value: Fan coil district chilled water with boiler
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with boiler")]
        Districtchilledwaterwithboiler = 13,

        /// <summary>
        /// Enum Districtchilledwaterwithcentralairsourceheatpump for value: Fan coil district chilled water with central air source heat pump
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with central air source heat pump")]
        Districtchilledwaterwithcentralairsourceheatpump = 14,

        /// <summary>
        /// Enum Districtchilledwaterwithdistricthotwater for value: Fan coil district chilled water with district hot water
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with district hot water")]
        Districtchilledwaterwithdistricthotwater = 15,

        /// <summary>
        /// Enum Districtchilledwaterwithbaseboardelectric for value: Fan coil district chilled water with baseboard electric
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with baseboard electric")]
        Districtchilledwaterwithbaseboardelectric = 16,

        /// <summary>
        /// Enum Districtchilledwaterwithgasunitheaters for value: Fan coil district chilled water with gas unit heaters
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with gas unit heaters")]
        Districtchilledwaterwithgasunitheaters = 17,

        /// <summary>
        /// Enum Districtchilledwaterwithnoheat for value: Fan coil district chilled water with no heat
        /// </summary>
        [EnumMember(Value = "Fan coil district chilled water with no heat")]
        Districtchilledwaterwithnoheat = 18

    }

}
