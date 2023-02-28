using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Antti";
            int playerScore = 1000;
            int levelScore = 50;
            string hasScore = "has score";
            string before = "before";
            string after = "after"
            int sumScore = playerScore + levelScore;
            Console.Writeline(playerName + " " + hasScore + " " + before + " " + ":" + playerScore);
            Console.Writeline(playerName + " " + hasScore + " " + before + " " + ":" + sumScore);
        }
    }
}