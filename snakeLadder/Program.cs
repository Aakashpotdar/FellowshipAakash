using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int dai = ran.Next(1,7);
            
            int position = 0,daiNumberOfTime=0;

            while (position != 100 & position < 101)
            {
                int nextMove = ran.Next(3);
                if (position < 0)
                {
                    position = 0;
                }
                switch (nextMove)
                {
                    case 0://no Move
                        break;
                    case 1://ladder
                        position = position + dai;
                        if (position > 100)
                        {
                            position = position - dai;
                        }
                        break;
                    case 2://snake
                        position = position - dai;
                        break;
                }
                daiNumberOfTime++;
                Console.WriteLine(daiNumberOfTime);
                Console.WriteLine(position);
            }
            Console.WriteLine("player possition is " + position);
            Console.WriteLine("dai need to played " + daiNumberOfTime + " times");

        }
    }
}
