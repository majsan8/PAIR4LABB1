using System.Collections;
using System.ComponentModel.Design;

namespace PAIR4LABB1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Först skriver vi ut meddelande till användaren om valen hen har.
            Console.WriteLine("****************************************************************\n");
            Console.WriteLine("Välkommen till flygtidsberäknaren!\n");

            Console.WriteLine("Vilket flyg vill du se detalierad information om? Svara med en siffra");
            Console.WriteLine("1. Stockholm - New York");
            Console.WriteLine("2. New York - Stockholm");
            Console.WriteLine("3. Avsluta programmet");

            Console.WriteLine($"Skriv ditt val här:");

            //Här läser vi in användarens input och gör om det till en "int"
            string userInput = Console.ReadLine();

            int choice = Int32.Parse(userInput);

            //Sen skapar vi samt delar upp timmar och minuter i variabler av typen "int"
            int travelHour = 7;
            int travelMinutes1 = 25;
            int timeDifference = 6;

            int departureTimeHour1 = 14;
            int departureTimeMinute1 = 3;
            //Här konverterar vi "departureTimeMinute1" till en string med "ToString("00") så att vi får två decimaler i utskriften.
            string departureTimeMinute = departureTimeMinute1.ToString("00");
            int departureTimeHour2 = 10;
            int departureTimeMinute2 = 10;

            //Här gör vi våra uträkningar för att få fram rätt tider åt användaren.
            string departureTime1 = ($"{departureTimeHour1}:{departureTimeMinute}");
            string arrivalTime1 = ($"{departureTimeHour1 + travelHour - timeDifference}:{departureTimeMinute1 + travelMinutes1}");

            string departureTime2 = ($"{departureTimeHour2}:{departureTimeMinute2}");
            string arrivalTime2 = ($"{departureTimeHour2 + travelHour + timeDifference}:{departureTimeMinute2 + travelMinutes1}");


            Console.WriteLine("**********************************************************************\n");


            //Här använder vi tre olika "if-satser" för att skriva ut rätt tider beroende på vad användaren gör för val.
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

            //Till sist så skriver vi ut ett meddelande till användern som deklarerar att programmet är klart.
            Console.WriteLine("\nTack för att du använde Flygtidsberäknaren! Nu stängs programmet ner.");


        }

    }
}
