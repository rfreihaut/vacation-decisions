using System;

namespace VacationDecisions
{
    class Program
    {
        static int groupSize;
        static string vacationType;
        static string travelSuggestion;
        static string destination;
        static string result = $"Since you’re a group of ";

        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
            vacationType = Console.ReadLine();
            Console.WriteLine("How many are in your group?");
            groupSize = int.Parse(Console.ReadLine());

            switch (vacationType.ToLower())
            {
                case "musical":
                    destination = "New Orleans";
                    break;
                case "tropical":
                    destination = "a Beach Vacation in Mexico";
                    break;
                case "adventurous":
                    destination = "Whitewater Rafting the Grand Canyon";
                    break;
                default:
                    break;
            }

            if (groupSize < 3)
            {
                travelSuggestion = "First Class";
            }
            else if (groupSize > 2 && groupSize < 6)
            {
                travelSuggestion = "Helicopter";
            }
            else if (groupSize > 6)
            {
                travelSuggestion = "Charter Flight";
            }

            result = result + $"{groupSize} going on a(n) {vacationType} vacation, you should take a {travelSuggestion} to {destination}.";

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
