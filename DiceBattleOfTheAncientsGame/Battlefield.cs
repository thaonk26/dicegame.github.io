using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBattleOfTheAncientsGame
{
    class Battlefield
    {
        Player player1;
        Player player2;
        Dice dice6 = new Dice(6);
        Dice dice8 = new Dice(8);
        Dice dice10 = new Dice(10);
        Dice dice12 = new Dice(12);
        bool alive = true;
        public Battlefield()
        {
            Console.WriteLine("Welcome to the Battle of the Ancients!");
            Console.WriteLine("What would you liked to be called Player 1?");
            player1 = new Player(Console.ReadLine());
            Console.WriteLine("What would you liked to be called Player 2?");
            player2 = new Player(Console.ReadLine());
            
        }
        public void RunGame()
        {
            attackPlayer();
        }
        public void attackPlayer()
        {
            while (checkAlive())
            {
                for (int i = 0; i < 2; i++)
                {
                    if ((20 - i) % 2 == 0)
                    {
                        Console.WriteLine("{0} will attack {1}", player1.name, player2.name);
                        int damage = player2.attackDamage;
                        Console.WriteLine("{0} did {2} to {1}", player1.name, player2.name, damage);
                        player2.healthTotal = player2.healthTotal - damage;
                        Console.WriteLine("{0}'s Health is now {1}", player2.name, player2.healthTotal);
                        Console.ReadLine();
                        
                    }
                    else
                    {
                        Console.WriteLine("{0} will attack {1}", player2.name, player1.name);
                        int damage = player1.attackDamage;
                        Console.WriteLine("{0} did {2} to {1}", player2.name, player1.name, damage);
                        player1.healthTotal = player1.healthTotal - damage;
                        Console.WriteLine("{0}'s Health is now {1}", player1.name, player1.healthTotal);
                        Console.ReadLine();
                    }
                }
                
            }
        }
        public bool checkAlive()
        {
            if(player1.alive && player2.alive)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public int RollDiceSix()
        {
            int rollSix = Convert.ToInt32(dice6.GetRandomNum());
            return rollSix;
        }
    }
}
