using System;
using System.Collections.Generic;

namespace Slutprojekt2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar variabel som kollar ifall en loop ska köras igen eller inte (bool)
            bool loopDone = false;
            //Skapar en variabel som anger vad som är okInput (int)
            int okInput;

            Random generator = new Random();

            //Skapar en instans av klassen GameInterface som tar hand om input, typkonvertering och allt som spelaren ser på skärmen
            GameInterface ui = new GameInterface();

            //Skapar en instans av klassen GameManager som tar hand om självaste Gameplay sakerna
            GameManager slimeGame = new GameManager();

            //Denna loop körs tills spelaren angett motsvarande okInput
            while(loopDone == false){
                //I loopen körs (GameInterface) ui metoderna:
                //ui.IntroText skriver ut lite informativ text + spelarens alternativ
                ui.IntroText();
                //ui.GetUserInput hämtar en string från spelaren och lagrar den i variablen (string input)
                string input = ui.GetUserInput();
                //ui.ConvertInputToInt försöker att göra om spelarens input till en int. Ifall det gick lagras int-värdet i variablen (int inputInt), och annars lagras värdet 0
                int inputInt = ui.ConvertInputToInt(input);
                //Sätter variablen (int okinput) = 1 vilket innebär att endast int = 1 är okej
                okInput = 1;
                //ui.okInput jämför spelaren input med okInput och ifall de är lika så kommer man ur loopen, annars körs den igen
                loopDone = ui.okInput(inputInt, okInput);

                Console.Clear();
            }

            bool slimeLoopDone = false;
            int activeSlime = 0;
            SlimeManager slimeManager = new SlimeManager();
            slimeManager.createNewSlime();

            while(slimeLoopDone == false){
                //Innan man valt namn:
                slimeManager.slimeList[activeSlime].drawPlayerStats(slimeManager.slimeList[0]);
                slimeManager.setSlimeName(slimeManager.slimeList[activeSlime]);

                Console.Clear();

                //Efter man valt namn:
                Console.WriteLine("Name: " + slimeManager.slimeList[activeSlime].name);
                slimeManager.slimeList[activeSlime].drawPlayerStats(slimeManager.slimeList[0]);

                Console.WriteLine("\nPress ENTER to continue");

                Console.ReadLine();
                Console.Clear();

                slimeLoopDone = true;
            }



            //SPELET STARTAR!!!!!!

            string[] levelArray = new string[10];
            int[] levelObjectArray = new int[10];;

            int stage = 1;
            int markerPos;

            bool gameIsFinished = false;

            while(gameIsFinished == false){
                markerPos = 0;

                slimeGame.createLevelMap(ref levelArray, ref levelObjectArray);

                bool stageIsDone = false;

                while(stageIsDone == false){
                    slimeGame.drawStatsBox(slimeManager.slimeList[activeSlime].hp, slimeManager.slimeList[activeSlime].level, stage);
                    slimeGame.drawLevelMap(levelArray, markerPos);

                    Console.WriteLine("Object ID: " + levelObjectArray[markerPos/2]);

                    bool areaDone = false;

                    while (areaDone == false){
                        if(levelObjectArray[markerPos/2] == 1){
                            Console.WriteLine("There is nothing here...");
                            Console.WriteLine("Press ENTER to continue");

                            Console.ReadLine();

                            areaDone = true;
                        }

                        else if(levelObjectArray[markerPos/2] == 2){
                            Console.WriteLine("An enemy has appeared!");
                            
                            int damage = generator.Next(5,11);

                            Console.WriteLine("The enemy deals " + damage + " damage.");

                            slimeManager.slimeList[activeSlime].hp -= damage;

                            Console.WriteLine("\nPress ENTER to continue");

                            Console.ReadLine();

                            areaDone = true;
                        }

                        else{
                            Console.WriteLine("You found a chest containing: Large Potion");
                            Console.WriteLine("Press ENTER to continue");

                            Console.ReadLine();

                            areaDone = true;
                        }
                    }

                    markerPos = markerPos + 2;

                    Console.Clear();

                    if(markerPos > 18){
                        stageIsDone = true;
                        stage++;
                    }
                }

                int healing = generator.Next(16,36);

                Console.WriteLine("You finished stage: " + stage);
                Console.WriteLine("Your slime heals: +" + healing + " HP.");

                slimeManager.slimeList[activeSlime].hp += healing;

                Console.ReadLine();
                Console.Clear();


                
            }

            

            







                //Den utkommenterade koden nedan kan användas för att byta ut sin slime mot en ny. Vet inte ifall jag kommer använda detta
                /*slimeManager.createNewSlime();
                slimeManager.removeSlimeFromList(activeSlime);
                Console.Clear();*/
        }





    }
}
