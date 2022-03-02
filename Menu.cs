using System;
namespace mis321_pa2_betsybryant
{
    public class Menu
    {
        public static int BeginGame()
        {
            Console.WriteLine("Welcome to the Battle of Calypso's maelstrom. Please choose an option below. \n1. Play game \n2. Exit");
            return int.Parse(Console.ReadLine());
        }
        public static string PlayerName1()
        {
            Console.WriteLine("Please enter your name player 1");
            return Console.ReadLine();
        }
        public static string PlayerName2()
        {
            Console.WriteLine("Please enter your name player 2");
            return Console.ReadLine();
        }
        public static int Player1Menu()
        {
            Console.WriteLine("Player 1, please choose your player. \n1. Jack Sparrow \n\tPrimary attack: distraction \n2. Will Turner \n\tPrimary attack: sword \n3. Davy Jones \n\tPrimary attack: cannon fire\n4. Go back");
            return int.Parse(Console.ReadLine());
        }
        public static int Player2Menu()
        {
            Console.WriteLine("Player 2, please choose your player. \n1. Jack Sparrow \n\tPrimary attack: distraction \n2. Will Turner \n\tPrimary attack: sword \n3. Davy Jones \n\tPrimary attack: cannon fire\n4. Go back");
            return int.Parse(Console.ReadLine());
        }
        public static void InvalidMenuOption()
        {
            Console.WriteLine("This is an invalid choice. Please try another choice.");
        }
    }
}