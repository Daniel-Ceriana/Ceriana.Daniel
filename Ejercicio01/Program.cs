using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola");
            //Console.Beep();
            //Console.ReadKey();

            Console.Title = "Ejercicio nro 1";
            Console.Beep(37, 5000);
            

            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");
            Int32 edad = int.Parse(Console.ReadLine());
            

            //Console.WriteLine("Te llamas " + nombre);
            Console.WriteLine("Te llamas {0} y tenes {1} años", nombre,edad);


            Console.ReadKey(true);


        }
    }
}
