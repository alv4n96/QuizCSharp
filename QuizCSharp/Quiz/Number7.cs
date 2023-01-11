namespace QuizCSharp.Quiz
{
    internal class Number7
    {
        public static void Run()
        {
            Console.Write("Enter strings : ");
            var data = Console.ReadLine();
            String[] dataList = data.Split(" ");
            var res = "";

            for (int i = 0; i < dataList.Length; i++)
            {
                for (int j = 0; j < dataList[i].Length; j++)
                {
                    if (j == 0 || j == (dataList[i].Length -1))
                    {
                        res += dataList[i][j];
                    } 
                    else
                    {
                        res += "*";
                    }
                }
                res += " ";
            }

            Console.WriteLine(res);
        }
    }
}