using System;

namespace EmployeePresent_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int value1 = ran.Next(3);
            if (value1 == 1)
            {
                Console.WriteLine("the employee is present");
            }
            else
            {
                Console.WriteLine("the employee is not present");
            }
            Console.WriteLine("");
        }
    }
}
