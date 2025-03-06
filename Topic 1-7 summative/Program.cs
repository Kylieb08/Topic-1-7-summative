namespace Topic_1_7_summative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Random generator = new Random();
            string userChoice, computerChoice;
            double money, bet;
            int wins = 0, losses = 0, ties = 0;
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
                while (userChoice.ToLower() != "rock" || userChoice.ToLower() != "paper" || userChoice.ToLower() != "scissors" || userChoice.ToLower() != "rules" || userChoice.ToLower() != "quit")
                {
                    Console.WriteLine("That is not valid input");
                }
                

            }

        }
    }
}
