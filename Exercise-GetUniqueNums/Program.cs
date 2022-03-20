using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseGetUniqueNums
{
    class MainClass
    {
        //Write a program and ask the user to continuously enter a number or type "Quit" to exit.
        //The list of numbers may include duplicates. Display the unique numbers that the user has entered.

        public static void Main(string[] args)
        {

            var quit = false;
            List<int> numList = new List<int>();
            List<int> noDupes = new List<int>();

            while (quit == false)
            {
                Console.WriteLine("Please Enter Any Number Or Type 'Quit' to Exit");
                var userInput = Console.ReadLine();
                


                if (userInput == "Quit")
                {
                    quit = true;
                } else
                {
                    var numInput = Convert.ToInt32(userInput);
                    numList.Add(numInput);
                    continue;
                }
            }

            
            for (var i = 0; i < numList.Count; i++)
            {
                if (noDupes.Contains(numList[i]))
                {
                    continue;
                } else
                {
                    noDupes.Add(numList[i]);
                }
            }

            foreach (var num in noDupes)
            {
                Console.WriteLine("Unique Number: " + num);
            }
        }
    }
}
