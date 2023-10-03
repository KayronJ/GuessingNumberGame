namespace GuessTheNumber
{
    class Program
    {
        public static void guessingNumber()
        {
            Random rnd = new Random();
            int numb = rnd.Next(100);

            int trials = 5;
            int i, guess;

            Console.WriteLine("A number is chosen between" +
                               "1 to 100. Guess the number within 5 trials.");

            for(i = 0; i < trials; i++)
            {
                Console.WriteLine("Guess the number: ");
                guess = Convert.ToInt32(Console.ReadLine());

                if(numb == guess)
                {
                    Console.WriteLine("Congrats, you guessed the number.");
                    break;
                }
                else if(numb > guess && i != trials - 1)
                {
                    Console.WriteLine("The number is greater than " + guess);
                }
                else if(numb < guess && i != trials - 1)
                {
                    Console.WriteLine("The number is less than " + guess);
                }
            }
            if(i == trials)
            {
                Console.WriteLine("You have exhausted the trials");
                Console.WriteLine("The number was " + numb);
            }
        }
        static void Main(string[] args)
        {
            guessingNumber();
        }
    }
}