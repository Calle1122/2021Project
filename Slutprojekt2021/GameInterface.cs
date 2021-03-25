using System;

namespace Slutprojekt2021
{
    public class GameInterface
    {
        public void IntroText(){
            System.Console.WriteLine("Welcome to 'Pocket Slimes'!");
            System.Console.WriteLine("Please choose an action:");
            System.Console.WriteLine("\n1. Create a new Slime");
        }

        public string GetUserInput(){
            string input = Console.ReadLine();

            return input;
        }

        public int ConvertInputToInt(string input){
            bool success = int.TryParse(input, out int inputInt);
            if(success == true){
                return inputInt;
            }

            else{
                return 0;
            }
        }

        public bool okInput(int inputInt, int isOkInt){
            if(inputInt == isOkInt){
                return true;
            }
            else{
                return false;
            }
        }

    }
}
