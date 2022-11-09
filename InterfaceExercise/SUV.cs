using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public class SUV : IVehicle, ICompany
    {
        public int CabHeight { get; set; }
        public int NumWDrwive { get; set; } 
        public int NumWheels { get    ; set    ; }
        public int NumDoors { get    ; set    ; }
        public string Color { get    ; set    ; }
        public double MaxSpeed { get    ; set    ; }
        public string Name { get    ; set    ; }
        public string Emblem { get    ; set    ; }

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
