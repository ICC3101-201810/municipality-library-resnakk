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
            while (true)
            {
                Console.WriteLine("1.- Explorar las clases: \n2.- Entrar al Prgrama:");
                if (Console.ReadLine() ==  "1")
                {
                    methods.Explorar();
                }
            }
            
        }
    }
}
