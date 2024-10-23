using System;

namespace Lecture4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 6. Parašykite programą, kuri leidžia vartotojui įvesti bet kokį skaičių nuo 1 iki 7...
            Console.WriteLine("Iveskite skaiciu nuo 1 iki 7:");
            int skaicius = int.Parse(Console.ReadLine());

            string diena = "";

            while(skaicius < 1 || skaicius > 7)
            {
                Console.WriteLine("Netinkamas skaicius, bandykite dar karta");
                skaicius = int.Parse(Console.ReadLine());
            }

            switch (skaicius)
            {
                case 1:
                    diena = "Pirmadienis";
                    break;
                case 2:
                    diena = "Antradienis";
                    break;
                case 3:
                    diena = "Treciadienis";
                    break;
                case 4:
                    diena = "Ketvirtadienis";
                    break;
                case 5:
                    diena = "Penktadienis";
                    break;
                case 6:
                    diena = "Sestadienis";
                    break;
                case 7:
                    diena = "Sekmadienis";
                    break;
            }
            Console.WriteLine($"{diena}");
        }
    }
}