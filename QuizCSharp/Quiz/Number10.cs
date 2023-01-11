namespace QuizCSharp.Quiz
{
    internal class Number10
    {
        public static void Run()
        {
            int[] data = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i+1}: ");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }
            int theHighest = data[0];
            int secondHighest = 0;

            for (int i = 0; i < 5; i++)
            {
                if (data[i] > theHighest)
                {
                    secondHighest = theHighest;
                    theHighest = data[i];
                }
                else if (data[i] > secondHighest && data[i] != theHighest)
                {
                    secondHighest= data[i];
                }
            }
            Console.WriteLine($"Second greatest: {secondHighest}");
        }
    }
}