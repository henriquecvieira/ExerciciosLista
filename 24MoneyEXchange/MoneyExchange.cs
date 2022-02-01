using System;

namespace _24MoneyEXchange
{
    public class MoneyExchange
    {
       public double reais;

       public double exchangeReaisDolar()
       {
           return   reais / 5.27;
       }         
       public double exchangeReaisMarcoAlemão()
       {
           return  reais / 3.6;
       }         
       public double exchangeReaisLibraEsterlina()
       {
           return   reais / 7.12;
       }  
       public void messageExchange()
       {
           double Dolar = exchangeReaisDolar();
           Console.WriteLine($"O valor em {reais} convertido para dolar é {Dolar.ToString("C")}");
           double Marco = exchangeReaisMarcoAlemão();
           Console.WriteLine($"O valor em {reais} convertido para marco alemão é {Marco.ToString("C")}");
           double Libra = exchangeReaisLibraEsterlina();
           Console.WriteLine($"O valor em {reais} convertido para libra esterlina é {Libra.ToString("C")}");
       }
    }
}