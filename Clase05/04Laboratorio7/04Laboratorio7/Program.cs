using System;

namespace _04Laboratorio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("@");
                }
                else
                {
                    Console.WriteLine("@@");
                }
            }
            Console.ReadKey();
        }
    }
}
