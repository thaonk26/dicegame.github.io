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
        public Player(string Name, int TotalHealth)
        {

            this.healthTotal = TotalHealth;
            this.name = Name;
            this.alive = true;
        }
        
        public bool isAlive()
        {
            if (healthTotal <= 0)
            {
                return this.alive = false;
            }else
            {
                return this.alive = true;
            }
        }
        
       

    }
}
