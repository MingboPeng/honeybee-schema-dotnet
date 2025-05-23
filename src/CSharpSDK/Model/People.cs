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
    /// Base class for all objects requiring an EnergyPlus identifier and user_data.
    /// </summary>
    [Summary(@"Base class for all objects requiring an EnergyPlus identifier and user_data.")]
    [System.Serializable]
    [DataContract(Name = "People")]
    public partial class People : IDdEnergyBaseModel, System.IEquatable<People>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="People" /> class.
        /// </summary>
        [LBTNewtonSoft.Newtonsoft.Json.JsonConstructorAttribute]
        [System.Text.Json.Serialization.JsonConstructor]
        protected People() 
        { 
            // Set readonly properties with defaultValue
            this.Type = "People";
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="People" /> class.
        /// </summary>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be < 100 characters, use only ASCII characters and exclude (, ; ! \n \t).</param>
        /// <param name="peoplePerArea">People per floor area expressed as [people/m2]</param>
        /// <param name="occupancySchedule">A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile.</param>
        /// <param name="displayName">Display name of the object with no character restrictions.</param>
        /// <param name="userData">Optional dictionary of user data associated with the object.All keys and values of this dictionary should be of a standard data type to ensure correct serialization of the object (eg. str, float, int, list).</param>
        /// <param name="activitySchedule">A schedule for the activity of the occupants over the course of the year. The type of this schedule should be ActivityLevel and the values of the schedule equal to the number of Watts given off by an individual person in the room. If None, a default constant schedule with 120 Watts per person will be used, which is typical of awake, adult humans who are seated.</param>
        /// <param name="radiantFraction">The radiant fraction of sensible heat released by people. (Default: 0.3).</param>
        /// <param name="latentFraction">Number for the latent fraction of heat gain due to people or an Autocalculate object.</param>
        public People
        (
            string identifier, double peoplePerArea, AnyOf<ScheduleRuleset, ScheduleFixedInterval> occupancySchedule, string displayName = default, object userData = default, AnyOf<ScheduleRuleset, ScheduleFixedInterval> activitySchedule = default, double radiantFraction = 0.3D, AnyOf<Autocalculate, double> latentFraction = default
        ) : base(identifier: identifier, displayName: displayName, userData: userData)
        {
            this.PeoplePerArea = peoplePerArea;
            this.OccupancySchedule = occupancySchedule ?? throw new System.ArgumentNullException("occupancySchedule is a required property for People and cannot be null");
            this.ActivitySchedule = activitySchedule;
            this.RadiantFraction = radiantFraction;
            this.LatentFraction = latentFraction ?? new Autocalculate();

            // Set readonly properties with defaultValue
            this.Type = "People";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(People))
                this.IsValid(throwException: true);
        }

	
	
        /// <summary>
        /// People per floor area expressed as [people/m2]
        /// </summary>
        [Summary(@"People per floor area expressed as [people/m2]")]
        [Required]
        [Range(0, double.MaxValue)]
        [DataMember(Name = "people_per_area", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("people_per_area")] // For System.Text.Json
        public double PeoplePerArea { get; set; }

        /// <summary>
        /// A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile.
        /// </summary>
        [Summary(@"A schedule for the occupancy over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the people_per_area to yield a complete occupancy profile.")]
        [Required]
        [DataMember(Name = "occupancy_schedule", IsRequired = true)] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("occupancy_schedule")] // For System.Text.Json
        public AnyOf<ScheduleRuleset, ScheduleFixedInterval> OccupancySchedule { get; set; }

        /// <summary>
        /// A schedule for the activity of the occupants over the course of the year. The type of this schedule should be ActivityLevel and the values of the schedule equal to the number of Watts given off by an individual person in the room. If None, a default constant schedule with 120 Watts per person will be used, which is typical of awake, adult humans who are seated.
        /// </summary>
        [Summary(@"A schedule for the activity of the occupants over the course of the year. The type of this schedule should be ActivityLevel and the values of the schedule equal to the number of Watts given off by an individual person in the room. If None, a default constant schedule with 120 Watts per person will be used, which is typical of awake, adult humans who are seated.")]
        [DataMember(Name = "activity_schedule")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("activity_schedule")] // For System.Text.Json
        public AnyOf<ScheduleRuleset, ScheduleFixedInterval> ActivitySchedule { get; set; }

        /// <summary>
        /// The radiant fraction of sensible heat released by people. (Default: 0.3).
        /// </summary>
        [Summary(@"The radiant fraction of sensible heat released by people. (Default: 0.3).")]
        [Range(0, 1)]
        [DataMember(Name = "radiant_fraction")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("radiant_fraction")] // For System.Text.Json
        public double RadiantFraction { get; set; } = 0.3D;

        /// <summary>
        /// Number for the latent fraction of heat gain due to people or an Autocalculate object.
        /// </summary>
        [Summary(@"Number for the latent fraction of heat gain due to people or an Autocalculate object.")]
        [DataMember(Name = "latent_fraction")] // For Newtonsoft.Json
        [System.Text.Json.Serialization.JsonPropertyName("latent_fraction")] // For System.Text.Json
        public AnyOf<Autocalculate, double> LatentFraction { get; set; } = new Autocalculate();


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "People";
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
            sb.Append("People:\n");
            sb.Append("  Identifier: ").Append(this.Identifier).Append("\n");
            sb.Append("  PeoplePerArea: ").Append(this.PeoplePerArea).Append("\n");
            sb.Append("  OccupancySchedule: ").Append(this.OccupancySchedule).Append("\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  DisplayName: ").Append(this.DisplayName).Append("\n");
            sb.Append("  UserData: ").Append(this.UserData).Append("\n");
            sb.Append("  ActivitySchedule: ").Append(this.ActivitySchedule).Append("\n");
            sb.Append("  RadiantFraction: ").Append(this.RadiantFraction).Append("\n");
            sb.Append("  LatentFraction: ").Append(this.LatentFraction).Append("\n");
            return sb.ToString();
        }


        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>People object</returns>
        public static People FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<People>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }




        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>People object</returns>
        public virtual People DuplicatePeople()
        {
            return FromJson(this.ToJson());
        }


        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>IDdEnergyBaseModel</returns>
        public override IDdEnergyBaseModel DuplicateIDdEnergyBaseModel()
        {
            return DuplicatePeople();
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as People);
        }


        /// <summary>
        /// Returns true if People instances are equal
        /// </summary>
        /// <param name="input">Instance of People to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(People input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.PeoplePerArea, input.PeoplePerArea) && 
                    Extension.Equals(this.OccupancySchedule, input.OccupancySchedule) && 
                    Extension.Equals(this.ActivitySchedule, input.ActivitySchedule) && 
                    Extension.Equals(this.RadiantFraction, input.RadiantFraction) && 
                    Extension.Equals(this.LatentFraction, input.LatentFraction);
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
                if (this.PeoplePerArea != null)
                    hashCode = hashCode * 59 + this.PeoplePerArea.GetHashCode();
                if (this.OccupancySchedule != null)
                    hashCode = hashCode * 59 + this.OccupancySchedule.GetHashCode();
                if (this.ActivitySchedule != null)
                    hashCode = hashCode * 59 + this.ActivitySchedule.GetHashCode();
                if (this.RadiantFraction != null)
                    hashCode = hashCode * 59 + this.RadiantFraction.GetHashCode();
                if (this.LatentFraction != null)
                    hashCode = hashCode * 59 + this.LatentFraction.GetHashCode();
                return hashCode;
            }
        }


    }
}
