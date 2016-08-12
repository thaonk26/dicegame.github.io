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
        Dice dice4 = new Dice(4);
        Dice dice6 = new Dice(6);
        Dice dice8 = new Dice(8);
        Dice dice10 = new Dice(10);
        Dice dice12 = new Dice(12);
        Dice dice20 = new Dice(20);
        public Battlefield()
        {
            Console.WriteLine("-------------------Welcome to the Battle of the Ancients!---------------------");
            Console.WriteLine("What would you liked to be called Player 1?");
            player1 = new Player(Console.ReadLine(), AddedHealth());
            Console.WriteLine("Your health is set at {0}", AddedHealth());
            Console.WriteLine("What would you liked to be called Player 2?");
            player2 = new Player(Console.ReadLine(), AddedHealth());
            Console.WriteLine("Your health is set at {0}", AddedHealth());
            Console.ReadLine();
            Console.Clear();
        }
        public void RunGame()
        {
            attackPlayer();
        }
        public void attackPlayer()
        {
              while (checkAlive())
                for (int i = 0; i < 2; i++)
                {
                    if ((20 - i) % 2 == 0)
                    {
                        {
                            Console.WriteLine("\n\n\n\n\n\n\n\n--------------{0}({2}) will attempt to attack {1}({3})", player1.name, player2.name, player1.healthTotal, player2.healthTotal);
                            player2.healthTotal = player2.healthTotal - counterResult();
                            Console.WriteLine("---------------{0}'s Health is now {1}", player2.name, player2.healthTotal);
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\n\n\n\n\n\n\n--------------{0}({2}) will attempt to attack {1}({3})", player2.name, player1.name, player2.healthTotal, player1.healthTotal);
                        player1.healthTotal = player1.healthTotal - counterResult();
                        Console.WriteLine("--------------{0}'s Health is now {1}", player1.name, player1.healthTotal);
                        Console.ReadLine();
                        Console.Clear(); 
                }
            }
            isDead();
        }
        public bool checkAlive()
        {
            if(player1.isAlive() && player2.isAlive())
            {
                return true;
            }else
            {
                return false;
            }
        }
        public void isDead()
        {
            if (player2.isAlive() == false)
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n--------------{0} WINS!!!", player1.name);
                Console.ReadLine();
            } else
            {
                Console.WriteLine("\n\n\n\n\n\n\n\n--------------{0} WINS!!!", player2.name);
                Console.ReadLine();
            }
        }

        public int AddedHealth()
        {
            int rollTwenty = dice20.GetRandomNum() * dice4.GetRandomNum();
            return rollTwenty + 20;
        }
        public int counterResult()
        {
            int result = dice8.GetRandomNum();
            if (result < 3)
            {
                Console.WriteLine("--------------The attack is blocked");
                Console.WriteLine("--------------Damage done is {0}", blockAttack());
                return blockAttack();
            }
            else if (result < 6)
            {
                Console.WriteLine("--------------Tried to block/parry the attack but take aditional damage instead");
                Console.WriteLine("--------------Damage done is {0}", parryAttack());
                return parryAttack();
            }
            else
            {
                Console.WriteLine("--------------The attack hits, but the damage is reduced");
                Console.WriteLine("--------------Damage done reduced to {0}", reduceAttack());
                return reduceAttack();
            }
        }
        //public int deflectAttack()
        //{
        //    int addOrSubtract = dice4.GetRandomNum();

        //    if (addOrSubtract < 3)
        //    {
        //        int subtractDamage = dice12.GetRandomNum() - dice6.GetRandomNum();
        //        if (subtractDamage <= 0)
        //        {
        //            return 0;
        //        } else
        //        {
        //            return subtractDamage;
        //        }
                
        //    } else
        //    {
        //        int addDamage = dice12.GetRandomNum() + dice6.GetRandomNum();
        //        return addDamage;
        //    }
        //}
        public int blockAttack()
        {
            return 0;
        }
        public int parryAttack()
        {
            int parry = dice12.GetRandomNum() + dice6.GetRandomNum();
            return parry;
        }
        public int reduceAttack()
        {
            int reduce = dice12.GetRandomNum() - dice6.GetRandomNum();
            if(reduce <= 0)
            {
                return 0;
            }else
            {
                return reduce;
            }
        }
    }
}
