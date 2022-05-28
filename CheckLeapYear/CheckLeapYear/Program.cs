// See https://aka.ms/new-console-template for more information
using System;
namespace CheckLeapYear
{
    class program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (( year % 4 == 0 && year % 100 != 0 ) || (year % 400 == 0 ))
            {
                Console.WriteLine("is a Leap year");
            }
            else
            {
                Console.WriteLine("is Not Leap Year");
            }


        }
    }
}
