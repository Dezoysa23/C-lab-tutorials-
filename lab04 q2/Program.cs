using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab04_q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ConvertValues convert = new ConvertValues();

            
            Console.WriteLine("Enter Your distance in kilometer: ");
            float km = (float)Convert.ToDecimal(Console.ReadLine());

            float meter = convert.KilometerTometer(km);
            Console.WriteLine("Your distance in Kilometer is: " + meter);


            Console.ReadKey();
        }
    }
}
