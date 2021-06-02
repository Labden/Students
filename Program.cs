using System;
using System.Collections.Generic;

namespace TommysStudentDatabaseBreakout
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn == true)
            {


                //                                        0,      1,       2,        3,       4,         5,       6,        7,      8,      9,      10,     11
                List<string> names = new List<string>() { "Mark", "James", "Andrew", "Tommy", "Maggie", "Jerome", "Trent", "Troy", "Kevin", "Josh", "Sean", "Kate" };
                //Given our list of names, how do we tie hometowns / favorite foods to a particular person?

                List<string> foods = new List<string>() { "Cilantro", "Sushi", "Sushi", "Chicken Curry", "Movie Theatre Popcorn", "Italian Cuisine", "Tacos", "Broccoli", "Asian Cuisine", "nalesniki", "MEAT.", "Pizza" };
                List<string> hometown = new List<string>() { "Grand Rapids, MI", "Toledo, OH", "Raleigh, NC", "Montrose, MI", "Wilwaukee, WI", "Rochester, MI", "Indian River, MI", "Detroit, MI", "Northville, MI", "Eaton Rapids, MI", "Zeeland, MI", "" };

                PrintWholeList(names);
                //Console readline can only give us a string
                //so to use it as an index we must convert it to an int
                Console.WriteLine("Which student would you like to learn about? (0-11)");

                int input = Int32.Parse(Console.ReadLine());

                while (input < 0 || input > 11)
                {
                    Console.WriteLine("Please enter a valid number, 0-11: ");
                    input = Int32.Parse(Console.ReadLine());
                }

                

                string name = names[input];
                Console.WriteLine($"What would you like to learn about {name}? (hometown or favorite food)");

                string input2 = Console.ReadLine();


                if (input2 == "hometown")
                {
                    string ht = hometown[input];
                    Console.WriteLine(ht);
                }
                else if (input2 == "favorite food")
                {
                    string ff = foods[input];
                    Console.WriteLine(ff);
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again.");
                }
            }
            goOn = GetContinue();
        }

        public static void PrintWholeList(List<string> items)
        {
            for (int i = 0; i > items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i]}");
            }
        }

        static bool GetContinue()
        {
            Console.WriteLine("Would you like to learn about another student? (y/n)");
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                return true;
            }
            else if (answer == "N")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again");
                return GetContinue();

            }
        }
    }
}