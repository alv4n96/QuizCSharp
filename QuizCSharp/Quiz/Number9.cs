namespace QuizCSharp.Quiz
{
    internal class Number9
    {
        public static void Run()
        {
            Console.Write("Enter String: ");
            var inputString = Console.ReadLine();
            Console.Write("Find String: ");
            var findString = Console.ReadLine();
            int count = 0;
            int index = inputString.IndexOf(findString);

            while (index != -1)
            {
                count++;
                index = inputString.IndexOf(findString, index + findString.Length);
            }
            Console.WriteLine("Total kata yang muncul: " + count + " dari text: " + inputString);
        }
    }
}