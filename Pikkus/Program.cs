using System;
using System.ComponentModel.DataAnnotations;

namespace Pikkus
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float pikkus;
            Gender? sugu;

            Console.WriteLine("Tere! Mis pikkus sul on?");
            pikkus = float.Parse(Console.ReadLine());

            Console.WriteLine("Kas olete mees (0) või naine (1)?");
            int vastus = int.Parse(Console.ReadLine());
            if (vastus == 0)
            {
                sugu = Gender.Male;
            }
            else if (vastus == 1)
            {
                sugu = Gender.Female;
            }
            else
            {
                sugu = null;
            }

            Height? suurus = HeightCheck(pikkus, sugu);
            if (suurus == Height.Short)
            {
                Console.WriteLine("Teil on väga lühikest kasvu!");
            }
            else if (suurus == Height.Average)
            {
                Console.WriteLine("Teil on tavaline kasv!");
            }
            else if (suurus == Height.Long)
            {
                Console.WriteLine("Teil on väga väljaulatuv kasv!");
            }
            else if (suurus == null)
            {
                Console.WriteLine("Viga! Võimalik, et olete kirjutanud mille kasvu ei ole oluline!");
            }
        }

        public static Height? HeightCheck(float pikkus, Gender? sugu)
        {
            if (sugu == Gender.Male || sugu == null)
            {
                if (pikkus != 0 && pikkus <= 165)
                {
                    return Height.Short;
                }
                else if (pikkus <= 180)
                {
                    return Height.Average;
                }
                else if (pikkus < 210)
                {
                    return Height.Long;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (pikkus != 0 && pikkus <= 150)
                {
                    return Height.Short;
                }
                else if (pikkus <= 175)
                {
                    return Height.Average;
                }
                else if (pikkus < 190)
                {
                    return Height.Long;
                }
                else
                {
                    return null;
                }
            }

        }

        public enum Height
        {
            Short,
            Average,
            Long
        }

        public enum Gender
        {
            Male,
            Female
        }

    }
}