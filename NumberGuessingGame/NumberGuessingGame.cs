namespace beginner_practice_projects
{
    public class NumberGuessingGame
    {
        int RandomNumber;
        string? input;
        bool Win;

        public void Execute()
        {
            Random random = new();
            RandomNumber = random.Next(0, 3);

            Console.WriteLine("Winner number - " + RandomNumber);
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Welcome to Guess the Number");
            Console.WriteLine("=============================");
            Console.Write("Please insert the number: ");

            input = Console.ReadLine();

            while (Win == false)
            {
                if (int.Parse(input!) == RandomNumber)
                {
                    Console.WriteLine($"Congratulations, you have guessed the number {RandomNumber} ");
                    Win = true;
                    break;
                }
                else
                {
                    Console.Write($"Sorry, the number is another, try again: ");
                    input = Console.ReadLine();
                }
            }

        }
    }
}