using System;

class CalculationDiscountTenPercent
{
    public double price, discount;

    public double calculationDiscount()
    {
        return (price - (price/discount));
    }
    public void messagePriceWithDiscount()
       {
        double discountTenPercent = calculationDiscount();

        Console.WriteLine("preço com desconto  é :" + discountTenPercent.ToString("C"));
       }
   

}