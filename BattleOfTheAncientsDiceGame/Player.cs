using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheAncientsDiceGame
{
    class Player
    {
        public string name;
        public Dice dice = new Dice();
        public Battlefield battle = new Battlefield();
        public int fullHealth;
        public string setClass;
        public int damage;
        public Player(string Name)
        {
            this.name = Name;
            setClass = dice.RollDiceFour();
            dice.RollDiceTwenty();
            Console.Clear();

        }
        //public string seePlayer()
        //{
        //    return this.name;
        //}
        public string seeClass()
        {
            return this.setClass = Convert.ToString(dice.choiceClass());
        }
        public int setHealth()
        {
            //this.damage = this.fullHealth - battle.hitPlayer();
            return this.fullHealth = dice.hp();

        }
        public int damageHealth()
        {
            int fullHealth = this.fullHealth - damage; //this is wrong!
            return fullHealth;
        }
    }
}
