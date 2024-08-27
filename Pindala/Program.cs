using System;

namespace Pindala
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float seina1, seina2;
            
            Console.WriteLine("Milline on esimese seina pikkus?");
            seina1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Aga teine sein?");
            seina2 = float.Parse(Console.ReadLine());

            float pindala = PindalaArvutamine(seina1, seina2);
            Console.WriteLine("Teie põranda pindala on {0}", pindala);

            Console.WriteLine("Kas te soovite remonti? (jah / ei )");
            string vastus = Console.ReadLine();
            
            if (vastus.ToLower() == "jah")
            {
                float hind;
                Console.WriteLine("Kui palju ruutmeeter maksab?");
                hind = float.Parse(Console.ReadLine());
                Console.WriteLine("Remonti maksab {0} eurot.", hind * pindala);
            }

        }
        public static float PindalaArvutamine(float a, float b)
        {
            return a * b;
        }
    }
}