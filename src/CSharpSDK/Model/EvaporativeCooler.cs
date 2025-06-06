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
    /// Direct evaporative cooling systems (with optional heating).\n\nEach room/zone will receive its own air loop sized to meet the sensible load,\nwhich contains an evaporative cooler that directly adds humidity to the room\nair to cool it. The loop contains an outdoor air mixer, which is used whenever\nthe outdoor air has a lower wet bulb temperature than the return air from\nthe room. In the event that the combination of outdoor and room return air\nair is too humid, a backup single-speed direct expansion (DX) cooling coil\nwill be used. Heating loads can be met with various options, including\nseveral types of baseboards, a furnace, or gas unit heaters.
    /// </summary>
    [Summary(@"Direct evaporative cooling systems (with optional heating).\n\nEach room/zone will receive its own air loop sized to meet the sensible load,\nwhich contains an evaporative cooler that directly adds humidity to the room\nair to cool it. The loop contains an outdoor air mixer, which is used whenever\nthe outdoor air has a lower wet bulb temperature than the return air from\nthe room. In the event that the combination of outdoor and room return air\nair is too humid, a backup single-speed direct expansion (DX) cooling coil\nwill be used. Heating loads can be met with various options, including\nseveral types of baseboards, a furnace, or gas unit heaters.")]
    [System.Serializable]
    [DataContract(Name = "EvaporativeCooler")]
    public partial class EvaporativeCooler : IDdEnergyBaseModel, System.IEquatable<EvaporativeCooler>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaporativeCooler" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected EvaporativeCooler() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "EvaporativeCooler";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaporativeCooler" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be < 100 characters, use only ASCII characters and exclude (, ; ! \n \t).</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="vintage">Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards</param>
        /// <param name="equipmentType">Text for the specific type of system equipment from the EvaporativeCoolerEquipmentType enumeration.</param>
        public EvaporativeCooler
        (
            string identifier, string displayName = default, object userData = default, Vintages vintage = Vintages.ASHRAE_2019, EvaporativeCoolerEquipmentType equipmentType = EvaporativeCoolerEquipmentType.EvapCoolers_ElectricBaseboard
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.Vintage = vintage;
            this.EquipmentType = equipmentType;

            // Set readonly properties with defaultValue
            this.Type = "EvaporativeCooler";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(EvaporativeCooler))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards
        /// </summary>
        [Summary(@"Text for the vintage of the template system. This will be used to set efficiencies for various pieces of equipment within the system. Further information about these defaults can be found in the version of ASHRAE 90.1 corresponding to the selected vintage. Read-only versions of the standard can be found at: https://www.ashrae.org/technical-resources/standards-and-guidelines/read-only-versions-of-ashrae-standards")]
        [DataMember(Name = "vintage")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("vintage")] // For System.Text.Json
        public Vintages Vintage { get; set; } = Vintages.ASHRAE_2019;

        /// <summary>
        /// Text for the specific type of system equipment from the EvaporativeCoolerEquipmentType enumeration.
        /// </summary>
        [Summary(@"Text for the specific type of system equipment from the EvaporativeCoolerEquipmentType enumeration.")]
        [DataMember(Name = "equipment_type")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("equipment_type")] // For System.Text.Json
        public EvaporativeCoolerEquipmentType EquipmentType { get; set; } = EvaporativeCoolerEquipmentType.EvapCoolers_ElectricBaseboard;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "EvaporativeCooler";
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
            sb.Append("EvaporativeCooler:\n");
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
        /// <returns>EvaporativeCooler object</returns>
        public static EvaporativeCooler FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<EvaporativeCooler>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>EvaporativeCooler object</returns>
        public virtual EvaporativeCooler DuplicateEvaporativeCooler()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdEnergyBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateEvaporativeCooler();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as EvaporativeCooler);
        }


        /// <summary>
        /// Returns true if EvaporativeCooler instances are equal
        /// </summary>
        /// <param name="input">Instance of EvaporativeCooler to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaporativeCooler input)
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
