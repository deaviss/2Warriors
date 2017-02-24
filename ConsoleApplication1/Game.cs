using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
        public static void StartGame(Warrior warrior1, Warrior warrior2)
        {
            while (true)
            {
                if (EndValue(warrior1, warrior2) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
                if (EndValue(warrior2, warrior1) == "Game over")
                {
                    Console.WriteLine("Game over");
                    break;
                }
            }
        }

        public static string EndValue(Warrior warriorA, Warrior warriorB)
        {

            double warriorADMG = warriorA.Attak();
            double warriorBBlock = warriorB.Block();

            double dmgAmount = warriorADMG - warriorBBlock;

            if (dmgAmount > 0)
            {
                warriorB.Health -= dmgAmount;
                Console.WriteLine("{0} uderzyl {1} za {2}HP",
                    warriorA.Name,
                    warriorB.Name,
                    dmgAmount);
                Console.WriteLine("{0} posiada teraz {1}HP\n",
                    warriorB.Name,
                    warriorB.Health);
            }
            else dmgAmount = 0;

            if (warriorB.Health < 0)
            {
                Console.WriteLine("{0} zostal pokonany przez {1} z {2} pkt zycia",
                    warriorB.Name,
                    warriorA.Name,
                    warriorA.Health);
                return "Game over";
            }
            else
                return "Graj dalej";
        }
    }
}
