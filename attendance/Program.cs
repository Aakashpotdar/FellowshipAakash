using System;

namespace attendance
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int totalwage = 0;
            Random ran = new Random();
            fullDay fullobj = new fullDay();
            halfdaywage halfobj = new halfdaywage();
         
            for (int i = 0; i <= 20; i++)
            {
                
                int atnds = ran.Next(3);
                
                switch (atnds)
                {
                    case 0:
                        Console.WriteLine("on day " + i +" Employe is absent");
                        break;
                    case 1:
                        totalwage=totalwage+fullobj.fulldayWage();
                        break;
                    case 2:
                        totalwage = totalwage + halfobj.halfday();
                        break;
                }
            }
            Console.WriteLine("wage of 20 days"+totalwage);
        }
    }
}
