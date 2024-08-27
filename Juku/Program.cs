using System;
using System.ComponentModel.DataAnnotations;

namespace Juku
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere! Mis nimi sul on?");
            string eesnimi = Console.ReadLine();
            if (eesnimi != "Juku")
            {
                Console.WriteLine("Vabandust, aga sa pole Juku!");
            }
            Console.WriteLine("Tere, {0}!", eesnimi);
            Console.WriteLine("{0}, kui vana sa oled?", eesnimi);
            int vastus = int.Parse(Console.ReadLine());
            string pilet = AgeCheck(vastus);
            Console.WriteLine(pilet);

        }

        public static string AgeCheck(int age)
        {
            if (age < 6 && age != 0)
            {
                return "tasuta";
            }
            else if (age <= 14)
            {
                return "lastepilet";
            }
            else if (age <= 65)
            {
                return "täispilet";
            }
            else if (age <= 100)
            {
                return "sooduspilet";
            }
            else
            {
                return "viga";
            }
        }
    }
}