using System.Collections;
using System.ComponentModel.Design;

namespace PAIR4LABB1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("Välkommen till flygtidsberäknaren!\n");

            Console.WriteLine("Vilket flyg vill du se detalierad information om? Svara med en siffra");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");

            Console.WriteLine($"Skriv ditt val här:");

            string userInput = Console.ReadLine();

            int choice = Int32.Parse(userInput);

            int hours = 7;
            double minutes = 0.25;
            int timeDifference = 6;

            double departureTime1 = 14.03;
            double departureTime2 = 10.10;

            double arrivalTime1 = departureTime1 + hours + minutes - timeDifference;
            double arrivalTime2 = departureTime2 + hours + minutes + timeDifference;

            Console.WriteLine("**********************************************************************\n");

            if (choice == 1)
            {

                Console.WriteLine($"Avgångstid från Stockholm:" + departureTime1);
                Console.WriteLine($"Ankomsttid till New York:" + arrivalTime1);
            }

            else if (choice == 2)
            {
                Console.WriteLine($"Avgångstid från New York:" + departureTime2);
                Console.WriteLine($"Ankomsttid till Stockholm:" + arrivalTime2);
            }

            else if (choice == 3)
            {
                Console.WriteLine("Nu avslutas programmet");
                Environment.Exit(0);
            }

            else
            { 
                Console.WriteLine("Du har använt ett val som inte är giltigt. Välj: 1, 2 eller 3");
            }

            Console.WriteLine("\n**************************************************************************");


        }
        
    }
}
