using System;

namespace _03Div
{
    class Program
    {
        static void Main(string[] args)
        {
           CalculationDiscountTenPercent c = new CalculationDiscountTenPercent();

           Console.WriteLine("informe o preço");
           c.price = Convert.ToDouble(Console.ReadLine());
           
           Console.WriteLine("informe o valor do desconto");
           c.discount = Convert.ToDouble(Console.ReadLine());
           c.calculationDiscount();
           c.messagePriceWithDiscount();
        }
    }


}
