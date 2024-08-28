using System;
using System.ComponentModel.DataAnnotations;

namespace Temperatuur
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float temperatuur;
            Console.WriteLine("Milline on praegu õues temperatuur?");
            temperatuur = float.Parse(Console.ReadLine());

            if (temperatuur > 18)
            {
                Console.WriteLine("See temperatuur on talvel hea!");
            }
            else
            {
                Console.WriteLine("See temperatuur on talvel halb!");
            }
        }
    }
}