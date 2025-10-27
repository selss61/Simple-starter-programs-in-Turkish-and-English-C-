using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foreachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Grade point averages of students with clear names
            Console.WriteLine("****************************************");
            Console.WriteLine();
            Console.Write("How many students are there in the class: ");
            int Numberofstudents = int.Parse(Console.ReadLine());
            string [] studentNames =new string[Numberofstudents];
            double[] studentExamAvg = new double[Numberofstudents];
            
            for (int i = 0; i < Numberofstudents; i++)
            {
                
                Console.Write($"{i+1}th Student's name and surname: " );
                studentNames[i] = Console.ReadLine();
                double totalExamScore = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{j+1}th grade: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamScore += value;
                }
                studentExamAvg[i] = totalExamScore / 3;
            }
            
            for (int k = 0; k < Numberofstudents; k++)
            {
                Console.WriteLine($"Exam avarage of the named student {studentNames[k]}: {studentExamAvg[k]}");

                if (studentExamAvg[k]>=60)
                {
                    Console.WriteLine($"Student named {studentNames[k]} congratulations, you passed the class");
                }
                else
                {
                    Console.WriteLine($"You stayed in the student class named {studentNames[k]}");
                }
            }
           


            Console.Read();

            #endregion
        }
    }
}
