using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        //properties
        public string Model { get; set; }
        public bool OnOff { get; set; }
        public int Heat { get; set; }
        public int Power { get; set; }
        public static int SomeProperty { get; set; }

        //constructor

        //method to give more power

        public void Powerup(int value)
        {
            Heat += value;
        }
        public void Powerdown(int value)
        {
            Heat -= value;
        }

        //method to display car propertiess
        public void PrintData()
        {
            Console.WriteLine("Heater data:");
            Console.WriteLine("- model:" + Model);
            Console.WriteLine("- Heat:" + Heat);
            Console.WriteLine("- ON " + OnOff);

        }
        //destructor
        ~Heater()
        {
            Console.WriteLine("Heater Object destroyed!");
        }

    }
}
