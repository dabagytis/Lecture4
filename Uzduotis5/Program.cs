using System;

namespace Lecture4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 5. Parašykite programą, kuri prašo vartotojo įvesti vardą ir...
            Console.WriteLine("Iveskite varda:");
            string vardas = Console.ReadLine();

            while (vardas.Length <= 3)
            {
                Console.WriteLine("Vardas per trumpas, bandykite dar karta.");
                vardas = Console.ReadLine();
                Console.WriteLine();

                if(vardas.Length > 3)
                {
                    break;
                }
            }

            Console.WriteLine("Aciu uz informacija.");

        }
    }
}