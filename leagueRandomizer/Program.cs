using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leagueRandomizer
{
    class Program
    {
        /*
         ToDo:
            ***For Players Only***
            Create list for players/summoner name input - done 2/14
                Debug - Print list - done 2/14
            Randomize list of inputs - done 2/14
                Debug - Print list - done 2/14
            Organize output for readability - done 2/14
            Loop to allow another input from the "menu"
            Editting summoners in list
            Team/player Save/Load option?

            ***For Champions Only***
            Load champions (from file)
            Randomize champions
                Debug - pick and print any 10

            ***For Both***
            Apply champions to player
                Debug - Print list
            Save/Load option?

            ***Randomize Roles?***
        */

        // edit current player list
        private void editPlayers(List<string> playerList)
        {

        }

        static void Main(string[] args)
        {
            // player list
            List<string> playerList = new List<string>();

            // first output
            Console.WriteLine("Welcome to the League Team Randomizer v1!"); // outputs to console
            Console.WriteLine("For now, let's see what you want to do:\n");

            Console.WriteLine(
                "1: Randomize players into Team 1 and Team 2\n" +
                "2: Randomize Champions for players\n" +
                "3: Randomize Teams and Champions\n" +
                "[Q]uit"
                );

            // get key input
            string input1;
            input1 = Console.ReadLine();

            while (input1 != "q" && input1 != "Q")
            {
                switch (input1)
                {
                    case "1":
                        Console.Clear();

                        // get players
                        getPlayers(playerList);

                        // randomize players
                        randomizeTeams(playerList);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("You entered a 2...good job - Not yet implemented");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("You entered a 3...good job - Not yet implemented");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Not a valid input, press any key to try again...");
                        break;
                }

                Console.WriteLine(
                "1: Randomize players into Team 1 and Team 2\n" +
                "2: Randomize Champions for players\n" +
                "3: Randomize Teams and Champions\n" +
                "[Q]uit"
                );

                input1 = Console.ReadLine();
            }

            //string test = Console.ReadLine(); // gets string from console
            //Console.WriteLine(test); // writes string
            //Console.Write("\nPress any key to quit...");
            //Console.ReadKey(); // pauses console after last output
        }

        // input function, loops to obtain 10 player/summoner names and allow printing
        private static void getPlayers(List<string> playerList)
        {
            string userIn;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Summoner " + (i + 1) + ": ");
                userIn = Console.ReadLine();
                playerList.Add(userIn);
            }

            Console.Clear();
            Console.WriteLine("All Players entered, here's who we have: ");
            foreach (string player in playerList)
            {
                Console.WriteLine(player);
            }
        }

        // randomizer, changes list "in place" and prints split up teams in a readable format
        private static void randomizeTeams(List<string> playerList)
        {
            // setup randomizer
            Random picker = new Random((int) DateTime.Now.Ticks);

            // our lovely integer
            int swapMe;

            // a temp string, so we don't lose anyone
            string placeHolder;

            for(int i = 0; i < playerList.Count(); i++)
            {
                swapMe = picker.Next(playerList.Count());
                placeHolder = playerList[i];
                playerList[i] = playerList[swapMe];
                playerList[swapMe] = placeHolder;
            }

            Console.WriteLine("All Players moved around, let's see the teams: ");
            Console.WriteLine("Team 1 \t\t\t\t\t Team 2");

            for (int i = 0; i < (playerList.Count() / 2); i++)
            {
                Console.WriteLine(playerList[i] + " \t\t\t\t\t " + playerList[i + 5]);
            }
        }
    }
}
