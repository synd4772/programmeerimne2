using System;
using System.ComponentModel.DataAnnotations;

namespace Leib
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float sum = 0;
            string vastus;

            Dictionary<string, float> tooted = new Dictionary<string, float> {
                { "piim", 2.45f },
                { "leib", 1.23f },
                { "sai", 1.42f }
            };
            foreach (var toode in tooted)
            {
                Console.WriteLine("Kas te soovite {0}? ( jah / ei )", toode.Key);
                vastus = Console.ReadLine();
                if (vastus.ToLower() == "jah")
                {
                    sum += toode.Value;
                }
            }
            Console.WriteLine("Kõige selle hind, mida soovisite on {0} eurot!", sum);
        }
    }
}