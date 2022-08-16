using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Methods
    {
        public static string Bmi(double weight, double height)
        {
                
            double userBMI = (weight / (height * height));

            if (userBMI <= 18.5)
            return Console.WriteLine("Underweight"); 

            if (userBMI <= 25.0)
             return Console.WriteLine("Normal");

            if (userBMI <= 30.0)
            return Console.WriteLine("Overweight");

            else (userBMI > 30.0)
            return Console.WriteLine("Obese"); 











        }
    }
