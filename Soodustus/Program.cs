using System;
using System.ComponentModel.DataAnnotations;

namespace Soodustus
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float soodustus = 0.3f;
            Console.WriteLine("Mis hind?");
            float vastus = float.Parse(Console.ReadLine());
            Console.WriteLine("alghind {0} eurot soodustusega muutub {1} euro võrra", vastus, Math.Round(vastus * soodustus));
        }

    }
}