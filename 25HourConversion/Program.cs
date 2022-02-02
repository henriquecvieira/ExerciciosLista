using System;

namespace _25HourConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            HourConversion hc = new HourConversion();

            Console.WriteLine("Digite a quantidade de horas");
            hc.hour =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite quantidade de minutos");
            hc.minute = Convert.ToInt32(Console.ReadLine());

        

            hc.hourMinuteConversion();
            hc.minuteSecondConversion();
            hc.message();
        }
    }
}