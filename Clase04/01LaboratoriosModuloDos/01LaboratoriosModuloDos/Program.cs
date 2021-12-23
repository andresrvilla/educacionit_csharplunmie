using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LaboratoriosModuloDos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorAcomparar = "200";
            //quiero ver si el valor es igual al texto "200"
            if (valorAcomparar == "200")
            {
                Console.WriteLine("El valor a comparar es igual a 200");
            }
            else
            {
                Console.WriteLine("El valor {0} no es igual a 200", valorAcomparar);
            }

            Console.WriteLine("Comparo con Equals");

            // El ejemplo anterior es equivalente a

            if (valorAcomparar.Equals("200"))
            {
                Console.WriteLine("El valor a comparar es igual a 200");
            }
            else
            {
                Console.WriteLine("El valor {0} no es igual a 200", valorAcomparar);
            }

            // Conversion de tipos

            int valorEntero = Convert.ToInt32(valorAcomparar); // aca voy a tener el numero 200

            // equivalente a usar el TIPODEDATO.Parse(v);

            int valorEnteroOpcionDos = Int32.Parse(valorAcomparar);

            Console.WriteLine("Con convert {0} con parse {1}", valorEntero, valorEnteroOpcionDos);

            Console.ReadKey();
        }
    }
}
