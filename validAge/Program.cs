using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validAge
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myYear = DateTime.Now;
            int age;
            int year = myYear.Year;
            
            try
            {
                Console.WriteLine("Enter your age please!");
                age = Convert.ToInt32(Console.ReadLine());

                if (age <= 0)
                {
                    Console.WriteLine("You don't exist, please try again later.");

                }
                if (age > 0)
                {
                    year = year - age;
                    Console.WriteLine("So you were born in {0}!", year);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Stop that.");
            }
            Console.ReadLine();
        }
    }
}
