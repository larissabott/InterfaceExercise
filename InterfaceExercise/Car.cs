using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double EngineSize { get; set; } = 3.7;
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "Model X";
        public int SeatCount { get; set; } = 5;
        public string CompanyName { get; set; } = "Tesla Inc.";
        public string Motto { get; set; } = "Sustainable Energy";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }

        public void Reverse()
        {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

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

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
    }
}
