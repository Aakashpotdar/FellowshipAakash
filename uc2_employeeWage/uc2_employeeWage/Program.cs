using System;

namespace uc2_employeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagePerHr = 20;
            int workingHr = 8;

            int totalwage = wagePerHr * workingHr;

            Console.WriteLine("total wage to pay "+totalwage);
        }
    }
}
