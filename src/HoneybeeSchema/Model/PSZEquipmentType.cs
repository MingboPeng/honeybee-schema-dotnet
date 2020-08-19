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
    
    public enum PSZEquipmentType
    {
        /// <summary>
        /// Enum ACwithbaseboardelectric for value: PSZ-AC with baseboard electric
        /// </summary>
        [EnumMember(Value = "PSZ-AC with baseboard electric")]
        ACwithbaseboardelectric = 1,

        /// <summary>
        /// Enum ACwithbaseboardgasboiler for value: PSZ-AC with baseboard gas boiler
        /// </summary>
        [EnumMember(Value = "PSZ-AC with baseboard gas boiler")]
        ACwithbaseboardgasboiler = 2,

        /// <summary>
        /// Enum ACwithbaseboarddistricthotwater for value: PSZ-AC with baseboard district hot water
        /// </summary>
        [EnumMember(Value = "PSZ-AC with baseboard district hot water")]
        ACwithbaseboarddistricthotwater = 3,

        /// <summary>
        /// Enum ACwithgasunitheaters for value: PSZ-AC with gas unit heaters
        /// </summary>
        [EnumMember(Value = "PSZ-AC with gas unit heaters")]
        ACwithgasunitheaters = 4,

        /// <summary>
        /// Enum ACwithelectriccoil for value: PSZ-AC with electric coil
        /// </summary>
        [EnumMember(Value = "PSZ-AC with electric coil")]
        ACwithelectriccoil = 5,

        /// <summary>
        /// Enum ACwithgascoil for value: PSZ-AC with gas coil
        /// </summary>
        [EnumMember(Value = "PSZ-AC with gas coil")]
        ACwithgascoil = 6,

        /// <summary>
        /// Enum ACwithgasboiler for value: PSZ-AC with gas boiler
        /// </summary>
        [EnumMember(Value = "PSZ-AC with gas boiler")]
        ACwithgasboiler = 7,

        /// <summary>
        /// Enum ACwithcentralairsourceheatpump for value: PSZ-AC with central air source heat pump
        /// </summary>
        [EnumMember(Value = "PSZ-AC with central air source heat pump")]
        ACwithcentralairsourceheatpump = 8,

        /// <summary>
        /// Enum ACwithdistricthotwater for value: PSZ-AC with district hot water
        /// </summary>
        [EnumMember(Value = "PSZ-AC with district hot water")]
        ACwithdistricthotwater = 9,

        /// <summary>
        /// Enum ACwithnoheat for value: PSZ-AC with no heat
        /// </summary>
        [EnumMember(Value = "PSZ-AC with no heat")]
        ACwithnoheat = 10,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithbaseboardelectric for value: PSZ-AC district chilled water with baseboard electric
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with baseboard electric")]
        ACdistrictchilledwaterwithbaseboardelectric = 11,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithbaseboardgasboiler for value: PSZ-AC district chilled water with baseboard gas boiler
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with baseboard gas boiler")]
        ACdistrictchilledwaterwithbaseboardgasboiler = 12,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithbaseboarddistricthotwater for value: PSZ-AC district chilled water with baseboard district hot water
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with baseboard district hot water")]
        ACdistrictchilledwaterwithbaseboarddistricthotwater = 13,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithgasunitheaters for value: PSZ-AC district chilled water with gas unit heaters
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with gas unit heaters")]
        ACdistrictchilledwaterwithgasunitheaters = 14,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithelectriccoil for value: PSZ-AC district chilled water with electric coil
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with electric coil")]
        ACdistrictchilledwaterwithelectriccoil = 15,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithgascoil for value: PSZ-AC district chilled water with gas coil
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with gas coil")]
        ACdistrictchilledwaterwithgascoil = 16,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithgasboiler for value: PSZ-AC district chilled water with gas boiler
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with gas boiler")]
        ACdistrictchilledwaterwithgasboiler = 17,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithcentralairsourceheatpump for value: PSZ-AC district chilled water with central air source heat pump
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with central air source heat pump")]
        ACdistrictchilledwaterwithcentralairsourceheatpump = 18,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithdistricthotwater for value: PSZ-AC district chilled water with district hot water
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with district hot water")]
        ACdistrictchilledwaterwithdistricthotwater = 19,

        /// <summary>
        /// Enum ACdistrictchilledwaterwithnoheat for value: PSZ-AC district chilled water with no heat
        /// </summary>
        [EnumMember(Value = "PSZ-AC district chilled water with no heat")]
        ACdistrictchilledwaterwithnoheat = 20,

        /// <summary>
        /// Enum HP for value: PSZ-HP
        /// </summary>
        [EnumMember(Value = "PSZ-HP")]
        HP = 21

    }

}
