using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public double EngineSize { get; set; } = 6;
        public string Make { get; set; } = "Cadillac";
        public string Model { get; set; } = "Escalade";
        public int SeatCount { get; set; } = 7;
        public string Motto { get; set; } = "Standard of the World";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void ChangeGears(bool isChanged) => HasChangedGears = isChanged;

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until change gears");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }
    }

}
