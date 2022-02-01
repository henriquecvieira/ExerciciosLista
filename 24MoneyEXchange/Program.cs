using System;

namespace _24MoneyEXchange
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyExchange me = new MoneyExchange();

            Console.WriteLine("Digite o valor em reais");
            me.reais = Convert.ToDouble(Console.ReadLine());

            me.exchangeReaisDolar();
            me.exchangeReaisMarcoAlemão();
            me.exchangeReaisLibraEsterlina();
            me.messageExchange();
        }
    }
}