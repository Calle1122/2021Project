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


            slimeGame.drawStatsBox(slimeManager.slimeList[activeSlime].hp, slimeManager.slimeList[activeSlime].level);

            Console.ReadLine();

            







                //Den utkommenterade koden nedan kan användas för att byta ut sin slime mot en ny. Vet inte ifall jag kommer använda detta
                /*slimeManager.createNewSlime();
                slimeManager.removeSlimeFromList(activeSlime);
                Console.Clear();*/
        }





    }
}
