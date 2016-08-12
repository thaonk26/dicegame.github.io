using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceBattleOfTheAncientsGame
{
    class Player
    {
        public int healthTotal;
        public string name;
        public bool alive;
        public int attackDamage;
        public Player(string Name)
        {
            healthTotal = AddedHealth();
            attackDamage = takeDamage();
            this.name = Name;
            alive = true;
        }
        public int AddedHealth()
        {
            Dice dice = new Dice(20);
            int rollTwenty = dice.GetRandomNum();
            return rollTwenty + 20;
        }
        public bool isAlive()
        {
            if (healthTotal <= 0)
            {
                return alive = false;
            }else
            {
                return alive = true;
            }
        }
        public int takeDamage()
        {
            Dice dice = new Dice(6);
            int doDamage = dice.GetRandomNum();
            return doDamage;
        }

    }
}
