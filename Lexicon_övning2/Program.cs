using System;
using System.Linq.Expressions;

namespace Lexicon_övning2
{
    internal class Program
    {
        private static bool run = true;
        private static int totalGroupPrice;
        private static int price;

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
                "för att testa olika funktioner. Menyval 0 - Avsluta programmet , Menyval 1 - (Bio) Ungdom eller pensionär? , " +
                "Menyval 2 - (Bio) Sällskap , Menyval 3 - Upprepa tio gånger, Menyval 4 - ");

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

                                if (isSuccess) { groupAges.Add(age); }
                                

                            }
                        }
                        

                        foreach(int personAge in groupAges)
                        {

                            calculateTotalCost(personAge);
                            
                        }

                        Console.WriteLine($"Antal personer: {result}.    Totalkostnad för hela sällskapet: {totalGroupPrice} kr.");
                        totalGroupPrice = 0;
                        groupAges.Clear(); 
                       
                        break;

                    case "3":

                        Console.WriteLine("Ange din text:  ");
                        input = Console.ReadLine()!;

                        string textCollection = null;

                        for (int i = 1; i <= 10; i++)
                        {
                            textCollection += i+ "." + input+", ";
                            
                        }
                        Console.WriteLine(textCollection);
                        
                        break;
                    case "4":



                        break;
                    default:
                        Console.WriteLine("Felaktigt input, försök igen.");
                        
                        break;
                }

            } while (run);


        }

        private static void calculateTotalCost(int age)
        {
            price = 0;

            if (age < 20)
            {
                price = 80;
                totalGroupPrice += price;
            }
            else if (age > 64)
            {
                price = 90;
                totalGroupPrice += price;
            }
            else
            {
                price = 120;
                totalGroupPrice += price;
            }
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
            

            if (age < 20)
            {       
                
                Console.WriteLine("Ungdomspris: 80 kr");
            }else if (age > 64)
            {
                
                Console.WriteLine("Pensionärpris: 90 kr");
            }else
            {
                
                Console.WriteLine("Standardpris: 120 kr");
            }
            
        }
    }
}
