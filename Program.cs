using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Marks_Calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Maths, Physics, Chemestry;
            double totalMarks;
            //taking marks of maths
            Console.Write("Enter Marks in Math :");
            Maths = Convert.ToDouble(Console.ReadLine());
            //taking marks of physics
            Console.Write("Enter Marks in Physics :");
            Physics = Convert.ToDouble(Console.ReadLine());
            //taking marks of chemestry
            Console.WriteLine("Enter Marks in Chemestry :");
            Chemestry = Convert.ToDouble(Console.ReadLine());
            totalMarks = Maths + Physics + Chemestry;
            if (totalMarks >=105)
            {
                Console.WriteLine("Your are passed  examination successful");
            }
            else
            {
                Console.WriteLine("You have to try next time");
            }
            Console.ReadLine();
        }
    }
}
