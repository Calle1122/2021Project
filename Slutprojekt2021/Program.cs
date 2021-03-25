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

            System.Console.WriteLine("You did it!");
            Console.ReadLine();

        }



    }
}
