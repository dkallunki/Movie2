using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = " ";
            int movieYear = 1900;
            string movieRating = " ";
            int counter=0;
            do
            {

                // asks user to enter a movie name, and echo's response
                System.Console.WriteLine("Please enter a movie name no. " + (counter+1));
                movieName = Console.ReadLine();// read in name
                Console.WriteLine("NAME: ");// write name to screen
                Console.WriteLine(movieName);
                // asks user for movie year and echo's response
                System.Console.WriteLine("Please enter a movie year no. " + (counter + 1));
                movieYear = int.Parse(Console.ReadLine());
                Console.WriteLine("YEAR: " + movieYear);
                // asks user for movie rating and echo's response
                System.Console.WriteLine("Please enter a movie rating no. " + (counter + 1));
                movieRating = Console.ReadLine();// read in name
                Console.WriteLine("RATING: ");// write name to screen
                Console.WriteLine(movieRating);
                counter++;
            } while (counter < 3);
        }
    }
}
