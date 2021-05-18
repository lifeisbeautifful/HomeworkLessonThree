using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, в которой пользователь 
    вводит целое число. Программа в свою очередь должна ответить, четным или нечетным является это число, делится ли оно на 3 
    и делится ли оно на 6.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

           
            if (number % 2 == 0)
            {
                Console.WriteLine("even number");
            }
            else
            {
                Console.WriteLine("odd number");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("The number is divided by 3");
            }
            else
            {
                Console.WriteLine("The number is not divided by 3");
            }
            if (number % 6 == 0)
            {
                Console.WriteLine("The number id divided by 6");
            }
            else
            {
                Console.WriteLine("The number is not divided by 6");
            }

            Console.ReadLine();
        }
    }
}
