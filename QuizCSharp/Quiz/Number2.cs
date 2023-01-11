using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCSharp.Quiz
{
    internal class Number2
    {
        public static void Run()
        {
        soalNumber2:
            Console.Clear();
            Console.Write("Enter number integer : ");
            try
            {
                int input = Convert.ToInt32(Console.ReadLine());
                var res = 0;

                foreach (var item in input.ToString()) res++;

                Console.WriteLine($"Count : {res}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                goto soalNumber2;
            }

        }
    }
}
