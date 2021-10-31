using System;

namespace uc9_save
{
    class Program
    {
        static void Main(string[] args)
        {
            logicClass obj = new logicClass();

            int accentureWage = obj.logicmethod(150,"Accenture");
            int InfosysWage = obj.logicmethod(120,"Infosys");
            int TCSWage = obj.logicmethod(100,"TCS");



            Console.WriteLine("wage of Accenture company " + accentureWage);
            Console.WriteLine("wage of Infosys company " + InfosysWage);
            Console.WriteLine("wage of TCS company " + TCSWage);

        }
    }
}
