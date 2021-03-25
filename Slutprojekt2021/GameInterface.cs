using System;

namespace Slutprojekt2021
{
    public class GameInterface
    {
        public void IntroText(){
            System.Console.WriteLine("Welcome to 'Pocket Slimes'!");
            System.Console.WriteLine("Please choose an action:");
            System.Console.WriteLine("\n1. Create a new Slime");

            Console.ReadLine();
        }
    }
}
