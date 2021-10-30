using System;

namespace snakeLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int dai = ran.Next(1,7);
            
            int positionPlayer1 = 0,positionPlayer2=0,daiNumberOfTime=0, nextMove2=0, nextMove1=0;

            while ((positionPlayer1 != 100 && positionPlayer1 < 101) && (positionPlayer2 != 100 && positionPlayer2 < 101))
            {
                if (nextMove2 != 6)
                {
                    nextMove1 = ran.Next(3);
                }
                switch (nextMove1)
                {
                    case 0://no Move
                        break;
                    case 1://ladder
                        positionPlayer1 = positionPlayer1 + dai;
                        if (positionPlayer1 > 100)
                        {
                            positionPlayer1 = positionPlayer1 - dai;
                        }
                        break;
                    case 2://snake
                        positionPlayer1 = positionPlayer1 - dai;
                        if (positionPlayer1 < 0)
                        {
                            positionPlayer1 = 0;
                        }
                        break;
                }
                if (nextMove1 != 6)
                {
                     nextMove2 = ran.Next(3);
                }
                switch (nextMove2)
                {
                    case 0://no Move
                        break;
                    case 1://ladder
                        positionPlayer2 = positionPlayer2 + dai;
                        if (positionPlayer2 > 100)
                        {
                            positionPlayer2 = positionPlayer2 - dai;
                        }
                        break;
                    case 2://snake
                        positionPlayer2 = positionPlayer2 - dai;
                        if (positionPlayer2 < 0)
                        {
                            positionPlayer2 = 0;
                        }
                        break;
                }
                daiNumberOfTime++;
                Console.WriteLine(daiNumberOfTime);
                Console.WriteLine("player 1 at step :"+positionPlayer1);
                Console.WriteLine("player 2 at step :"+positionPlayer2);
            }

            if (positionPlayer1 == 100)
            {
                Console.WriteLine("player1 won the game " + positionPlayer1);
                Console.WriteLine("dai need to played " + daiNumberOfTime + " times");
            }
            else
            {
                Console.WriteLine("player2 won the game " + positionPlayer2);
                Console.WriteLine("dai need to played " + daiNumberOfTime + " times");
            }
        }
    }
}
