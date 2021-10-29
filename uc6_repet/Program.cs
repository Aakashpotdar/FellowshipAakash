using System;

namespace uc6_repet
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalHr=0,wageOfMonth = 0,workingDays=1, fullDayWage = 0, halfDayWage = 0, fullDayHr = 20, halfDayHr = 10, wagePerHr = 100;
            Random ran = new Random();

            while ( workingDays <= 20 & totalHr<=200 )
            {
                int valueToCheck = ran.Next(3);
                switch (valueToCheck)
                {
                    case 0:
                        Console.WriteLine("employee is absent on " + workingDays);
                        workingDays++;
                        break;
                    case 1:
                        fullDayWage = fullDayWage + (fullDayHr * wagePerHr);                      
                        workingDays++;
                        totalHr = totalHr + fullDayHr;
                        break;
                    case 2:
                        halfDayWage = halfDayWage + (halfDayHr * wagePerHr);
                        workingDays++;
                        totalHr = totalHr + halfDayHr;
                        break;
                }
            }
            wageOfMonth = fullDayWage + halfDayWage;
            Console.WriteLine("working hours " + totalHr);
            Console.WriteLine("working days " + workingDays);
            Console.WriteLine("wages of total month " + wageOfMonth);
        }
    }
}
