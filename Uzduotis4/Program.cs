using System;
using System.Diagnostics.CodeAnalysis;

namespace Lecture4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 4. Parašykite programą, kuri leidžia vartotojui įvesti kelis skaičius tol, kol bendra suma viršija 100
            Console.WriteLine("Iveskite skaiciu pridejimui:");
            int skaicius = int.Parse(Console.ReadLine());

            int suma = 0;

            while (suma <=100)
            {
                suma = suma + skaicius;
                if (suma > 100)
                {
                    break;
                }
                Console.WriteLine($"Suma: {suma}. Teskite ivedima.");
                Console.WriteLine();

                skaicius = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Suma: {suma}.Suma virsyta.");

        }
    }
}