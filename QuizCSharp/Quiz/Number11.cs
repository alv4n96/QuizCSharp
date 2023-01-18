namespace QuizCSharp.Quiz
{
    internal class Number11
    {
        public static void Run()
        {

            Console.Write("{} \t | ");
            Console.Write(KurawalChecker("{}") + "\n");
            Console.Write("{{}} \t | ");
            Console.Write(KurawalChecker("{{}}") + "\n");
            Console.Write("{}} \t | ");
            Console.Write(KurawalChecker("{}}") + "\n");
            Console.Write("{{{}}} \t | ");
            Console.Write(KurawalChecker("{{{}}}") + "\n");
        }

        static bool KurawalChecker(string input)
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