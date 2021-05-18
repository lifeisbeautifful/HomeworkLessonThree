using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу определения, попадает
    ли указанное пользователем число от 0 до 100 в числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. 
    Если да, то укажите, в какой именно промежуток. Если пользователь указывает число не входящее ни в один из имеющихся числовых
    промежутков, то выводится соответствующее сообщение.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number from 0 to 100: ");
            int number = int.Parse(Console.ReadLine());

            if(number>= 0 && number < 15)
            {
                Console.WriteLine("Number is in [0 - 14] range");
            }else if(number > 14 && number < 36)
            {
                Console.WriteLine("Number is in [15 - 35] range");
            }else if(number>35 && number < 51)
            {
                Console.WriteLine("Number is in [36 -50] range");
            }else if(number>50 && number < 101)
            {
                Console.WriteLine("Number is in [51 - 100] range");
            }
            else
            {
                Console.WriteLine("Number does not meet proposal range");
            }

            Console.ReadLine();
        }
    }
}
