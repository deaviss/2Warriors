using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Warrior
    {
        public string Name { get; set; } = "Wojownik";
        public double Health { get; set; } = 0;
        public double MaxAttak { get; set; } = 0;
        public double MaxBlock { get; set; } = 0;
        Random random = new Random();

        public Warrior(string name = "Wojownik",
            double health = 0,
            double maxAttack = 0,
            double maxBlock = 0)
        {
            Name = name;
            Health = health;
            MaxAttak = maxAttack;
            MaxBlock = maxBlock;
        }

        public double Attak()
        {
            return random.Next(1, (int)MaxAttak);
        }

        public double Block()
        {
            return random.Next(1, (int)MaxBlock);
        }
    }
}
