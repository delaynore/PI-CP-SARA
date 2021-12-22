using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    class Car
    {

        public string Brand { get; private set; }
        public string Model { get; private set; }
        public int YearRelease { get; set; }
        public int KmAge { get; set; }
        public string Engine { get; set; }
        public string SteeringWheel { get; set; }
        public string GearBox { get; set; }
        public string Type { get; set; }

        public Car(string brand, string model, int yearRelease, int kmAge, string engine, string gearBox, string type, string steeringWheel)
        {
            Brand = brand;
            Model = model;
            KmAge = kmAge;
            Engine = engine;
            GearBox = gearBox;
            Type = type;
            SteeringWheel = steeringWheel;
        }
    }
    enum CarType
    {
        SUV,
        Cabriolet,
        Coupe,
        Sedan,
        Wagon,
        Hatchback
    }

    enum EngineType
    {
        Petrol,
        Diesel
    }
    enum SteeringWheelType
    {
        Left,
        Right
    }
    enum DriveType
    {
        Front,
        Rear,
        FourWheel
    }
    enum GearBoxType
    {
        Manual,
        Automatic,
        Robot
    }
}
    
