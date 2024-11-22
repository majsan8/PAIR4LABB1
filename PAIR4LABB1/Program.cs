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

            int travelHour = 7;
            int travelMinutes1 = 25;
            int timeDifference = 6;

            int departureTimeHour1 = 14;
            int departureTimeMinute1 = 3;
            string departureTimeMinute = departureTimeMinute1.ToString("00");
            int departureTimeHour2 = 10;
            int departureTimeMinute2 = 10;


            string departureTime1 = ($"{departureTimeHour1}:{departureTimeMinute}");
            string arrivalTime1 = ($"{departureTimeHour1 + travelHour - timeDifference}:{departureTimeMinute1 + travelMinutes1}");

            string departureTime2 = ($"{departureTimeHour2}:{departureTimeMinute2}");
            string arrivalTime2 = ($"{departureTimeHour2 + travelHour + timeDifference}:{departureTimeMinute2 + travelMinutes1}");


            Console.WriteLine("**********************************************************************\n");

            if (choice == 1)
            {

                Console.WriteLine($"Avgångstid från Stockholm:" + " " + departureTime1);
                Console.WriteLine($"Ankomsttid till New York:" + " " + arrivalTime1);
            }

            else if (choice == 2)
            {
                Console.WriteLine($"Avgångstid från New York:" + " " + departureTime2);
                Console.WriteLine($"Ankomsttid till Stockholm:" + " "  + arrivalTime2);
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

            Console.WriteLine("\nTack för att du använde Flygtidsberäknaren! Nu stängs programmet ner.");


        }

    }
}
