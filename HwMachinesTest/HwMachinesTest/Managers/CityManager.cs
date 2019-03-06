using System;

namespace HwMachinesTest
{
    internal class CityManager
    {
        internal static City GetCity()
        {
            //todo gerekli kod = random country name
            var cities = SourceManager.LoadCities();
            Random random = new Random();
            int index = random.Next(0, 250);

            City city = cities[index];
            if (city.Status == CityStatus.Passive)
                return city;
            else
                return GetCity();
        }
    }
}