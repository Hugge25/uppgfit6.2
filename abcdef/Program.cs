using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett andra tal");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"Det största talet är {Störst(tal1, tal2)}");

        }

        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }

            else if (tal2 > tal1)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }
    }
}