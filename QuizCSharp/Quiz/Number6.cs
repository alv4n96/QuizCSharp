using System;

namespace QuizCSharp.Quiz
{
    internal class Number6
    {
        public static void Run()
        {
        Number6:
            Console.Clear();
            var res = "";
            Console.Write("Enter limit number : ");
            try
            {
                var data = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i < data; i++)
                        if (IsPrime(i)) res = res + i.ToString() + " ";

                Console.WriteLine(res);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                goto Number6;
            }
        }

        private static bool IsPrime(int value)
        {
            for (int i = 2; i <= Math.Sqrt(value); i++)
                if (value % i == 0) return false;

            return true;

        }
    }
}