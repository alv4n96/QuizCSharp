namespace QuizCSharp.Quiz
{
    internal class Number3
    {
        public static void Run()
        {
        soalNumber3:
            Console.Clear();
            Console.Write("Enter number integer : ");

            string res = "";
            try
            {
                var input = Convert.ToInt32(Console.ReadLine());
                var data = Convert.ToString(input);
                for (int i = (data.Length - 1); i >= 0; i--) res += " " + data[i];
                Console.WriteLine(res);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                goto soalNumber3;
            }
        }
    }
}