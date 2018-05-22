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
    class Methods
    {
        public void Explorar()
        {
            //Explorando Person
            Console.WriteLine("Metodos de Person");
            Type personType = typeof(Person);
            foreach (var item in personType.GetMethods())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Atributos de Person");
            foreach (var item in personType.GetProperties())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //Explorando Adress
            Console.Clear();
            Console.WriteLine("Metodos de Adress");
            Type adressType = typeof(Address);
            foreach (var item in adressType.GetMethods())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Atributos de Adress");
            foreach (var item in adressType.GetProperties())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //Explorando Car
            Console.Clear();
            Console.WriteLine("Metodos de Car");
            Type carType = typeof(Car);
            foreach (var item in carType.GetMethods())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Atributos de Car");
            foreach (var item in carType.GetProperties())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public void Programa(List<Person> persons, List<Address> address, List<Car> cars)
        {
            while (true)
            {
                Console.WriteLine("1.- Añadir Persona:\n2.- Añadir Adress:\n3.- Añadir Car:");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine();
                }
                else if (Console.ReadLine() == "2")
                {

                }
                else if (Console.ReadLine() == "3")
                {

                }
            }
        }
    }
}
