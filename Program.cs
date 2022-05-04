using System;

namespace StarTrekvsStarWars
{
    class Program
    {
        private static string? firstShipName = "";
        private static string? secondShipName = "";
        private static bool shipsConfirmed = false;

        static void Main(string[] args)
        {
            while (String.IsNullOrEmpty(firstShipName) || !shipExist(firstShipName))
            {
                firstShipName = getShipNameInput(1);
            }
            Console.WriteLine($"{firstShipName} has been added to your list{Environment.NewLine}");

            while (String.IsNullOrEmpty(secondShipName) || !shipExist(secondShipName))
            {
                secondShipName = getShipNameInput(2);
            }
            Console.WriteLine($"{secondShipName} has been added to your list{Environment.NewLine}");

            while (!shipsConfirmed)
            {
                Console.WriteLine($"Would you like to compare these ships {firstShipName} & {secondShipName}? Y/N");
                string? shouldCompareResponse = Console.ReadLine();
                if (shouldCompareResponse?.ToLower() == "n")
                {
                    Console.WriteLine("Type 1 or 2 to reset the ship");
                    int response = Int32.Parse(Console.ReadLine().Substring(0, 1));
                }
                else if (shouldCompareResponse?.ToLower() == "y") shipsConfirmed = true;

            }

            Console.Write($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }

        public static string getShipNameInput(int orderInUserShipList)
        {
            switch (orderInUserShipList)
            {
                case 1:
                    Console.WriteLine("Enter the Name of your First Ship");
                    break;
                case 2:
                    Console.WriteLine("Enter the Name of your Second Ship");
                    break;
            }
            string? name = Console.ReadLine();
            if (name == null) return "";
            return name;
        }

        public static bool shipExist(string shipName)
        {
            if (!(shipName == "Test Name"))
            {
                Console.WriteLine($"{shipName} is not a valid ship. {Environment.NewLine}Please try again.");
                return false;
            }
            return true;
        }
    }
}