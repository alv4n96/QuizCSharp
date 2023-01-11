namespace QuizCSharp.Quiz
{
    internal class Number8
    {
        public static void Run()
        {
            int getSaturday = (int)DayOfWeek.Saturday;
            int getToday = (int)DateTime.Today.DayOfWeek;
            int res = (getSaturday - getToday + 7) % 7;

            Console.WriteLine($"Hari Sabtu: {DateTime.Today.AddDays(res).ToShortDateString()}");
            Console.WriteLine($"{res} hari lagi!");
        }
    }
}