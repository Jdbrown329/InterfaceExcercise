using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumWheels { get; set; }
       public int NumDoors { get; set; }
        public string Color { get; set; }   
        public double MaxSpeed { get; set; }

        public void Drive();
        public void Reverse();
        public void Park();


    }
}
