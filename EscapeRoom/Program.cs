using System;

namespace EscapeRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("Hello, and welcome to the ESCAPE ROOM! **SPookY HallowEEN EdiTIOn**");
           
            Console.WriteLine("First, you will be asked a few questions...");
            
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}. What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite halloween candy?");
            var candy = Console.ReadLine();

            Console.WriteLine($"{userName}, that sounds gross! What is your favorite costume?");
            var toy = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}! Look below, The game is about to begin!");
            Console.WriteLine("------------------------------------------");

            // Console.WriteLine($"Name: {userName}");
            // Console.WriteLine($"Favorite toy: {toy}");
            // Console.WriteLine($"Favorite candy: {candy}");
            // Console.WriteLine($"Favorite color: {color}");

            Console.WriteLine($"{userName}, you just entered the ESCAPE ROOM... Are you nervous?");
            Console.ReadLine();
            Console.WriteLine($"I bet so, all you have with you is your toy {toy}, and a handful of {candy}s. Are you ready??");
            Console.ReadLine();
            Console.WriteLine("You have to choose between escaping through the DOOR, VENT or the WINDOW. The only problem is, you do not know what's on the other side!!  ");
            Console.WriteLine("The Escape room will try to guess which way you are trying to escape!! Don't let it catch you!");


            string inputUser, inputPc;
            int randomInt;


            bool playAgain = true;

            while (playAgain)
            {

                int userScore = 0;
                int pcScore = 0;

                // Scoring system is based on first "player" to reach 3 Points

                while (userScore < 3 && pcScore < 3)
                {


                    
                    Console.WriteLine("Where will you try to sneak out?");
                    inputUser = Console.ReadLine();
                    inputUser = inputUser.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputPc = "DOOR";
                            Console.WriteLine("Escape Room thinks are trying to sneak out the DOOR!");
                            if (inputUser == "DOOR")
                            {
                                Console.WriteLine("The Escape Room caught you!\n\n");
                            }
                            else if (inputUser == "VENT")
                            {
                                Console.WriteLine("Nice, You successfully snuck away! Player wins!\n\n");
                                userScore++;
                            }
                            else if (inputUser == "WINDOW")
                            {
                                Console.WriteLine("The Window is locked! The Escape room caught you!\n\n");
                                pcScore++;
                            }
                            break;

                        case 2:
                            inputPc = "VENT";
                            Console.WriteLine("Escape Room thinks you are trying to sneak out the VENT!");
                            if (inputUser == "DOOR")
                            {
                                Console.WriteLine("Nice, You successfully snuck out the door!\n\n");
                                pcScore++;
                            }
                            else if (inputUser == "VENT")
                            {
                                Console.WriteLine("BUSTED!!! The Escape Room caught you!\n\n");
                            }
                            else if (inputUser == "WINDOW")
                            {
                                Console.WriteLine("Nice, the window unlocks, and you get away!!\n\n");
                                userScore++;
                            }
                            break;

                        case 3:
                            inputPc = "WINDOW";
                            Console.WriteLine("The Escape Room thinks you are trying to sneak out the Window!!!");
                            if (inputUser == "DOOR")
                            {
                                Console.WriteLine("Nice!! You snuck out the front door! \n\n");
                                userScore++;
                            }
                            else if (inputUser == "VENT")
                            {
                                Console.WriteLine("GOOD THINKING! You snuck out of the vent!\n\n");
                                pcScore++;
                            }
                            else if (inputUser == "WINDOW")
                            {
                                Console.WriteLine("BUSTED!! The Escape Room caught you trying to slip out the Window!!!\n\n");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;

                    }
                    Console.WriteLine("\n\nScores:\tPlayer:\t{0}\tComputer:\t{1}\t", userScore, pcScore);
                }

                if (userScore == 3)
                {
                    Console.Write("You won!");
                }
                else if (pcScore == 3)
                {
                    Console.Write("Escape Room won!");

                }
                else
                {

                }

                Console.WriteLine("Do you want to try again?(Y/N)");
                string loop = Console.ReadLine();
                if (loop == "Y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing! Next time, try harder.");
                }
                else
                {
                    Console.WriteLine("Invalid entry!!!");
                }




              
            }
        }
    }
}
