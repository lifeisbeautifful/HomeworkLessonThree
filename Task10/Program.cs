using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
   /* Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Напишите программу расчета начисления премий сотрудникам.
   Премии рассчитываются согласно выслуге лет. Если выслуга до 5 лет, премия составляет 10% от заработной платы.Если выслуга от 
   5 лет (включительно) до 10 лет, премия составляет 15% от заработной платы.Если выслуга от 10 лет (включительно) до 15 лет, 
   премия составляет 25% от заработной платы.Если выслуга от 15 лет (включительно) до 20 лет, премия составляет 35% от заработной
   платы.Если выслуга от 20 лет (включительно) до 25 лет, премия составляет 45% от заработной платы.Если выслуга от 25 лет 
   (включительно) и более, премия составляет 50% от заработной платы.Результаты расчета, выведите на экран.
   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your salary: ");
            double salary = double.Parse(Console.ReadLine());
            
            

            Console.Write("Enter your length of service to calculate the bonus: ");
            double serviceLength = double.Parse(Console.ReadLine());

            if (serviceLength > 0 && serviceLength < 5)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}", salary*0.1,salary*0.1+salary);
            }else if(serviceLength > 4 && serviceLength < 10)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}",salary*0.15,salary*0.15+salary);
            }else if(serviceLength > 9 && serviceLength < 15)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}",salary*0.25,salary*0.25+salary);
            }else if(serviceLength > 14 && serviceLength < 20)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}",salary*0.35,salary*0.35+salary);
            }else if(serviceLength > 19 && serviceLength < 25)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}",salary*0.45,salary*0.45+salary);
            }else if (serviceLength >= 25)
            {
                Console.WriteLine("Your bonus = {0}, you are charged - {1}",salary*0.5,salary*0.5+salary);
            }
            else
            {
                Console.WriteLine("Enter some positive number for length of service");
            }

            Console.ReadLine();
        }
    }
}
