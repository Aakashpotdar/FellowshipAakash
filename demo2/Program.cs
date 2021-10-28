using System;

namespace demo2
{
    class perform
    {
        static void Main(string[] args)
        {
            sum sumobj = new sum();
            multiplication mulobj = new multiplication();
            Console.WriteLine("the sum is " + sumobj.add(43, 23));
            Console.WriteLine("the multiplication is" +  mulobj.mulopr(5 , 3));
        }
    }
}
