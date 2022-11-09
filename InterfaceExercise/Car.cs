using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool FuelEfficient { get; set; } 
        public bool IsAuto { get; set; }    
        public int NumWheels{ get; set; }
        public int NumDoors { get  ; set  ; }
        public string Color { get  ; set ; }
        public double MaxSpeed { get ; set ; }
        public string Name { get  ; set; }
        public string Emblem { get  ; set ; }
        

        void IVehicle.Drive()
        {
            Console.WriteLine("The Car is driving"); 
        }

        void IVehicle.Park()
        {
            Console.WriteLine ("The Car is now Parked");
        }

        void IVehicle.Reverse()
        {
            Console.WriteLine("The Car is now going in Reverse");
        }
    }
}
