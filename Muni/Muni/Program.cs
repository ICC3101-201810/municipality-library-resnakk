using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using ClassLibrary1;

namespace Muni
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods methods = new Methods();
            List < Person > persons= new List<Person>();
            List < Address > address = new List<Address>();
            List<Car> cars = new List<Car>();
            while (true)
            {
                Console.WriteLine("1.- Explore Classes: \n2.- Go to Program:\n3.- Exit");
                string var = Console.ReadLine();
                if (var ==  "1")
                {
                    methods.Explorar();
                }
                else if (var == "2")
                {
                    methods.Programa(persons,address,cars);
                }
                else if (var == "3")
                {
                    break;
                }
            }
            
        }
    }
}
