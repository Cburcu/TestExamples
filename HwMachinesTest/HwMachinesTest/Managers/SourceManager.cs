using System;
using System.Collections.Generic;
using System.IO;

namespace HwMachinesTest
{
    internal class SourceManager
    {
        internal static List<City> LoadCities()
        {
            Random random = new Random();
            List<City> cities = new List<City>();

            var path = Path.Combine(Environment.CurrentDirectory, "Countries.txt");
            var citiesLines = File.ReadAllLines(path);

            var cityStatus = Enum.GetNames(typeof(CityStatus));

            foreach (var cnt in citiesLines)
            {
                int index = random.Next(0, cityStatus.Length);
                var statu = (CityStatus)Enum.Parse(typeof(CityStatus),cityStatus[index]);
                cities.Add(new City{Name = cnt, Status = statu});
            }
            return cities;
        }
    }
}