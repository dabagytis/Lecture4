using System;

namespace Lecture4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 2. Parašykite programą, kuri prašo vartotojo įvesti slaptažodį tol, kol jis bus teisingas
            Console.WriteLine("Iveskite slaptazodi:");
            string password = Console.ReadLine();

            while (password != "akmuo")
            {
                Console.WriteLine("Neteisingas slaptazodis, bandykite dar karta.");
                Console.WriteLine("");
                Console.WriteLine("Iveskite slaptazodi:");
                password = Console.ReadLine();
            }

            Console.WriteLine("Prisijungimas sekmingas!");

        }
    }
}