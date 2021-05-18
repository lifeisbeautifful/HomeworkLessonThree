using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, которая определяет, 
    является ли год високосным. Пользователь вводит год.Программа должна вывести на экран ответ, является ли год високосным. 
    Подсказка.Обычно каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100).
    Но среди последних год, делящийся на 400, также считается високосным.
    */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year: ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    Console.WriteLine("not leap year");
                }
                else
                {
                    Console.WriteLine("leap year");
                }
            }
            else
            {
                Console.WriteLine("not leap year");
            }

            Console.ReadLine();

        }
    }
}

