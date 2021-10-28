using System;
using System.Collections.Generic;
using System.Text;

namespace attendance
{
    public class halfdaywage
    {
        int wagePerHr = 20, hour = 4, totalDayWage = 0;
        public int halfday()
        {
            totalDayWage = 0;
            totalDayWage = (wagePerHr * hour);
       
            return totalDayWage;
        }

    }
}
