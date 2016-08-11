using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheAncientsDiceGame
{
    class Dice
    {
        Random random = new Random();
        BattleClass battle = new BattleClass();
        int rollDiceFour;
        int health;
        
        public Dice()
        {

        }
        public string RollDiceFour()
        {
            int rollFour = random.Next(1, 5);
            rollDiceFour = rollFour;
            Console.WriteLine("Roll a D4 die to pick your Class\n D4: {0}", rollFour);
            Console.ReadLine();
            if (rollFour == 1)
            {
                Console.WriteLine("You have been given the Class Mage");
                Console.ReadLine();
                battle.setMage();
            }
            else if (rollFour == 2)
            {
                Console.WriteLine("You have been given the Class Warrior");
                Console.ReadLine();
                battle.setWarrior();
            }
            else if (rollFour == 3)
            {
                Console.WriteLine("You have been given the Class Rogue");
                Console.ReadLine();
                battle.setRogue();
            }
            else
            {
                Console.WriteLine("You have been given the Class Priest");
                Console.ReadLine();
                battle.setPriest();
            }
            return Convert.ToString(rollFour);
        }
      
        public int choiceClass()
        {
            return this.rollDiceFour;
        }
        public int RollDiceTwenty()
        {
            int rollTwenty = random.Next(1, 21);
            health = 20 + rollTwenty;
            Console.WriteLine("Rolling a D20 to increase your base health\n D20: {0}", rollTwenty);
            Console.ReadLine();
            Console.WriteLine("Your health has increased by: {0}", rollTwenty);
            Console.WriteLine("Your health is now: " + health);
            Console.ReadLine();
            return health;
        }
        public int hp()
        {
            return health;
        }
        public int RollDiceSix()
        {
            int rollSix = random.Next(1, 7); 
            Console.WriteLine("Rolling a D6 die to inflict damage\n D6: {0}", rollSix);
            Console.ReadLine();
            return rollSix;
        }
        
    }
}
