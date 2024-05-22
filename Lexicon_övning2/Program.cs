using System;
using System.Linq.Expressions;

namespace Lexicon_övning2
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            string input;
            bool run = true;

            do
            {
                Console.WriteLine("Du har kommit till huvudmenyn. Du kan navigera genom att skriva in siffror" +
                "för att testa olika funktioner. Menyval 0 - Avsluta programmet , Menyval 1 - Ungdom eller pensionär? , " +
                "Menyval 2 - Sällskap , Menyval 3 - ");
                input = Console.ReadLine()!;

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Programmet stängs ner...");
                        run = false;
                        break;
                    case "1":
                        Console.WriteLine("Ungdom eller pensionär? Din ålder: ");

                        
                        string inputAge = Console.ReadLine()!;

                        if (int.TryParse(inputAge, out int age))
                        {
                            Console.WriteLine("Din ålder: " + age);

                            checkAge(age);
                        }
                        else
                        {
                            Console.WriteLine("Ogiltigt nummer.");
                        }

                        break;
                    case "2":
                        Console.WriteLine("");
                       
                        break;
                    case "3":
                        Console.WriteLine("");
                        
                        break;
                    default:
                        Console.WriteLine("Felaktigt input, försök igen.");
                        
                        break;
                }

            } while (run);


        }

        private static void checkAge(int age)
        {
            if (age < 0)
            //throw new NotImplementedException();
        }
    }
}
