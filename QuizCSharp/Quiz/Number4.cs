namespace QuizCSharp.Quiz
{
    internal class Number4
    {
        public static void Run()
        {
            int highest = 0;
            do
            {
            Number4:
                Console.Write("Enter integer [ Type 0 for Exit ] : ");
                try 
                { 
                    var data = Convert.ToInt32(Console.ReadLine());
                    if (data > highest) highest = data;
                    if (data == 0) break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto Number4;
                }
            } while (true);

            Console.WriteLine($"Angka terbesar : {highest}");
        }
    }
}