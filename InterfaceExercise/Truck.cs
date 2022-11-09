using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool CanHaul { get; set; }   
        public bool HasBed { get; set; }    
        public int NumWheels { get  ; set  ; }
        public int NumDoors { get  ; set  ; }
        public string Color { get  ; set  ; }
        public double MaxSpeed { get  ; set  ; }
        public string Name { get  ; set  ; }
        public string Emblem { get  ; set  ; }

        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Park()
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }
    }
}
