using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Используя Visual Studio, создайте проект по шаблону Console Application.
    Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества купленного товара.
    Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов от общей суммы, если же количество 
    больше 3 и меньше 7, то 20процентов от общей суммы, иначе, если больше 7 то 25 процентов от общей суммы. 
    Цену товара и купленное количество товара пользователь должен задавать вводом с консоли.         
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the quantity of purchased goods: ");
            int goodsQuantity = int.Parse(Console.ReadLine());

            
            double price = 100;
            double discount = 0;

            if (goodsQuantity > 0 && goodsQuantity < 3)
            {
                discount = price * 0.1;
               Console.WriteLine("You have 10% discount, {0} hrn to pay",price-discount);
            }else if(goodsQuantity >2 && goodsQuantity < 7)
            {
                discount = price * 0.2;
                Console.WriteLine("You have 20% discount, {0} hrn to pay",price-discount);
            }else if (goodsQuantity >= 7)
            {
                discount = price * 0.25;
                Console.WriteLine("You have 25% discount, {0} hrn to pay",price-discount);
            }
            else
            {
                Console.WriteLine("Enter number > 0");
            }

            Console.ReadLine();
        }
    }
}
