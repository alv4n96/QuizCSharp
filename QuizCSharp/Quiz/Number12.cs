namespace QuizCSharp.Quiz
{
    internal class Number12
    {
        public static void Run()
        {
            Console.WriteLine("====================================================");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 10; j >= 5 + i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================================================");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + i - 1 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====================================================");

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 3; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("====================================================");
            int spaces = 4;
            int number = 0;

            for (int row = 1; row <= 5; row++)
            {
                number = row;
                for (int col = 1; col <= 9; col++)
                {
                    if (col <= spaces || col > 9 - spaces) 
                        Console.Write("  ");
                    else
                    {
                        Console.Write(number + " ");
                        if (col >= 5) number--;
                        else number++;
                    }
                }
                spaces--;
                Console.WriteLine();
                Console.WriteLine("====================================================");
            }
        }
    }
}