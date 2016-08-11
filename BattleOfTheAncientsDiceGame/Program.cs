using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTheAncientsDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            
            Battlefield field = new Battlefield();
            field.Run();
        }
    }
}
