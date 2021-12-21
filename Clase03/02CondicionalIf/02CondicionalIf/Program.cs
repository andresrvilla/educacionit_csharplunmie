using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CondicionalIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * OPEARADORES CONDICIONALES
               VALORA OPERADOR VALORB
               == "Igualdad"
               != "Distinto"
               >  "Mayor"
               <  "Menor"
               >= "Mayor o igual"
               <= "Menor o igual"
             */

            /*
             OPERADORES LOGICOS
             CONDICIONUNO OPERADOR CONDICIONDOS
             && "y logico"
             || "o logico"
             !  "negacion"
             */

            /*
             CONDICIONAL IF
             Expresion que permite ejecutar codigo
             dependiendo si se da una condicion

             if(CONDICION){
             }

            */

            int edad = 12;
            string pais = "España";

            /*if(edad >= 21)
            {
                Console.WriteLine("Es mayor o igual a 21 años");
            }
            else
            {
                Console.WriteLine("Es menor a 21 años");
            }*/

            if(edad >= 21 && pais == "España")
            {
                Console.WriteLine("Es mayor a 21 y es de españa");
            }
            else
            {
                Console.WriteLine("O es menor a 21, o no está en españa");
            }



            Console.ReadKey();
        }
    }
}
