using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Tyres { get; set; }
        public int Speed { get; set; }

        public Vehicle(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }

        public void Tiedot()
        {
            foreach (var prop in this.GetType().GetProperties())
            {
                Console.WriteLine("{0}={1}", prop.Name, prop.GetValue(this, null));
            }
        }
    
    }
}
