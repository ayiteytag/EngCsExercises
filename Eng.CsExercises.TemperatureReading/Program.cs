using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature Reading");
            Console.Write("Choose a temp: <0, 0-10, 10-20, 20-30, 30-40 or >=40: ");
            string uservalue = Console.ReadLine();

            if (uservalue == "0")
            {
                string message = "Freezing weather";
                Console.WriteLine(message);
            }
            else if (uservalue == "0-10")
            {
                string message = "Very cold weather";
                Console.WriteLine(message);
            }
            else if (uservalue == "10-20")
            {
                string message = "Cold weather";
                Console.WriteLine(message);
            }
            else if (uservalue == "20-30")
            {
                string message = "Normal in Temp";
                Console.WriteLine(message);
            }
            else if (uservalue == "30-40")
            {
                string message = "Its hot";
                Console.WriteLine(message);
            }
            else if (uservalue == ">=40")
            {
                string message = "Its very hot";
                Console.WriteLine(message);
            }

            Console.ReadLine();


        }
    }
}
