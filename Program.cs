namespace Rock_paper_scissors___Yoan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = "rock";
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = "paper";
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = "scissors";
            }
            else
            {
                Console.WriteLine("Invalid Input. Try again...");
                return;
            }

            Random random = new Random();
            int computerRandomNumber = random.Next(1, 4);

            string computerMove = "";

            switch (computerRandomNumber)
            {
                case 1:
                    computerMove = Rock;
                    break;
                case 2:
                    computerMove = Paper;
                    break;
                case 3:
                    computerMove = Scissors;
                    break;
            }
            Console.WriteLine($"Chatgpt chose {computerMove}!");

            if ((playerMove == "rock" && computerMove == Scissors) ||
                (playerMove == "paper" && computerMove == Rock) ||
                (playerMove == "scissors" && computerMove == Paper))
            {
                Console.WriteLine("You win.");
            }
            else if ((playerMove == "rock" && computerMove == Paper) ||
                (playerMove == "paper" && computerMove == Scissors) ||
                (playerMove == "scissors" && computerMove == Rock))
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("This game is a draw.");
            }
        }
    }
}