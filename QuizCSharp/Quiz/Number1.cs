using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizCSharp.Quiz
{
    internal class Number1
    {
        public static void Run()
        {
        Number1:
            Console.Clear();
            Console.Write("Enter number integer : ");
            try
            {
            var input = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            foreach (var item in input.ToString()) res += (int)char.GetNumericValue(item);
            
            Console.WriteLine(res);
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                Thread.Sleep(1500);
                goto Number1;
            }
        }
        
    }
}
