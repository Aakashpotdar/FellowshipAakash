using System;

namespace uc3_halfTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int halfDayWage, partTimeHr = 8,wage=20;

            halfDayWage = partTimeHr * wage;

            Console.WriteLine("Part Time Wages  are " + halfDayWage);
        }
    }
}
