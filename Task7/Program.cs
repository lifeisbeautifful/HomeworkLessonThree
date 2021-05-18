using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.Напишите программу - консольный калькулятор. 
    Создайте две переменные с именами operand1 и operand2. Задайте переменным некоторые произвольные значения.
    Предложите пользователю ввести знак арифметической операции. Примите значение введенное пользователем и поместите его 
    в строковую переменную sign.Для организации выбора алгоритма вычислительного процесса, используйте переключатель switch. 
    Выведите на экран результат выполнения арифметической операции.В случае использования операции деления, организуйте проверку 
    попытки деления на ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об ошибке пользователя.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first operand: ");
            double operand1 = double.Parse(Console.ReadLine());

            Console.Write("Enter second operand: ");
            double operand2 = double.Parse(Console.ReadLine());
           
            Console.WriteLine("Select an arithmetic operation(+, -, *, /, %): ");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    Console.WriteLine("{0} + {1} = {2}",operand1,operand2,Math.Round(operand1 + operand2));
                    break;
                case "-":
                    Console.WriteLine("{0} - {1} = {2}",operand1,operand2,Math.Round(operand1-operand2));
                    break;
                case "*":
                    Console.WriteLine("{0} * {1} = {2}",operand1,operand2,Math.Round(operand1*operand2));
                    break;
                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error, you are trying divide by zero!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2}",operand1,operand2,Math.Round(operand1 / operand2));
                        break;
                    }
                case "%":
                    Console.WriteLine("The remainder of the division {0} by {1} = {2}",operand1,operand2,Math.Round(operand1 %operand2));
                    break;
                default: Console.WriteLine("It is not an arithmetic operator");
                    break;
            }

            Console.ReadLine();
        }
    }
}
