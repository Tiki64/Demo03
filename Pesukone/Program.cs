﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of class
            Console.WriteLine("Anna lämpötila ");
            int lampotila = int.Parse(Console.ReadLine());
            Pesukone pesukone = new Pesukone(lampotila);
            pesukone.Model = "Pesukone A1";
            pesukone.On = true;
            pesukone.PrintData();

            Console.Read();
        }
    }
}