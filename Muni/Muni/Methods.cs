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
                
                Console.WriteLine("1.- Add Person:\n2.- Add Adress:\n3.- Add Car:");
                string var = Console.ReadLine();
                if (var == "1")
                {
                    persons.Add(AddPerson(persons, address));
                }
                else if (var == "2")
                {
                    address.Add(AddAddress(address));
                }
                else if (var == "3")
                {
                    cars.Add(AddCar(cars, persons, address));
                }
            }
        }
        public Address AddAddress(List<Address>adds)
        {
            
                Console.WriteLine("Street:");
                string street = Console.ReadLine();
                int num;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("number");
                    string input = Console.ReadLine();
                    
                    if (Int32.TryParse(input, out num)) { break; }
                    else
                    {
                        Console.WriteLine("not a number");
                    }

                }
                Console.Clear();
                Console.WriteLine("Commune:");
                string commune = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("City:");
                string city = Console.ReadLine();
                Console.Clear();

                int num1;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Year of Cosntruction:");
                    string input = Console.ReadLine();
                    
                    if (Int32.TryParse(input, out num1)) { break; }
                    else
                    {
                        Console.WriteLine("not a number");
                    }

                }
                int num2;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number of bedrooms:");
                    string input = Console.ReadLine();
                    
                    if (Int32.TryParse(input, out num2)) { break; }
                    else
                    {
                        Console.WriteLine("not a number");
                    }

                }
                int num3;
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Number of bathroomsn:");
                    string input = Console.ReadLine();
                    
                    if (Int32.TryParse(input, out num3)) { break; }
                    else
                    {
                        Console.WriteLine("not a number");
                    }

                }
                bool backyard;
                while (true)
                {
                    Console.WriteLine("1.-With pool \n2.-Without");
                    var var = Console.ReadLine();
                    if (var == "1")
                    {
                        backyard = true;
                        break;
                    }
                    else if (var == "2")
                    {
                        backyard = false;
                        break;
                    }
                }
                bool pool;
                while (true)
                {
                    Console.WriteLine("1.-With pool \n2.-Without");
                    var var = Console.ReadLine();
                    if (var == "1")
                    {
                        pool = true;
                        break;
                    }
                    else if (var == "2")
                    {
                        pool = false;
                        break;
                    }
                }


                Address ad = new Address(street, num, commune, city, null, num1, num2, num3, backyard, pool);
                adds.Add(ad);
                return ad;
                
            
        }
        public Person AddPerson(List<Person> persons, List<Address> address)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            DateTime date;
            while (true)
            {
                Console.WriteLine("Birth Date:yy-mm-dd");

                if (DateTime.TryParse(Console.ReadLine(), out date))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                }

            }
            Console.WriteLine("Professional Degree: ");
            string pDegree = Console.ReadLine();
            Console.WriteLine("Rut:");
            string rut = Console.ReadLine();
            Address addd;
            while (true)
            {
                Console.WriteLine("Do you want to asign an address to this person?\n1.-Yes \n2.-No ");
                var va = Console.ReadLine();
                if (va == "1")
                {
                    addd = AddAddress(address);
                    break;
                }
                else if (va == "2")
                {
                    addd = null;
                }

            }
            Person parent1;
            Person parent2;
            while (true)
            {
                Console.WriteLine("Do you want to asign parents to this person?\n1.-Yes \n2.-No ");
                var va = Console.ReadLine();
                if (va == "1")
                {
                    parent1 = AddParent(persons, address);
                    parent2 = AddParent(persons, address);
                    break;
                }
                else if (va == "2")
                {
                    parent1 = null;
                    parent2 = null;
                }

            }
        
            Person person = new Person(name, lastName, date, addd, rut, parent1, parent2);
            return person; 
           
        }
        public Person AddParent(List<Person> persons, List<Address> address)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            DateTime date;
            while (true)
            {
                Console.WriteLine("Birth Date:yy-mm-dd");

                if (DateTime.TryParse(Console.ReadLine(), out date))
                {

                    break;
                }
                else
                {
                    Console.WriteLine("You have entered an incorrect value.");
                }

            }

            Console.WriteLine("Professional Degree: ");
            string pDegree = Console.ReadLine();
            Console.WriteLine("Rut:");
            string rut = Console.ReadLine();
            Address addd;
            while (true)
            {
                Console.WriteLine("Do you eant to asign an address to this person?\n1.-Yes \n2.-No ");
                var va = Console.ReadLine();
                if (va == "1")
                {
                    addd = AddAddress(address);
                    break;
                }
                else if (va == "2")
                {
                    addd = null;
                }
            }
            Person Parent = new Person(name, lastName, date, addd,rut, null,null);
            return Parent;
            //PUSE LOS PARENTS COMO NULL, YA WUE SINO SERIA UN CICLO SIN FIN.   
        }
        public Car AddCar(List<Car> cars, List<Person>persons,List<Address>address)
        {
            
            Console.WriteLine("Brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("Model:");
            string model = Console.ReadLine();
            int year;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Year: (yymmdd)");
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out year)) { break; }
                else
                {
                    Console.WriteLine("not a number");
                }

            }
            Person owner;
            while (true)
            {
                Console.WriteLine("Do you want to asign a owner to this car?\n1.-Yes \n2.-No ");
                var va = Console.ReadLine();
                if (va == "1")
                {
                    owner= AddPerson(persons, address);
                   
                    break;
                }
                else if (va == "2")
                {
                    owner = null;
                   
                }

            }
            Console.WriteLine("Licence plate:");
            string licence = Console.ReadLine();
            int seatbelts;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Number of seatbelts:");
                string input = Console.ReadLine();

                if (Int32.TryParse(input, out seatbelts)) { break; }
                else
                {
                    Console.WriteLine("not a number");
                }

            }
            bool diesel;
            while (true)
            {
                Console.WriteLine("1.-With diesel \n2.-Without");
                var var = Console.ReadLine();
                if (var == "1")
                {
                    diesel = true;
                    break;
                }
                else if (var == "2")
                {
                    diesel = false;
                    break;
                }
            }
            Car car = new Car(brand,model,year,owner,licence,seatbelts,diesel);
            return car;



        }

    }
    
}
