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
        public string Motor { get; set; }
        public string SteeringWheel { get; set; }
        public string GearBox { get; set; }
        public string Body { get; set; }
        public string TypeDrive { get; set; }

        public Car(string brand, string model, int yearRelease, int kmAge, string motor, string gearBox, string body, string steeringWheel, string drive)
        {
            Brand = brand;
            Model = model;
            YearRelease = yearRelease;
            KmAge = kmAge;
            Motor = motor;
            GearBox = gearBox;
            Body = body;
            SteeringWheel = steeringWheel;
            TypeDrive = drive;
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
    
