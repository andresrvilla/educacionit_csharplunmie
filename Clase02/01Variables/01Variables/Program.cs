using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            nombre = "Andres";

            string apellido = "Villa";

            Console.WriteLine("Ingrese el curso al que pertenece");
            string curso = Console.ReadLine();

            Console.WriteLine("Nombre: {0}, Apellido: {1}, Curso:{2}", nombre, apellido, curso);


            int valorUno = 100;
            byte valorDos = 200;
            short valorTres = 10000;
            double valorCuatro = 5.5;

            bool verdadero = true;

            bool falso = false;


            /*
               OPERADORES ARITMETICOS
               + SUMA
               - RESTA
               * MULTIPLICACION
               / DIVISION
               % MODULO
             */

            int numeroUno = 100;
            int numeroDos = 200;
            int numeroTres = 170;

            int resultadoSumaUno = numeroUno + numeroDos;

            int resultadoResta = numeroDos - numeroUno; // 100

            int multiplica = numeroDos * numeroTres;

            int caca = numeroDos / numeroTres;

            int a = 200000000;
            int b = 200000000;
            int r = a * b;

            Console.WriteLine("El resultado de la multiplicacion es {0}", r);

            int operacionCompleja = ((numeroUno + numeroDos) / numeroTres) * 15;

            Console.WriteLine("Ingrese el valor a sumar");
            string textoIngreso = Console.ReadLine();

            int valorASumar = Convert.ToInt32(textoIngreso); // ToInt16 ToByte ToBoolean

            int resultadoModulo = 10 % 3; // Esto da como resultado 1, que es el resto de dividir 10 en 3 (Division entera)

            /*
              ++
              --
              += a+=4; equivale -> a =  a + 4
              -= a-=4; equivale -> a =  a - 4
              *=
              /=
             
             */

            int valor = 1;
            valor++; // Ahora valor vale 2, equivale a valor = valor + 1;
            valor--; // ahora valor vale 1 de nuevo, equivale a valor = valor-1;

            int valorMil = 100;

            int nuevoValorMil = valorMil++; // 100
            Console.WriteLine("NUEVO VALOR MIL:" + nuevoValorMil);
            nuevoValorMil = ++valorMil; //101
            Console.WriteLine("NUEVO VALOR MIL:" + nuevoValorMil);


            string saludo = "Hola ";
            string nombreSaludo = "Andres";

            string saludoCompleto = saludo + nombreSaludo; // "Hola Andres"

            string textoUNO = "Calle";
            string textoDOS = "123";
            string calleCompleta = textoUNO + " " + textoDOS; // "Calle123"


            Console.ReadKey();
        }
    }
}
