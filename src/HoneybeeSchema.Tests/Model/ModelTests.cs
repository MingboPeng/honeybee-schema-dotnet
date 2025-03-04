/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

using HoneybeeSchema;
using System.Net;

namespace HoneybeeSchema.Test
{
    /// <summary>
    ///  Class for testing Model
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ModelTests
    {
        // TODO uncomment below to declare an instance variable for Model
        private Model instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            var url = @"https://raw.githubusercontent.com/ladybug-tools/honeybee-schema/master/samples/model/model_complete_single_zone_office.hbjson";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(url);
                this.instance = Model.FromJson(json);
            }
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Model
        /// </summary>
        [Test]
        public void ModelInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOf" Model
            Assert.IsInstanceOf(typeof(Model), instance);
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            Assert.AreEqual(this.instance.Identifier, "Tiny_House");
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            Assert.AreEqual(this.instance.DisplayName, "Tiny_House");
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Rooms'
        /// </summary>
        [Test]
        public void RoomsTest()
        {
            Assert.AreEqual(this.instance.Rooms.Count, 1);
        }
        /// <summary>
        /// Test the property 'OrphanedFaces'
        /// </summary>
        [Test]
        public void OrphanedFacesTest()
        {
            Assert.AreEqual(this.instance.OrphanedShades.Count, 1);
            Assert.AreEqual(this.instance.OrphanedShades[0].Identifier, "Tree_Canopy");
        }
        /// <summary>
        /// Test the property 'OrphanedShades'
        /// </summary>
        [Test]
        public void OrphanedShadesTest()
        {
            // TODO unit test for the property 'OrphanedShades'
        }
        /// <summary>
        /// Test the property 'OrphanedApertures'
        /// </summary>
        [Test]
        public void OrphanedAperturesTest()
        {
            // TODO unit test for the property 'OrphanedApertures'
        }
        /// <summary>
        /// Test the property 'OrphanedDoors'
        /// </summary>
        [Test]
        public void OrphanedDoorsTest()
        {
            // TODO unit test for the property 'OrphanedDoors'
        }
        /// <summary>
        /// Test the property 'Properties'
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            var obj = this.instance.Properties.Energy.ProgramTypes.First();
            var prop = obj.Obj as ProgramTypeAbridged; 
            Assert.AreEqual(prop.Identifier, "Generic Office Program");
            Assert.AreEqual(prop.Lighting.WattsPerArea, 10.55);
            Assert.AreEqual(prop.ElectricEquipment.LatentFraction, 0);
            Assert.AreEqual(prop.People.LatentFraction, new Autocalculate());
            Assert.AreEqual(prop.Infiltration.FlowPerExteriorArea, 0.0002266);
            Assert.AreEqual(prop.Setpoint.HeatingSchedule, "Generic Office Heating");


            var hvac = this.instance.Properties.Energy.Hvacs.First().Obj as IdealAirSystemAbridged;
            Assert.AreEqual(hvac.HeatingAirTemperature, 50);
            Assert.AreEqual(hvac.HeatingLimit, new Autosize());
        }

        [Test]
        public void PropertySerializationTest()
        {

            var obj = ModelProperties.Default;
            var sch = obj.Energy.Schedules.OfType<ScheduleRulesetAbridged>().First();
            var day = sch.DaySchedules.First();

            var json = obj.ToJson();
            var obj2 = ModelProperties.FromJson(json);
            var sch2 = obj2.Energy.Schedules.OfType<ScheduleRulesetAbridged>().First();
            var day2 = sch2.DaySchedules.First();

            Assert.AreEqual(day.Values.Count, day.Times.Count);
            Assert.AreEqual(day2.Values.Count, day2.Times.Count);
          
        }

        [Test]
        public void VersionTest()
        {
            var version = this.instance.Version;
            var versions = version.Split(".").Select(_ => int.Parse(_));
            Assert.IsTrue(versions.Count() == 3);
        }

        [Test]
        public void RoomWithoutFaceTest()
        {
            var room = new Room("A_mewRoom", new List<Face>(), new RoomPropertiesAbridged());
            var json = room.ToJson();

            var dup = Room.FromJson(json);
            var isSame = room.Equals(dup);
            Assert.IsTrue(isSame);
        }

        [Test]
        public void HVACSummaryTest()
        {
            var dummy = new VAV("test");

            // get class summary
            var VAV = SummaryAttribute.GetSummary(typeof(VAV));
            Assert.IsTrue(!string.IsNullOrEmpty(VAV));

            // get property summary
            var sr = SummaryAttribute.GetSummary(typeof(VAV), nameof(dummy.SensibleHeatRecovery));
            Assert.IsTrue(!string.IsNullOrEmpty(sr));

        }

        [Test]
        public void HVACScenarioTest()
        {
            var pairs = new Dictionary<string, string>();
            pairs.Add("roomID1", "hvacID1");
            pairs.Add("roomID2", "hvacID3");
            var dummy = new HVACScenario("newID", pairs, "new scenario");

            var dup = dummy.DuplicateHVACScenario();

            Assert.AreEqual(dummy, dup);

        }
    }

}
