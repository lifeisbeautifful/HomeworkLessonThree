using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу, которая решает квадратное уравнение.
    Пользователь должен ввести коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0.После чего программа должна вывести 
    на экран все корни этого уравнения или сообщение о том, что их нет.Рассмотреть случаи когда дискриминант (D) 
    квадратного уравнения > 0, когда D<0 и когда D = 0.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ax + bx + c = 0");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
           
            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("The equation has no roots");
            }else if (D == 0)
            {
                double root = -b / (2 * a);
                Console.WriteLine("The equation has 1 root {0}",root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(D))/2*a;
                double root2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine("Equation has 2 roots: {0} and {1}",root1,root2);
            }

            Console.ReadLine();
        }
    }
}
