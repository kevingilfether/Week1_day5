using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_day5
{
    class Program
    {
        static void Main(string[] args)
        {
            string passcode = "orange";

            Console.WriteLine("Enter the secret code:");
            string userAnswer = Console.ReadLine();

            if (passcode == userAnswer.ToLower()) 
            {
                Console.WriteLine("Woo-hoo!");
            }
            else
            {
                Console.WriteLine("Run me again with \"CTRL+F5\"");
            }

        }
    }
}
