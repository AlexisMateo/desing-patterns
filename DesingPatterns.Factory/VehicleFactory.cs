using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesingPatterns.Factory
{
    public class VehicleFactory
    {
        private Dictionary<String, Type> vehicles;

        public VehicleFactory()
        {
            LoadTypesICanRun();
        }

        private void LoadTypesICanRun()
        {
            vehicles = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = typeof(VehicleFactory).GetTypeInfo().Assembly.GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterfaces() != null)
                {
                    vehicles.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IVehicle CreateInstance(string vehicleName)
        {
            Type vehicleType = GetTypeToCreate(vehicleName);

            if(vehicleType == null)
            {
                return new NullVehicle();
            }

            return Activator.CreateInstance(vehicleType) as IVehicle;
        }

        private Type GetTypeToCreate(string vehicleName)
        {
            foreach(var vehicle in vehicles)
            {
                if (vehicle.Key.Contains(vehicleName))
                {
                    return vehicles[vehicle.Key];
                }
            }

            return null;
        }

        
    }
}
