using System;
using System.Collections.Generic;
using System.Text;

namespace attendance
{
    public class fullDay
    {
        int wagePerHr = 20, hour = 8, totalDayWage = 0;
        public int fulldayWage() 
        {
            totalDayWage = 0;
            totalDayWage = (wagePerHr * hour);
            
            return totalDayWage;
        }
    }
}
