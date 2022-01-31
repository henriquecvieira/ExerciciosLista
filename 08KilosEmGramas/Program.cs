using System;


namespace _08KilosEmGramas
{
    class Program
    {
        public static void Main(string [] args)
        {     
            KilosEmGramas g = new KilosEmGramas();

            Console.WriteLine("infome o valor em kilos que quer converter para gramas");
            g.K = Convert.ToDouble(Console.ReadLine());

            g.conversionKG();
            g.messageConversion();
            
                  
        }
    }
}
