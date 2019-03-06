using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HwMachinesTest
{
    [TestClass]
    public class ContainerManagerUnitTest
    {
        [TestMethod]
        public void Read_Cities_From_Text_File_To_Generic_List()
        {
            List<City> cities = SourceManager.LoadCities();
            Assert.AreNotEqual(0, cities.Count);
        }

        [TestMethod]
        public void Get_Random_City_From_Generic_List()
        {
            City city = CityManager.GetCity();
            Assert.AreNotEqual(String.Empty, city.Name);
        }

        [TestMethod]
        public void Control_City_Status()
        {
            City city = CityManager.GetCity();
            Assert.AreNotEqual(1, city.Status);
        }

        [TestMethod]
        public void Prepare_Container_For_Random_City()
        {
            var city = CityManager.GetCity();
            ServerContainer container = ContainerManeger.Prepare(city);
            Assert.AreEqual(false, container.IsLoaded);
        }

        [TestMethod]
        public void Add_City_Name_To_Container()
        {
            City city = CityManager.GetCity();
            ServerContainer container = ContainerManeger.Prepare(city);
            Assert.AreEqual(city.Name, container.CityName);
        }

        [TestMethod]
        public void Change_City_Status()
        {
            City city = CityManager.GetCity();
            city.StatusControlEvent += City_StatusControlEvent;
            Assert.AreEqual(CityStatus.Passive, city.Status);
            city.Status = CityStatus.Active;
            Assert.AreEqual(CityStatus.Active, city.Status);
        }

        [TestMethod]
        public void Change_Container_IsLoaded()
        {
            City city = CityManager.GetCity();
            ServerContainer container = ContainerManeger.Prepare(city);
            Assert.AreEqual(false, container.IsLoaded);
            ContainerManeger.ChangeContainerIsLoaded(container);
            Assert.AreEqual(true, container.IsLoaded);
        }
        private static void City_StatusControlEvent(object ob, StatusEventArgs args)
        {
            Console.WriteLine("Status = {0}", args.NewStatus);

        }
    }
}
