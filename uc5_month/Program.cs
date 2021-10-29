  using System;

namespace uc5_month
{
    class Program
    {
        static void Main(string[] args)
        {
                int wageOfMonth=0,fullDayWage = 0, halfDayWage = 0, fullDayHr = 10, halfDayHr = 6, wagePerHr = 100;
                Random ran = new Random();
                
            for (int i = 1; i <= 20; i++)
            {
                int valueToCheck = ran.Next(3);
                switch (valueToCheck)
                {
                    case 0:
                        Console.WriteLine("employee is absent on "+i);
                        break;
                    case 1:
                        fullDayWage = fullDayWage+(fullDayHr * wagePerHr);
                        //Console.WriteLine("full day wage: " + fullDayWage);
                        break;
                    case 2:
                        halfDayWage = halfDayWage+(halfDayHr * wagePerHr);
                        //Console.WriteLine("half day wage: " + halfDayWage);
                        break;
                }
            }
            wageOfMonth = fullDayWage + halfDayWage;
            Console.WriteLine("wages of total month " + wageOfMonth);
        }
    }
    
}
