using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // Random rnd = new Random();
            // int r = rnd.Next(0, 101);

            Random rng = new Random();
            int r = rng.Next(0, 100);
            Console.WriteLine();

            Console.WriteLine("Guess the number!");
            int x;

            do
            {
                Console.WriteLine("Enter a number");
                string str = Console.ReadLine();
                x = int.Parse(str);
                if (x < r)
                {
                    Console.WriteLine("The number is too small!!!");
                }
                else
                {
                    Console.WriteLine("The number in too big!!!");
                }

            } while (x != r);
            Console.WriteLine("You guess the number corectly! :)",x);


        }
    }
}
