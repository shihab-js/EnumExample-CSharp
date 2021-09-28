using System;

namespace EnumExample
{
    class Program
    {
        enum weekDays
        {
            //create a enum

            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {

            //access the Enum

            Console.WriteLine(weekDays.Monday); //Monday
            Console.WriteLine(weekDays.Tuesday); //Tuesday
            Console.WriteLine(weekDays.Wednesday); //Wednesday
            Console.WriteLine(weekDays.Thursday); // Thursday
            Console.WriteLine(weekDays.Friday); // Friday
            Console.WriteLine(weekDays.Saturday); // Saturday
            Console.WriteLine(weekDays.Sunday); // Sunday



        }
    }
}