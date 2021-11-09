using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LogicClass obj = new LogicClass();

            int accentureWage = obj.logicmethod(150, "Accenture");
            int InfosysWage = obj.logicmethod(120, "Infosys");
            int TCSWage = obj.logicmethod(100, "TCS");

            Console.WriteLine("wage of Accenture company " + accentureWage);
            Console.WriteLine("wage of Infosys company " + InfosysWage);
            Console.WriteLine("wage of TCS company " + TCSWage);

        }
    }
}
