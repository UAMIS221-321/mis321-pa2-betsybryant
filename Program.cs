using System.Threading;
using System;

namespace mis321_pa2_betsybryant
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayTheGame();
        }
        static void PlayTheGame()
        {
            int playerChoice = Menu.BeginGame(); //call the method that asks the user if they want to play the game
            while(playerChoice != 2)
            {
                switch(playerChoice)
                {
                    case 1:
                        P1Menu(); //play the game
                        break;
                    default:
                        Menu.InvalidMenuOption(); //invalid
                        break;
                }
                playerChoice = Menu.BeginGame(); //update read
            }
            Console.WriteLine("Exiting the system...");
        }
        static void P1Menu() 
        {
            Character player1 = new Character(); 
            int playerChoice = Menu.Player1Menu(); //ask the user to pick a player
            while(playerChoice != 4)
            {
                string player1Name = Menu.PlayerName1();
                player1.PlayerName = player1Name;
                switch(playerChoice)
                {
                    case 1:
                        Console.WriteLine(player1Name + ", you chose Jack Sparrow.");
                        player1 = new JackSparrow(){PlayerName = player1.PlayerName, MaxPower = player1.MaxPowerRandom(), Health = 100, AttackStrength = player1.AttackStrengthRandom(), DefensivePower = player1.DefensivePowerRandom()};;
                        P2Menu(player1); //chose Jack Sparrow and filling the variables ^^
                        break;
                    case 2:
                        Console.WriteLine(player1Name + ", you chose Will Turner.");
                        player1 = new WillTurner(){PlayerName = player1.PlayerName, MaxPower = player1.MaxPowerRandom(), Health = 100, AttackStrength = player1.AttackStrengthRandom(), DefensivePower = player1.DefensivePowerRandom()};;
                        P2Menu(player1); //filling the variables ^^
                        break;
                    case 3:
                        Console.WriteLine(player1Name + ", you chose Davy Jones.");
                        player1 = new DavyJones(){PlayerName = player1.PlayerName, MaxPower = player1.MaxPowerRandom(), Health = 100, AttackStrength = player1.AttackStrengthRandom(), DefensivePower = player1.DefensivePowerRandom()};;
                        P2Menu(player1); //filling the variables ^^
                        break;
                    default:
                        Menu.InvalidMenuOption();
                        break;
                }
                playerChoice = Menu.Player1Menu();
            }
            Console.WriteLine("Exiting system");
        }
        static void P2Menu(Character player1) 
        {
            Character player2 = new Character();
            int playerChoice2 = Menu.Player2Menu(); //ask teh user to choose a player
            while(playerChoice2 != 4)
            {
                string player2Name = Menu.PlayerName2();
                player2.PlayerName = player2Name;
                switch(playerChoice2)
                {
                    case 1:
                        Console.WriteLine(player2Name + ", you chose Jack Sparrow.");
                        player2 = new JackSparrow(){PlayerName = player2.PlayerName, MaxPower = player2.MaxPowerRandom(), Health = 100, AttackStrength = player2.AttackStrengthRandom(), DefensivePower = player2.DefensivePowerRandom()};
                        WhoGoesFirst(player1, player2); //filling the variables ^^
                        break;
                    case 2:
                        Console.WriteLine(player2Name + ", you chose Will Turner.");
                        player2 = new WillTurner(){PlayerName = player2.PlayerName, MaxPower = player2.MaxPowerRandom(), Health = 100, AttackStrength = player2.AttackStrengthRandom(), DefensivePower = player2.DefensivePowerRandom()};;
                        WhoGoesFirst(player1, player2); //filling the variables ^^
                        break;
                    case 3:
                        Console.WriteLine(player2Name + ", you chose Davy Jones.");
                        player2 = new DavyJones(){PlayerName = player2.PlayerName, MaxPower = player2.MaxPowerRandom(), Health = 100, AttackStrength = player2.AttackStrengthRandom(), DefensivePower = player2.DefensivePowerRandom()};;
                        WhoGoesFirst(player1, player2); //filling the variables ^^
                        break;
                    default:
                        Menu.InvalidMenuOption();
                        break;
                }
                playerChoice2 = Menu.Player2Menu();    
            }
            Console.WriteLine("Exiting system");
        }
        static void WhoGoesFirst(Character player1, Character player2)
        {
            Console.WriteLine("There will be a random number generator to see who goes first.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000); //fun add on
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            int number = GetNumber();
            System.Threading.Thread.Sleep(2000);
            if(number == 1)
            {
                Console.WriteLine($"{player1.CharacterName}/ {player1.PlayerName} will go first"); //player 1 goes first
                System.Threading.Thread.Sleep(1000);
                while(player1.Health >= 0 && player2.Health >= 0)
                {
                    Game1(player1, player2);
                    Thread.Sleep(2000);
                    Game2(player1, player2);
                    Winner(player1, player2);
                }
            }
            else
            {
                Console.WriteLine($"{player2.CharacterName}/ {player2.PlayerName} will go first"); //player 2 goes first
                System.Threading.Thread.Sleep(1000);
                while(player1.Health >= 0 && player2.Health >= 0)
                {
                    Game2(player1, player2);
                    Thread.Sleep(2000);
                    Game1(player1, player2);
                    Winner(player1, player2);
                }
            }
            System.Threading.Thread.Sleep(2000);
        }
        static int GetNumber()
        {
            Random randomNumber = new Random();
            int getNumber = randomNumber.Next(1,3);
            int numberGet = getNumber;
            return numberGet;
        }
        static void Game1(Character player1, Character player2)
        {
            if(player1.Health >= 0 && player2.Health >= 0)
            {  
                player1.attackBehavior.Attack(); //player attacks first
                double typeBonus = 1; //generic type bonus
                if((player1.CharacterName == "Jack Sparrow" && player2.CharacterName == "Will Turner") || (player1.CharacterName == "Will Turner" && player2.CharacterName == "Davy Jones") || (player1.CharacterName == "Davy Jones" && player2.CharacterName == "Jack Sparrow"))
                {
                    typeBonus = 1.2; //boost bonus
                    double dealDamage = player1.AttackStrength - player2.DefensivePower * typeBonus; //damage detector
                    if(player1.Health > 0 && player2.Health > 0)
                    {
                        if(dealDamage >= 0)
                        {
                            player2.Health -= dealDamage; //subtracts from the health only if it is greater than 0
                            Console.WriteLine("Damage done: " + dealDamage);
                        }
                        else if(dealDamage < 0)
                        {
                            player2.defendBehavior.Defend(); //if damage is negative, that means that the player attacked had a better defense which means no point taken out of the health
                        }
                    } 
                }
                else //no boost
                {
                    double dealDamage = player1.AttackStrength - player2.DefensivePower * typeBonus;
                    if(player1.Health > 0 && player2.Health > 0)
                    {
                        if(dealDamage > 0)
                        {
                            player2.Health -= dealDamage;
                            Console.WriteLine("Damage done: " + dealDamage);
                        }
                        else if(dealDamage < 0)
                        {
                            player2.defendBehavior.Defend();
                        }
                        Thread.Sleep(2000);
                    } 
                }
                Console.WriteLine("\nHere are the current stats after this round...");
                Thread.Sleep(1000);
                player1.Stats(); //calls stats
                Thread.Sleep(1000);
                player2.Stats(); //calls stats
                Console.WriteLine("\nPress enter when ready for the next round");
                Console.ReadLine();
                player2.AttackStrength = player2.AttackStrengthRandom();
                player1.AttackStrength = player1.AttackStrengthRandom(); //resetting the random generator
                player2.DefensivePower = player2.DefensivePowerRandom();
                player1.DefensivePower = player1.DefensivePowerRandom();
                player2.MaxPower = player2.MaxPowerRandom();
                player1.MaxPower = player1.MaxPowerRandom();
            }
        }
        static void Game2(Character player1, Character player2)
        {
            if(player1.Health >= 0 && player2.Health >= 0)
            { 
                player2.attackBehavior.Attack();
                double typeBonus = 1;
                if((player2.CharacterName == "Jack Sparrow" && player1.CharacterName == "Will Turner") || (player2.CharacterName == "Will Turner" && player1.CharacterName == "Davy Jones") || (player2.CharacterName == "Davy Jones" && player1.CharacterName == "Jack Sparrow"))
                {
                    typeBonus = 1.2;
                    double dealDamage = player2.AttackStrength - player1.DefensivePower * typeBonus;
                    if(player1.Health > 0 && player2.Health > 0)
                    {
                        if(dealDamage > 0)
                        {
                            player1.Health -= dealDamage;
                            Console.WriteLine("Damage done: " + dealDamage);
                        }
                        else if(dealDamage < 0)
                        {
                            player1.defendBehavior.Defend();
                        }
                    } 
                }
                else
                {
                    double dealDamage = player2.AttackStrength - player1.DefensivePower * typeBonus;
                    if(player1.Health > 0 && player2.Health > 0)
                    {
                        if(dealDamage > 0)
                        {
                            player1.Health -= dealDamage;
                            Console.WriteLine("Damage done: " + dealDamage);
                        }
                        else if(dealDamage < 0)
                        {
                            player1.defendBehavior.Defend();
                        }
                    } 
                }
                Console.WriteLine("\nHere are the current stats after this round...");
                Thread.Sleep(1000);
                player1.Stats();
                Thread.Sleep(1000);
                player2.Stats();
                Console.WriteLine("\nPress enter when ready for the next round");
                Console.ReadLine();
                player2.AttackStrength = player2.AttackStrengthRandom();
                player1.AttackStrength = player1.AttackStrengthRandom(); // resetting the random generator
                player2.DefensivePower = player2.DefensivePowerRandom();
                player1.DefensivePower = player1.DefensivePowerRandom();
                player2.MaxPower = player2.MaxPowerRandom();
                player1.MaxPower = player1.MaxPowerRandom();
            }
        }
        static void Winner(Character player1, Character player2) //winners
        {
            if(player1.Health <=0)
            {
                Console.WriteLine($"{player1.PlayerName} / {player1.CharacterName} won! Good game!");
            }
            else if(player2.Health <=0)
            {
                Console.WriteLine($"{player2.PlayerName} / {player2.CharacterName} won! Good game!");
            }
        }
    }
}
