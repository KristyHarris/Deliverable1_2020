using System;

namespace Deliverable1_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kind of trip would you like to go on: musical, tropical, or adventurous? ");
                string vacationType = Console.ReadLine();
                string destination = "";
                    if (vacationType == "musical")
                    {
                    destination = "New Orleans";
                    }
                    else if (vacationType == "tropical")
                    {
                    destination = "a beach vacation in Mexico";
                    }
                    else if (vacationType == "adventurous")
                    {
                    destination = "whitewater rafting the Grand Canyon";
                    }
                    else Console.WriteLine("We do not offer that kind of vacation. Please try again.");

            Console.Write("How many people are in your group? ");
                int groupSize = int.Parse(Console.ReadLine());
                string travelSuggestion = "";
                    if (groupSize == 0) 
                    {
                    Console.WriteLine("At least one person needs to go on this vacation. Please try again.");
                    }
                    else if (groupSize <= 2) 
                    {
                    travelSuggestion = "First Class";
                    }
                    else if (groupSize <= 5)
                    {
                    travelSuggestion = "helicopter";
                    }
                    else if (groupSize >= 6)
                    {
                    travelSuggestion = "charter flight";
                    }
                string result = ("Since you are a group of " + groupSize + " going on a " + vacationType + " vacation, you should travel by " + travelSuggestion + " to " + destination + ".");
                Console.WriteLine(result);

        }

    }
}
