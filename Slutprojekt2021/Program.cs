using System;

namespace Slutprojekt2021
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loopDone = false;
            int okInput;

            GameInterface ui = new GameInterface();

            while(loopDone == false){
                ui.IntroText();
                string input = ui.GetUserInput();
                int inputInt = ui.ConvertInputToInt(input);
                okInput = 1;
                loopDone = ui.okInput(inputInt, okInput);

                Console.Clear();
            }

            System.Console.WriteLine("You did it!");
            Console.ReadLine();

        }



    }
}
