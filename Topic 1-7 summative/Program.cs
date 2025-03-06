namespace Topic_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random computerChoice = new Random();
            string userChoice;
            double money, bet;
            int win = 0, loss = 0, tie = 0;
            bool done = false;

            Console.WriteLine("Welcome! This is a game of rock paper scissors");
            Thread.Sleep(1000);
            Console.WriteLine("To play, the program will prompt you for a choice: rock, paper, or scissors");
            Thread.Sleep(2000);
            Console.WriteLine("You can also quit at any time by typing 'quit'");
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

            while (!done)
            {
                if (money <= 0)
                {
                    Console.WriteLine("You are out of money");
                    Console.WriteLine("Game over");
                    done = true;
                }

                Console.WriteLine("How much would you like to bet?");
                while (!double.TryParse(Console.ReadLine(), out bet) || bet > money)
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
                }

                if (userChoice.ToLower() == "quit")
                {
                    Console.WriteLine("You had $" + money + " left in your account");
                    Console.WriteLine("You won " + win + " times");
                    Console.WriteLine("You lost " + loss + " times");
                    Console.WriteLine("You tied " + tie + " times");
                    Console.WriteLine("Thank you for playing");
                    done = true;
                }

                else if (userChoice.ToLower() == "rules")
                {
                    Console.WriteLine("The rules are as following:");
                    Console.WriteLine("You choose rock, paper or scissors. The program does the same");
                    Console.WriteLine("Rock beats scissors, scissors beats paper, paper beats rock");
                    Console.WriteLine("If you beat the program, you win the bet. If the program beats you, you lose the bet");
                    Console.WriteLine("If you and the program tie, nothing happens");
                    Console.WriteLine("The game end either when you quit or when you run out of money");
                }
              
            }

        }
    }
}
