namespace QuizCSharp.Quiz
{
    internal class Number9
    {
        public static void Run()
        {
            Console.Write("Enter strings : ");
            var data = Console.ReadLine();
            Console.Write("Find string   : ");
            var findData = Console.ReadLine();
            int res = 0, tempCounter = 0;

            try
            {

                for (int i = 0; i < data.Length; i++)
                {
                    for (int j = 0; j < findData.Length; j++)
                    {
                        if (data[i + j] == findData[i])
                        {
                            tempCounter++;
                            if (tempCounter == findData.Length)
                            {
                                res++;
                                tempCounter = 0;
                                i = i + j;
                            }
                        }

                    }
                }
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            

            Console.WriteLine(res);

        }
    }
}