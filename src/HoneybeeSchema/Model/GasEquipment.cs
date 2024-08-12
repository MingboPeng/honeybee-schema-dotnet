﻿/* 
 * Honeybee Schema
 *
 * Contact: info@ladybug.tools
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
    /// Base class for all objects requiring an EnergyPlus identifier and user_data.
    /// </summary>
    [Summary(@"Base class for all objects requiring an EnergyPlus identifier and user_data.")]
    [Serializable]
    [DataContract(Name = "GasEquipment")]
    public partial class GasEquipment : IDdEnergyBaseModel, IEquatable<GasEquipment>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GasEquipment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GasEquipment() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "GasEquipment";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="GasEquipment" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be < 100 characters, use only ASCII characters and exclude (, ; ! \n \t).</param>
        /// <param name="wattsPerArea">Equipment level per floor area as [W/m2].</param>
        /// <param name="schedule">The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="radiantFraction">Number for the amount of long-wave radiation heat given off by equipment. Default value is 0.</param>
        /// <param name="latentFraction">Number for the amount of latent heat given off by equipment. Default value is 0.</param>
        /// <param name="lostFraction">Number for the amount of “lost” heat being given off by equipment. The default value is 0.</param>
        public GasEquipment
        (
            string identifier, double wattsPerArea, AnyOf<ScheduleRuleset, ScheduleFixedInterval> schedule, string displayName = default, object userData = default, double radiantFraction = 0D, double latentFraction = 0D, double lostFraction = 0D
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.WattsPerArea = wattsPerArea;
            this.Schedule = schedule ?? throw new ArgumentNullException("schedule is a required property for GasEquipment and cannot be null");
            this.RadiantFraction = radiantFraction;
            this.LatentFraction = latentFraction;
            this.LostFraction = lostFraction;

            // Set readonly properties with defaultValue
            this.Type = "GasEquipment";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(GasEquipment))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// Equipment level per floor area as [W/m2].
        /// </summary>
        [Summary(@"Equipment level per floor area as [W/m2].")]
        [Required]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "watts_per_area", IsRequired = true)]
        public double WattsPerArea { get; set; }

        /// <summary>
        /// The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.
        /// </summary>
        [Summary(@"The schedule for the use of equipment over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the watts_per_area to yield a complete equipment profile.")]
        [Required]
        [DataMember(Name = "schedule", IsRequired = true)]
        public AnyOf<ScheduleRuleset, ScheduleFixedInterval> Schedule { get; set; }

        /// <summary>
        /// Number for the amount of long-wave radiation heat given off by equipment. Default value is 0.
        /// </summary>
        [Summary(@"Number for the amount of long-wave radiation heat given off by equipment. Default value is 0.")]
        [Range(0, 1)]
        [DataMember(Name = "radiant_fraction")]
        public double RadiantFraction { get; set; } = 0D;

        /// <summary>
        /// Number for the amount of latent heat given off by equipment. Default value is 0.
        /// </summary>
        [Summary(@"Number for the amount of latent heat given off by equipment. Default value is 0.")]
        [Range(0, 1)]
        [DataMember(Name = "latent_fraction")]
        public double LatentFraction { get; set; } = 0D;

        /// <summary>
        /// Number for the amount of “lost” heat being given off by equipment. The default value is 0.
        /// </summary>
        [Summary(@"Number for the amount of “lost” heat being given off by equipment. The default value is 0.")]
        [Range(0, 1)]
        [DataMember(Name = "lost_fraction")]
        public double LostFraction { get; set; } = 0D;


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GasEquipment";
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
            sb.Append("GasEquipment:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  WattsPerArea: ").Append(this.WattsPerArea).Append("\n");
            sb.Append("  Schedule: ").Append(this.Schedule).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  RadiantFraction: ").Append(this.RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(this.LatentFraction).Append("\n");
            sb.Append("  LostFraction: ").Append(this.LostFraction).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GasEquipment object</returns>
        public static GasEquipment FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GasEquipment>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GasEquipment object</returns>
        public virtual GasEquipment DuplicateGasEquipment()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdEnergyBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicateGasEquipment();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GasEquipment);
        }


        /// <summary>
        /// Returns true if GasEquipment instances are equal
        /// </summary>
        /// <param name="input">Instance of GasEquipment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GasEquipment input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.WattsPerArea, input.WattsPerArea) && 
                    Extension.Equals(this.Schedule, input.Schedule) && 
                    Extension.Equals(this.RadiantFraction, input.RadiantFraction) && 
                    Extension.Equals(this.LatentFraction, input.LatentFraction) && 
                    Extension.Equals(this.LostFraction, input.LostFraction);
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
                if (this.WattsPerArea != null)
                    hashCode = hashCode * 59 + this.WattsPerArea.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                if (this.LostFraction != null)
                    hashCode = hashCode * 59 + this.LostFraction.GetHashCode();
                return hashCode;
            }
        }


    }
}
