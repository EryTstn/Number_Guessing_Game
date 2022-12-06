using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tahmin_Oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Guessing Game");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("Please Select a Number Between 0 and 1000");
                Random say = new Random();
                int s = say.Next(0, 1000);
                int d = 0;

                while (true)
                {
                    d++;
                    Console.WriteLine();
                    Console.Write("Your Guess: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    if (x == s)
                    {
                        break;
                    }
                    else if (x < s)
                    {
                        Console.WriteLine("Try Bigger Number");
                    }
                    else if (x > s)
                    {
                        Console.WriteLine("Try Smaller Number");
                    }
                }

                if (d <= 2)
                {
                    Console.WriteLine("No Way!! You've Found at Your " + d + "st/nd Try");
                }
                else if (2 < d && d <= 5)
                {
                    Console.WriteLine("You Are Good. You've Found at Your " + d + "th Try");
                }
                else if (d > 5 && d <= 10)
                {
                    Console.WriteLine("It's Allright You've Found at Your " + d + "th Try");
                }
                else
                {
                    Console.WriteLine("Unlucky... You've Found at Your " + d + "th Try");
                }
                Console.WriteLine();
                Console.Write("Press 0 to Leave, Press Another Button to Contiune: ");
                string a = Console.ReadLine();
                if (a == "0")
                {
                    Console.WriteLine();
                    Console.WriteLine("Have a Nice Day");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("New Guess");
                }
            }
        }
    }
}
