using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
           

        
             int[] myArray = { 445, 5667, 45, 54, 78, 4593583, 457, 45, 78, 98, 1000 };
            int MaxNumber = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > MaxNumber)
                {
                    MaxNumber = myArray[i];
                }


            }
            Console.WriteLine("Dizideki en büyük sayı:" + MaxNumber);
            int sum = 0;
            int[] number = new int[5];
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine($"Lütfen {i + 1}. sayıyı giriniz:");
                number[i] = int.Parse(Console.ReadLine());
                sum += number[i]; // sum = sum + number[i]; bu iki ifade aynı anlama gelir
            }
            Console.WriteLine("Girmiş olduğunuz sayıların toplamı:");
            Console.WriteLine(sum);


            



            Console.Read();


            




        }









    }
}
