using System;
using System.Collections.Generic;

namespace Slutprojekt2021
{
    public class GameManager
    {
        public void drawStatsBox(int hp, int level){
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║          STATS          ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║ LEVEL: " + level + "                ║");
            Console.WriteLine("║                         ║");
            Console.WriteLine("║ HP: " + hp + "                  ║");
            Console.WriteLine("║                         ║");
            Console.WriteLine("║                         ║");
            Console.WriteLine("╚═════════════════════════╝");
        }
    }
}
