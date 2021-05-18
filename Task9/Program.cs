using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    /*Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Напишите программу русско-английский переводчик.
    Программа знает 10 слов о погоде.Требуется, чтобы пользователь вводил слово на русском языке, а программа давала ему перевод 
    этого слова на английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует вывести сообщение, 
    что такого слова нет. 
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВести слово-опис погоди для перекладу на англійську: ");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "Сонячна":
                    Console.WriteLine("Sunny");
                    break;
                case "Дощова":
                    Console.WriteLine("Rainy");
                    break;
                case "Морозна":
                    Console.WriteLine("Frosty");
                    break;

                case "Похмура":
                    Console.WriteLine("Gloomy");
                    break;
                case "Спекотна":
                    Console.WriteLine("Hot");
                    break;
                case "Град":
                    Console.WriteLine("Hail");
                    break;
                case "Ожеледиця":
                    Console.WriteLine("Ice");
                    break;
                case "Гроза":
                    Console.WriteLine("Thunderstorm");
                    break;
                case "Ураган":
                    Console.WriteLine("Hurricane");
                    break;
                case "Злива":
                    Console.WriteLine("Heavy rain");
                    break;
                default: Console.WriteLine("program does not contain such word for translation");
                    break;
    
            }

            Console.ReadLine();
        }
    }
}
