using System;

namespace Lecture4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1. Parašykite programą, kuri leidžia vartotojui įvesti skaičius tol, kol bus įvestas neigiamas skaičius
            Console.WriteLine("Iveskite teigiama skaiciu:");
            int a = int.Parse(Console.ReadLine());

            while (a >= 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"Skaicius {a} yra lyginis");
                    Console.WriteLine("");
                    Console.WriteLine("Iveskite teigiama skaiciu:");
                    a = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Skaicius {a} yra nelyginis");
                    Console.WriteLine("");
                    Console.WriteLine("Iveskite teigiama skaiciu:");
                    a = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}