namespace Topic_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random generator = new Random();
            string userChoice;
            double money, bet;
            int win = 0, loss = 0, tie = 0, computerChoice, totalRounds = 0;
            bool done = false;

            Console.WriteLine("Welcome! This is a game of rock paper scissors");
            Thread.Sleep(1000);
            Console.WriteLine("To play, the program will prompt you for a choice: rock, paper, or scissors");
            Thread.Sleep(2000);
            Console.WriteLine("If you would like to quit, type 'quit' when prompted for rock, paper, or scissors");
            Thread.Sleep(2000);
            Console.WriteLine("You will be prompted for how much money you're starting with, and how much you would like to bet");
            Thread.Sleep(2000);
            Console.WriteLine("If you would like to view the rules of rock paper scissors, type 'rules'");
            Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("How much money do you have in your account?");
            while (!double.TryParse(Console.ReadLine(), out money) || money < 0)
            {
                Console.WriteLine("That is not a valid amount");
                Console.WriteLine("Please try again");
            }

            Console.WriteLine("You have $" + money + " in your account");

            //ADD BEEPS!!!!!!!!!!!!!!

            while (!done)
            {
                Console.ForegroundColor = ConsoleColor.White;

                //The game is a little bit rigged. If it chooses 4, the player loses no matter what
                //But they don't know that
                computerChoice = generator.Next(1, 5);

                

                Console.WriteLine("How much would you like to bet?");
                while (!double.TryParse(Console.ReadLine(), out bet) || bet > money || bet < 1)
                {
                    Console.WriteLine("That is not valid input");
                    Console.WriteLine("Please try again");
                }

                Console.WriteLine();
                Console.WriteLine("Rock, paper, or scissors?");
                userChoice = Console.ReadLine();
                while (userChoice.ToLower() != "rock" && userChoice.ToLower() != "paper" && userChoice.ToLower() != "scissors" && userChoice.ToLower() != "rules" && userChoice.ToLower() != "quit")
                {
                    Console.WriteLine("That is not valid input");
                    Console.WriteLine("Please try again");
                    userChoice = Console.ReadLine();
                    Console.WriteLine();
                }

                if (userChoice.ToLower() == "quit")
                {
                    Console.WriteLine("You had $" + money + " left in your account");
                    Console.WriteLine("You played " + totalRounds + " times");
                    Console.WriteLine("You won " + win + " times");
                    Console.WriteLine("You lost " + loss + " times");
                    Console.WriteLine("You tied " + tie + " times");
                    Console.WriteLine("Thank you for playing");
                    done = true;
                }

                else if (userChoice.ToLower() == "rules")
                {
                    Thread.Sleep(0500);
                    Console.WriteLine();
                    Console.WriteLine("The rules are as following:");
                    Thread.Sleep(2000);
                    Console.WriteLine("You choose rock, paper or scissors. The program does the same");
                    Thread.Sleep(2000);
                    Console.WriteLine("Rock beats scissors, scissors beats paper, paper beats rock");
                    Thread.Sleep(2000);
                    Console.WriteLine("If you beat the program, you win the bet. If the program beats you, you lose the bet");
                    Thread.Sleep(2000);
                    Console.WriteLine("If you and the program tie, nothing happens");
                    Thread.Sleep(2000);
                    Console.WriteLine("The game ends either when you quit or when you run out of money");
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                }

                else if (userChoice.ToLower() == "rock")
                {
                    if (computerChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        win += 1;
                        money += bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if (computerChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You tied");
                        tie += 1;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost :(");
                        loss += 1;
                        money -= bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (userChoice.ToLower() == "paper")
                {
                    if (computerChoice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        win += 1;
                        money += bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if (computerChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You tied");
                        tie += 1;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost :(");
                        loss += 1;
                        money -= bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

                else if (userChoice.ToLower() == "scissors")
                {
                    if (computerChoice == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        win += 1;
                        money += bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if (computerChoice == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("You tied");
                        tie += 1;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost :(");
                        loss += 1;
                        money -= bet;
                        totalRounds += 1;
                        Console.WriteLine("You have $" + money + " in your account");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    
                }
                
                if (money <= 0)
                {
                    Console.WriteLine("You are out of money");
                    Console.WriteLine("Game over");
                    Console.WriteLine();
                    Console.WriteLine("You had $" + money + " left in your account");
                    Console.WriteLine("You played " + totalRounds + " times");
                    Console.WriteLine("You won " + win + " times");
                    Console.WriteLine("You lost " + loss + " times");
                    Console.WriteLine("You tied " + tie + " times");
                    Console.WriteLine("Thank you for playing");
                    done = true;
                }
            }

        }
    }
}
