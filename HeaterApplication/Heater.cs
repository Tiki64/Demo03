using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{ 
    class HeaterApplication
    {
        static void Main(string[] args)
        {
            //create one instance of class
            Heater Heater = new Heater();
            Heater.PrintData();
            Heater.Model = "Harvia A1";
            Heater.Heat = 0;
            Heater.OnOff = true;
            Heater.Power = 2;
            Heater.PrintData();
        }
    }
}