﻿/* 
 * HoneybeeSchema
 *
 * Contact: info@ladybug.tools
 */

extern alias LBTNewtonSoft;
//using System;
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
    /// Window Air Conditioning cooling system (with optional heating).\n\nEach room/zone will receive its own Packaged Terminal Air Conditioner (PTAC)\nwith properties set to reflect a typical window air conditioning (AC) unit.\nNo ventilation air is supplied by the unit and the cooling coil within the\nunit is a single-speed direct expansion (DX) cooling coil. Heating loads\ncan be met with various options, including several types of baseboards,\na furnace, or gas unit heaters.
    /// </summary>
    [Summary(@"Window Air Conditioning cooling system (with optional heating).\n\nEach room/zone will receive its own Packaged Terminal Air Conditioner (PTAC)\nwith properties set to reflect a typical window air conditioning (AC) unit.\nNo ventilation air is supplied by the unit and the cooling coil within the\nunit is a single-speed direct expansion (DX) cooling coil. Heating loads\ncan be met with various options, including several types of baseboards,\na furnace, or gas unit heaters.")]
    [System.Serializable]
    [DataContract(Name = "WindowAC")]
    public partial class WindowAC : IDdEnergyBaseModel, System.IEquatable<WindowAC>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowAC" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WindowAC() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "WindowAC";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="WindowAC" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be < 100 characters, use only ASCII characters and exclude (, ; ! \n \t).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="vintage">Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards</param>
        /// <param name="equipmentType">Text for the specific type of system equipment from the WindowACEquipmentType enumeration.</param>
        public WindowAC
        (
            string identifier, string displayName = default, object userData = default, Vintages vintage = Vintages.ASHRAE_2019, WindowACEquipmentType equipmentType = WindowACEquipmentType.WindowAC_ElectricBaseboard
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Vintage = vintage;
            this.EquipmentType = equipmentType;

            // Set readonly properties with defaultValue
            this.Type = "WindowAC";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(WindowAC))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards
        /// </summary>
        [Summary(@"Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards")]
        [DataMember(Name = "vintage")]
        public Vintages Vintage { get; set; } = Vintages.ASHRAE_2019;

        /// <summary>
        /// Text for the specific type of system equipment from the WindowACEquipmentType enumeration.
        /// </summary>
        [Summary(@"Text for the specific type of system equipment from the WindowACEquipmentType enumeration.")]
        [DataMember(Name = "equipment_type")]
        public WindowACEquipmentType EquipmentType { get; set; } = WindowACEquipmentType.WindowAC_ElectricBaseboard;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "WindowAC";
        }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("WindowAC:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  Vintage: ").Append(this.Vintage).Append("\n");
            sb.Append("  EquipmentType: ").Append(this.EquipmentType).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>WindowAC object</returns>
        public static WindowAC FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<WindowAC>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>WindowAC object</returns>
        public virtual WindowAC DuplicateWindowAC()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdEnergyBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateWindowAC();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as WindowAC);
        }


        /// <summary>
        /// Returns true if WindowAC instances are equal
        /// </summary>
        /// <param name="input">Instance of WindowAC to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WindowAC input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Vintage, input.Vintage) && 
                    Extension.Equals(this.EquipmentType, input.EquipmentType);
        }


        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Vintage != null)
                    hashCode = hashCode * 59 + this.Vintage.GetHashCode();
                if (this.EquipmentType != null)
                    hashCode = hashCode * 59 + this.EquipmentType.GetHashCode();
                return hashCode;
            }
        }


    }
}
