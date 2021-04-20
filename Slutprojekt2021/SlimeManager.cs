using System;
using System.Collections.Generic;

namespace Slutprojekt2021
{
    public class SlimeManager
    {
        public List<Slime> slimeList = new List<Slime>();

        public void addSlimeToList(Slime slimeToAdd){
            slimeList.Add(slimeToAdd);
        }

        public void removeSlimeFromList(int slimeIndex){
            slimeList.RemoveAt(slimeIndex);
        }

        public void createNewSlime(){
            Random generator = new Random();

            int randomizeSlime = generator.Next(1,3);

            if(randomizeSlime == 1){
                ShadowSlime PlayerSlime = new ShadowSlime();
                slimeList.Add(PlayerSlime);
            }

            else{
                WaterSlime PlayerSlime = new WaterSlime();
                slimeList.Add(PlayerSlime);
            }
        }

        public void setSlimeName(Slime playerSlime){
            bool okName = false;
            string slimeName = "";

            Console.WriteLine("\nPlease choose a name for your slime:");
            

            while(okName == false){
                slimeName = Console.ReadLine();
                slimeName.Trim();

                if(slimeName == ""){
                    Console.WriteLine("Please choose a name!");
                }

                else{
                    okName = true;
                }
            }

            playerSlime.name = slimeName;
        }

    }
}
