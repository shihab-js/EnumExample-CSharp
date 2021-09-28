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

            Console.WriteLine(weekDays.Monday);
            Console.WriteLine(weekDays.Tuesday);
            Console.WriteLine(weekDays.Wednesday);
            Console.WriteLine(weekDays.Thursday);
            Console.WriteLine(weekDays.Friday);
            Console.WriteLine(weekDays.Saturday);
            Console.WriteLine(weekDays.Sunday);



        }
}
}