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
    /// Designates the acceptable fuel types for process loads.
    /// </summary>
    /// <value>Designates the acceptable fuel types for process loads.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FuelTypes
    {
        /// <summary>
        /// Enum Electricity for value: Electricity
        /// </summary>
        [EnumMember(Value = "Electricity")]
        Electricity = 1,

        /// <summary>
        /// Enum NaturalGas for value: NaturalGas
        /// </summary>
        [EnumMember(Value = "NaturalGas")]
        NaturalGas = 2,

        /// <summary>
        /// Enum Propane for value: Propane
        /// </summary>
        [EnumMember(Value = "Propane")]
        Propane = 3,

        /// <summary>
        /// Enum FuelOilNo1 for value: FuelOilNo1
        /// </summary>
        [EnumMember(Value = "FuelOilNo1")]
        FuelOilNo1 = 4,

        /// <summary>
        /// Enum FuelOilNo2 for value: FuelOilNo2
        /// </summary>
        [EnumMember(Value = "FuelOilNo2")]
        FuelOilNo2 = 5,

        /// <summary>
        /// Enum Diesel for value: Diesel
        /// </summary>
        [EnumMember(Value = "Diesel")]
        Diesel = 6,

        /// <summary>
        /// Enum Gasoline for value: Gasoline
        /// </summary>
        [EnumMember(Value = "Gasoline")]
        Gasoline = 7,

        /// <summary>
        /// Enum Coal for value: Coal
        /// </summary>
        [EnumMember(Value = "Coal")]
        Coal = 8,

        /// <summary>
        /// Enum Steam for value: Steam
        /// </summary>
        [EnumMember(Value = "Steam")]
        Steam = 9,

        /// <summary>
        /// Enum DistrictHeating for value: DistrictHeating
        /// </summary>
        [EnumMember(Value = "DistrictHeating")]
        DistrictHeating = 10,

        /// <summary>
        /// Enum DistrictCooling for value: DistrictCooling
        /// </summary>
        [EnumMember(Value = "DistrictCooling")]
        DistrictCooling = 11,

        /// <summary>
        /// Enum OtherFuel1 for value: OtherFuel1
        /// </summary>
        [EnumMember(Value = "OtherFuel1")]
        OtherFuel1 = 12,

        /// <summary>
        /// Enum OtherFuel2 for value: OtherFuel2
        /// </summary>
        [EnumMember(Value = "OtherFuel2")]
        OtherFuel2 = 13,

        /// <summary>
        /// Enum None for value: None
        /// </summary>
        [EnumMember(Value = "None")]
        None = 14

    }

}
