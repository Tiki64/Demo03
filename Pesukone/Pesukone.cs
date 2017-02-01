using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApplication
{
    class Pesukone
    {
        //properties
        public string Model { get; set; }
        public int Temperature { get; set; }
        public bool On { get; set; }
        public float AmountOfLaundry { get; set; }

        //constructors
        public Pesukone(int _temp)
        {
            Temperature = _temp;
        }
        public Pesukone(float laundry)
        {
            AmountOfLaundry = laundry;
        }
        //methods
        public void PrintData()
        {
            Console.WriteLine("Pesukoneen tiedot:");
            Console.WriteLine("- Model: " + Model);
            Console.WriteLine("- Temperature: " + Temperature);
            Console.WriteLine("- Laundy amount: " + AmountOfLaundry);
            Console.WriteLine("- ON " + On);
            Console.WriteLine(">");
        }
        //destructor
        ~Pesukone()
        {
            Console.WriteLine("Pesukone Object destroyed!");
        }

    }
}
