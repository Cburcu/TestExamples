using System;

namespace HwMachinesTest
{
    internal class ContainerManeger
    {
        internal static ServerContainer Prepare(City city)
        {
            var cntr = new ServerContainer();
            cntr.CityName = city.Name;
            cntr.IsLoaded = false;
            return cntr;
        }

        internal static void ChangeContainerIsLoaded(ServerContainer serverContainer)
        {
            serverContainer.IsLoaded = true;
        }
    }
}