using System;
using System.Collections.Generic;

namespace Slutprojekt2021
{
    public class GameManager
    {
        public void drawStatsBox(int hp, int level, int stage){
            Console.WriteLine("╔═════════════════════════╗");
            Console.WriteLine("║          STATS          ║");
            Console.WriteLine("╠═════════════════════════╣");
            Console.WriteLine("║ LEVEL: " + level + "                ║");
            Console.WriteLine("║                         ║");

            if(hp < 10){
                Console.WriteLine("║ HP: " + hp + "                   ║");
            }

            else if(hp > 9 && hp < 100){
                Console.WriteLine("║ HP: " + hp + "                  ║");
            }

            else{
                Console.WriteLine("║ HP: " + hp + "                 ║");
            }

            if(stage < 10){
                Console.WriteLine("║                         ║");
                Console.WriteLine("║ STAGE: " + stage + "                ║");
                Console.WriteLine("╚═════════════════════════╝");
            }

            else{
                Console.WriteLine("║                         ║");
                Console.WriteLine("║ STAGE: " + stage + "               ║");
                Console.WriteLine("╚═════════════════════════╝");
            }

            
        }

        public string[] createLevelMap(ref string[] levelArray, ref int[] levelObjectArray){
            Random generator = new Random();

            levelArray = new string[10];
            levelObjectArray = new int[10];

            for (int i = 0; i < levelArray.Length; i++)
            {
            
                int mapObject = generator.Next(1,4);

                if(mapObject == 1){

                    levelArray[i] = "X ";
                    levelObjectArray[i] = 1;

                }
                else if(mapObject == 2){

                    levelArray[i] = "X ";
                    levelObjectArray[i] = 2;

                }
                else{

                    levelArray[i] = "0 ";
                    levelObjectArray[i] = 3;

                }

            }

            return levelArray;

        }



        public void drawLevelMap(string[] levelArray, int markerPos){
            for (int i = 0; i < levelArray.Length; i++)
            {
                Console.Write(levelArray[i]);
            }

            //if(markerPos)

            Console.WriteLine();
            Console.CursorLeft = markerPos;
            Console.WriteLine("^");
            Console.CursorLeft = markerPos;
            Console.WriteLine("|");
        }



    }
}
