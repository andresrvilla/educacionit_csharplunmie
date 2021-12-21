using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EjercicioUsuarioContraseña
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // tiene que decir "el usuario inicio sesion"
            // cuando se ingresa "user" como usuario
            // y "p4ss" como contraseña

            Console.WriteLine("Por favor ingrese su usuario");
            string usuario = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su contraseña");
            string password = Console.ReadLine();

            //string usuarioCorrecto = "user";
            //string contraseñaCorrecta = "p4ss";

            if(usuario == "user" && password == "p4ss")
            {
                Console.WriteLine("Ha iniciado sesión");
            }
            else
            {
                if(usuario != "user")
                {
                    Console.WriteLine("El usuario ingresado es incorrecto");
                }else if (password != "p4ass")
                {
                    Console.WriteLine("La contraseña ingresada es incorrecta");
                }
            }

            // Si quisiera comparar con distintos usuarios:
            
            if(usuario == "user" && password=="1234")
            {

            }else if(usuario == "pepe")
            {

            }else if(usuario == "matias")
            {

            }
            else
            {

            }


            Console.ReadKey();
        }
    }
}
