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
                "för att testa olika funktioner.    ");
                input = Console.ReadLine()!;

                switch (input)
                {
                    case "0":
                        Console.WriteLine("Programmet stängs ner...");
                        run = false;
                        break;
                    case "1":
                        Console.WriteLine("");
                        run = false;
                        break;
                    case "2":
                        Console.WriteLine("");
                        run = false;
                        break;
                    case "3":
                        Console.WriteLine("");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Felaktigt input, försök igen.");
                        
                        break;
                }

            } while (run);


        }
    }
}
