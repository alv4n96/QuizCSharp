namespace QuizCSharp.Quiz
{
    internal class Number11
    {
        public static void Run()
        {
            Console.Write("{} \t | ");
            Console.Write(KurawalChecker("{}"));
            Console.WriteLine();
            Console.Write("{{}} \t | ");
            Console.Write(KurawalChecker("{{}}"));
            Console.WriteLine();
            Console.Write("{}} \t | ");
            Console.Write(KurawalChecker("{}}"));
            Console.WriteLine();
            Console.Write("{{{}}} \t | ");
            Console.Write(KurawalChecker("{{{}}}"));
            Console.WriteLine();
        }

        public static bool KurawalChecker(string input)
        {
            int count = 0;
            foreach (var item in input)
            {
                if (item == '{') count++;
                if (item == '}') count--;
                if (count < 0) return false;
            }
            return true;

        }
    }
}