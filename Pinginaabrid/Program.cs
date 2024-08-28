using System;

namespace Pinginaabrid
{
    internal class Program
    {
        static public void Main(string[] args)
        {
            string nimi1, nimi2;

            Console.WriteLine("Tere! Mis on teie nimi?");
            nimi1 = Console.ReadLine();

            Console.WriteLine("Aga teine mees?");
            nimi2 = Console.ReadLine();

            Console.WriteLine("Suurepärane! {0} ja {1}, te olete naabrid!", nimi1, nimi2);
        }
    }
}