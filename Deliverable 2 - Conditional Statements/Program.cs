/* 
 Name: Jurami Cajigas
 Date: 1/24/2023
 Description: C# Console Application for calculating letter grades
 */

using System;

namespace Deliverable_2___Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300?");  //Asks question and reads user input
                decimal grade = decimal.Parse(Console.ReadLine());
                string letter = "";

                if (grade >= 90)                                                //Based on User input, Letter Grade well be given.
                {
                    letter = "A";
                    Console.WriteLine("Your letter grade is " + letter);
                }

                else if (grade >= 80) // No need for range, works either way.
                {
                    letter = "B";
                    Console.WriteLine("Your letter grade is " + letter);
                }

                else if (grade >= 70)
                {
                    letter = "C";
                    Console.WriteLine("Your letter grade is " + letter);
                }
                else if (grade >= 60)
                {

                    letter = "D";
                    Console.WriteLine("Your letter grade is " + letter);
                }

                else if (grade < 60)
                {

                    letter = "F";
                    Console.WriteLine("Your letter grade is " + letter);
                }
            }

            catch
            {
                Console.WriteLine("Please enter a numerical value");   //catch statement catches any invalid user input

            }
        }
    }
}
