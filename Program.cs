using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count1 = 0;
            Console.WriteLine("how many rounds you want to play");
            int round = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("rock=1,paper=2,scissor=3");
            Console.WriteLine("Enter the userchoice:");
            MyRPS game=(MyRPS)Convert.ToInt32(Console.ReadLine());
            Random random=new Random();
            MyRPS AI=(MyRPS)random.Next(1,3);
            
                if (game == MyRPS.ROCK && AI == MyRPS.ROCK)
            {
                Console.WriteLine("Both players are select same object");
            }
            else if (game==MyRPS.ROCK&&AI==MyRPS.PAPER)
            {
                Console.WriteLine("paper is win");
                count1++;
               
            }
            else if (game==MyRPS.ROCK&&AI==MyRPS.SCISSOR)
            {
                Console.WriteLine("Rock is win");
                count++;
            }
            else if (game==MyRPS.PAPER&&AI==MyRPS.PAPER)
            {
                Console.WriteLine("Both players are select same object");
            }
            else if (game==MyRPS.PAPER&&AI==MyRPS.ROCK)
            {
                Console.WriteLine("paper is win");
                count1++;
            }
            else if (game==MyRPS.PAPER&&AI==MyRPS.SCISSOR)
            {
                 Console.WriteLine("paper is win");
                count1++;
            }
            else if (game==MyRPS.SCISSOR&&AI==MyRPS.SCISSOR)
            {
                Console.WriteLine("Both players are select same object");
            }
            else if (game==MyRPS.SCISSOR&&AI==MyRPS.PAPER)
            {
                Console.WriteLine("scissor is win");
                count++;
            }
            else if (game==MyRPS.SCISSOR&&AI==MyRPS.ROCK)
            {
                Console.WriteLine("Scissor is win");
                count++;
            }
           
            if (count>count1)
            {
                Console.WriteLine("user win");
            }
            else if (count<count1)
            {
                Console.WriteLine("AI win");
            }
            else
            {
                Console.WriteLine("match draw");
            }
           

        
            
            
        }

        enum MyRPS
        {
            ROCK=1,
            PAPER=2,
            SCISSOR=3
        }
    }
}
