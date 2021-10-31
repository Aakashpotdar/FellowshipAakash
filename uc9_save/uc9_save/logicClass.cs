using System;
using System.Collections.Generic;
using System.Text;

namespace uc9_save
{
    class logicClass
    {
        public int logicmethod(int wagePerHr,string componyName)
        {
            int totalHr = 0, wageOfMonth = 0, workingDays = 1, fullDayWage = 0, halfDayWage = 0, fullDayHr = 20, halfDayHr = 10;
            Random ran = new Random();

            while (workingDays <= 20 & totalHr <= 200)
            {
                int valueToCheck = ran.Next(3);
                switch (valueToCheck)
                {
                    case 0:
                        Console.WriteLine("employee of "+ componyName+" is absent on " + workingDays);
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
            return wageOfMonth;
        }

    }
}
