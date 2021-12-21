using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EstructuraCondicionalSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 -> 3 bebe
            // 3 -> 7 años niño
            // 7 -> 12 años preadolescente
            // 12 -> 18 años adolescente
            // 18 -> 25 años joven
            // mas de 25, adulto

            string edadIngresada = Console.ReadLine();
            int edad = Convert.ToInt32(edadIngresada);

            /*if(edad >=0 && edad <= 3)
            {
                Console.WriteLine("Es un bebe");
            }else if(edad > 3 && edad <= 7)
            {
                Console.WriteLine("Es un niño");
            }*/

            switch (edad)
            {
                /*case 0:
                    Console.WriteLine("Es un bebe");
                    break;
                case 1:
                    Console.WriteLine("Es un bebe");
                    break;
                case 2:
                    Console.WriteLine("Es un bebe");
                    break;*/
                case 0:
                case 1:
                case 2:
                    Console.WriteLine("Es un bebe");
                    break;
                default:
                    Console.WriteLine("No es ninguno de los valores anterioes");
                    break;
            }



            Console.ReadKey();
        }
    }
}
