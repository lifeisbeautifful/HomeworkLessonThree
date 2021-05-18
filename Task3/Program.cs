using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
   /* Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, в которой создайте переменную min.
   Значение переменной должен задавать пользователь, интервал допустимых значений 0 до 59, 
   необходимо организовать проверку на ввод допустимого интервала.Определите в какую четверть часа попадает значение переменной 
   (в первую, вторую, третью или четвертую).
   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 0 to 59: ");
            int min = int.Parse(Console.ReadLine());

            if (min >= 0 && min < 15)
            {
                Console.WriteLine("The first quarter of an hour");
            }else if(min > 14 && min < 30)
            {
                Console.WriteLine("The second quarter of an hour");
            }else if(min > 29 && min < 45)
            {
                Console.WriteLine("The third quarter of an hour");
            }else if(min>44 && min < 60)
            {
                Console.WriteLine("The fourth quarter of an hour");
            }
            else
            {
                Console.WriteLine("The number does not meet proposal range");
            }
            Console.ReadLine();
        }
    }
}
