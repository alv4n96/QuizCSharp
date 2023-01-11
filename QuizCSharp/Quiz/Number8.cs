namespace QuizCSharp.Quiz
{
    internal class Number8
    {
        public static void Run()
        {
        Number8:

            Console.Write("Masukkan tanggal FORMAT[yyyy/mm/dd] : ");
            try
            {
                var data = Console.ReadLine();
                DateTime dataDate = DateTime.Parse(data, "dd/MM/yyyy");

            }
            catch (Exception ex) 
            {
                Console.Write(ex.Message);
            }
        }
    }
}