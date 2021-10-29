using System;

namespace uc4_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullDayWage = 0,halfDayWage=0, fullDayHr = 10, halfDayHr = 6, wagePerHr = 100;
            Random ran = new Random();
            int valueToCheck = ran.Next(3);

            switch (valueToCheck)
            {
                case 0:
                    Console.WriteLine("employee is absent");
                    break;
                case 1:
                    fullDayWage = fullDayHr * wagePerHr;
                    Console.WriteLine("full day wage: " + fullDayWage);
                    break;
                case 2:
                    halfDayWage = halfDayHr * wagePerHr;
                    Console.WriteLine("half day wage: " + halfDayWage);
                    break;
            }
        }
    }
}
