namespace QuizCSharp.Quiz
{
    internal class Number5
    {
        public static void Run()
        {
        Number5:
            var res = "";

            Console.Clear();
            Console.Write("Enter numbers : ");
            try
            {
                var number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < number; i++) if (number % i == 0)
                    {
                        res = res + i.ToString() + " ";
                    }
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                goto Number5;
            }


        }
    }
}