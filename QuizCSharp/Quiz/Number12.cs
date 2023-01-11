namespace QuizCSharp.Quiz
{
    internal class Number12
    {
        public static void Run()
        {
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
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                for (int j = 2; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}