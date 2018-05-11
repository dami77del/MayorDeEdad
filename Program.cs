using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeEdad
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad;



           Console.WriteLine("permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.");

            Console.Write("¿Que edad tenes? ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
                Console.Write("Tenes " + edad + " años y eres mayor de edad.");
            else
                Console.Write("Tenes " + edad + " años y NO eres mayor de edad.");

            Console.ReadKey();

        }
    }

}