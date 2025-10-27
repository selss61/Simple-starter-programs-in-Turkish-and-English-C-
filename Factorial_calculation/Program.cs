using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number less than 13:");
            int number = int.Parse(Console.ReadLine());

            while (number >= 13)
            {
                Console.WriteLine("The number must be less than 13. Try again:");
                number = int.Parse(Console.ReadLine());
            }

            int totalvalue = 1;
            for (int i = 1; i <= number; i++)
            {
                totalvalue *= i;
            }

            Console.WriteLine("The factorial of the number you entered is: " + totalvalue);
            Console.Read();






        }
    }
}
