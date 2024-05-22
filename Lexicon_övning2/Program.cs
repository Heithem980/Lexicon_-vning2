﻿using System;
using System.Linq.Expressions;

namespace Lexicon_övning2
{
    internal class Program
    {
        private static bool run = true;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            string input;
            int result;
            bool isSuccess;
            List<int> groupAges = new List<int>();

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

                        
                        input = Console.ReadLine()!;

                        isSuccess = tryParse(input, out result);

                        if (isSuccess) {
                            Console.WriteLine("Din ålder: " + result);
                            checkAge(result);
                        }

                        

                        
                        
                        break;


                    case "2":
                        Console.WriteLine("Hur många är ni?");

                        input = Console.ReadLine()!;

                        isSuccess = tryParse(input, out result);

                        int age = 0;

                        if (isSuccess)
                        {
                            for (int i = 1; i <= result; i++)
                            {
                                Console.WriteLine($"Person {i} ålder: ");
                                input = Console.ReadLine()!;

                                isSuccess = tryParse(input, out age);

                                groupAges.Add(age);

                        

                            }
                        }
                        int ageSum = 0;

                        foreach(int personAge in groupAges)
                        {

                            ageSum += personAge;
                            
                        }

                        Console.WriteLine($"{ageSum}");

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

        private static bool tryParse(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                Console.WriteLine("Felaktigt input, försök igen.");
                result = 0;
                return false;
            }

        }

        private static void checkAge(int age)
        {
            int price;

            if (age < 20)
            {
                price = 80;
                Console.WriteLine("Ungdomspris: 80 kr");
            }else if (age > 64)
            {
                price = 90;
                Console.WriteLine("Pensionärpris: 90 kr");
            }else
            {
                price = 120;
                Console.WriteLine("Standardpris: 120 kr");
            }
            
        }
    }
}
