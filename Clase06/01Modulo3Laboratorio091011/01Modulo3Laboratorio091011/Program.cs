using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Modulo3Laboratorio091011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for( int a = 5; a>=1; a--)
            {
                for(int x = 1; x < a; x++)
                {
                    Console.Write("@");
                }
                Console.WriteLine("@");
            }
            Console.ReadKey();
        }
    }
}
