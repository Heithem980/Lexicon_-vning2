using System;
using System.Linq.Expressions;

namespace Lexicon_övning2
{
    internal class Program
    {
        // Fält som styr programmets körning
        private static bool run = true;


        private static int totalGroupPrice;
        private static int price;

        // Huvudmetoden där programmet startar
        static void Main(string[] args)
        {
            

            string input;
            int result;
            bool isSuccess;
            List<int> groupAges = new List<int>();
            string[] words = null;

            do
            {
                // Huvudmenyn som presenterar olika alternativ
                Console.WriteLine("Du har kommit till huvudmenyn. Du kan navigera genom att skriva in siffror" +
                "för att testa olika funktioner. Menyval 0 - Avsluta programmet , Menyval 1 - (Bio) Ungdom eller pensionär? , " +
                "Menyval 2 - (Bio) Sällskap , Menyval 3 - Upprepa tio gånger, Menyval 4 - Det tredje ordet.");

                // Läs användarens inmatning
                input = Console.ReadLine()!;


                // Hantera användarens menyval
                switch (input)
                {
                    case "0":

                        // Avsluta programmet
                        Console.WriteLine("Programmet stängs ner...");
                        run = false;
                        break;


                    case "1":

                        // Hantera val för att kolla ålder
                        Console.WriteLine("Ungdom eller pensionär? Din ålder: ");


                        input = Console.ReadLine()!;

                        isSuccess = tryParse(input, out result);

                        if (isSuccess) {
                            Console.WriteLine("Din ålder: " + result);
                            checkAge(result);
                        }


                        break;


                    case "2":

                        // Hantera val för att kolla gruppens ålder och totalkostnad
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

                        // Beräkna totalkostnad för gruppen
                        foreach (int personAge in groupAges)
                        {

                            calculateTotalCost(personAge);

                        }

                        Console.WriteLine($"Antal personer: {result}.    Totalkostnad för hela sällskapet: {totalGroupPrice} kr.");
                        totalGroupPrice = 0; // Nollställ totalkostnaden
                        groupAges.Clear();   // Töm listan med åldrar

                        break;

                    case "3":

                        // Upprepa användarens text tio gånger
                        Console.WriteLine("Ange din text:  ");
                        input = Console.ReadLine()!;

                        string textCollection = null;

                        for (int i = 1; i <= 10; i++)
                        {
                            textCollection += i + "." + input + ", ";

                        }
                        Console.WriteLine(textCollection);

                        break;
                    case "4":

                        // Hämta det tredje ordet i en mening
                        Console.WriteLine("Ange en menimg med minst tre ord: ");
                        input = Console.ReadLine()!;

                        words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


                        // Kontrollera om det finns minst tre ord
                        if (words.Length >= 3)
                        {
                            Console.WriteLine("Tredje ordet är: " + words[2].ToString());

                        }
                        else
                        {
                            Console.WriteLine("Ogiltig inmatning, du måste skriva minst 3 ord.");
                        }
                

                break;
                default:
                        // Hantera felaktig inmatning
                        Console.WriteLine("Felaktigt input, försök igen.");

                break;
            }

            } while (run); // Upprepa så länge run är true


        }

        // Metod för att beräkna totalkostnad för en gruppen baserat på ålder.
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

        // Metod för att försöka parsa en sträng till en int
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

        // Metod för att kolla ålder och visa pris baserat på ålder
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
