using System;

namespace uc8_multipleCompanies
{
    class Program
    {
        static void Main(string[] args)
        {
            logicClass obj = new logicClass();

            Console.WriteLine("wage of Accenture company" + obj.logicmethod(150));
            Console.WriteLine("wage of Infosys company" + obj.logicmethod(120));
            Console.WriteLine("wage of TCS company" + obj.logicmethod(100));
        }
    }
}
