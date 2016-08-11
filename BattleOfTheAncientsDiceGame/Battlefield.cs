using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheAncientsDiceGame
{
    class Battlefield
    {
        public Player player1;
        public Player player2;
        public Dice die = new Dice();
        int turn;
        int damage;
        public Battlefield()
        {

        }
        public void Run()
        {
            SetUpGame();
        }
        public void SetUpGame()
        {
            Console.WriteLine("Welcome to Battle of the Ancients");
            Console.WriteLine("Please Enter a name for Player 1");
            player1 = new Player(Console.ReadLine());
            Console.WriteLine("Please Enter a name for Player 2");
            player2 = new Player(Console.ReadLine());
            RunRound();
        }
        private void RunRound()
        {
            for(int turn = 0; turn < 10; turn++)
            if(turn %2 == 0)
            {
                attackPlayer2();
                
                } else {
            attackPlayer1();
            
                }
        }
        public void attackPlayer2()
        {
            Console.WriteLine("{0} attacks {1}", player1.name, player2.name);
            int rollSix = die.RollDiceSix();
            damage = damage + rollSix;
            Console.WriteLine("{0}'s remaining health is {1}", player2.name, player2.damageHealth());
            Console.ReadLine();
            
                 
        }
        public void attackPlayer1()
        {
            //Console.WriteLine("{0} attacks {1}", player2.seePlayer(), player1.seePlayer());
            ////int rollSix = die.RollDiceSix();
            ////string firstAttack = Convert.ToString(player1.setHealth() - rollSix);
            //Console.WriteLine("{0}'s remaining health is {1}", player1.seePlayer(), player1.damageHealth());


            Console.WriteLine("{0} attacks {1}", player2.name, player1.name);
            int rollSix = die.RollDiceSix();
            damage = damage + rollSix;
            Console.WriteLine("{0}'s remaining health is {1}", player1.name, player1.damageHealth());
            Console.ReadLine();
        }
        public int hitPlayer()
        {
            return this.damage;
        }
    }
}
