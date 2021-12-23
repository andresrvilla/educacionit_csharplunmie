using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese el primer valor: ");
            string valorUno = Console.ReadLine();
            Console.Write("Por favor ingrese el segundo valor: ");
            string valorDos = Console.ReadLine();
            Console.WriteLine("Por favor ingrese la operación que desea realizar");
            Console.WriteLine("Ingrese 1 para sumar");
            Console.WriteLine("Ingrese 2 para restar");
            Console.WriteLine("Ingrese 3 para multiplicar");
            Console.WriteLine("Ingrese 4 para dividir");
            Console.Write("Ingrese la opción elegida: ");
            string opcion = Console.ReadLine();

            int valorUnoEntero = Convert.ToInt32(valorUno);
            int valorDosEntero = Convert.ToInt32(valorDos);
            int resultado = 0;
            bool operacionCorrecta = true;
            switch (opcion)
            {
                case "1":
                    resultado = valorUnoEntero + valorDosEntero;
                    break;
                case "2":
                    resultado = valorUnoEntero - valorDosEntero;
                    break;
                case "3":
                    resultado = valorUnoEntero * valorDosEntero;
                    break;
                case "4":
                    resultado = valorUnoEntero / valorDosEntero;
                    break;
                default:
                    operacionCorrecta = false;
                    break;
            }

            if (operacionCorrecta == true)
            {
                Console.WriteLine("El resultado de la operación es {0}", resultado);
            }
            else
            {
                Console.WriteLine("La operacion ingresada es incorrecta");
            }
            

            Console.ReadKey();
        }
    }
}
