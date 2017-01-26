using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class CarApplication
    {
        static void Main(string[] args)
        {
            //create one instance of car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            car.PrintData();
        }
    }
}
