using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior w1 = new Warrior("Pawel", 1000, 120, 40);
            Warrior w2 = new Warrior("Adam", 1000, 120, 40);

            Game.StartGame(w1, w2);

            Console.ReadKey();
        }
    }
}
