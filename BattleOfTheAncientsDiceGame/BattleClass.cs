using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheAncientsDiceGame
{
    public class BattleClass
    {
        string mage;
        string warrior;
        string rogue;
        string priest;


        public BattleClass()
        {

        }
        public virtual void setMage()
        {
            Console.WriteLine("You will send magic at your enemies");
            Console.ReadLine();
        }
        public virtual void setWarrior()
        {
            Console.WriteLine("You are a warrior");
        }
        public virtual void setRogue()
        {
            Console.WriteLine("You will be come a sneak man");
        }
        public virtual void setPriest()
        {
            Console.WriteLine("You are the Holiest of them all");
        }
    }
}
