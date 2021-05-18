using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLesson3
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.
   Напишите программу, в которой создайте переменную a.Значение переменной, а должен задавать пользователь. 
   Если а < 10 то выведите 'Верно', иначе (a>10) выведите 'Неверно'.
   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numeric value for a: ");
            double a = double.Parse(Console.ReadLine());

            string result = (a < 10) ? "Right" : "Wrong";
            Console.WriteLine(result);

          
            Console.ReadLine();
        }
    }
}
