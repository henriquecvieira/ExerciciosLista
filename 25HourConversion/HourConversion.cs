using System;

namespace _25HourConversion
{
    public class HourConversion
    {
       public int hour, minute;

       public int hourMinuteConversion()
       {
           return hour * 60;
       }
       public int minuteSecondConversion()
       {
           return minute * 60;
       }
       public void message()
       {
           int h = hourMinuteConversion();
           Console.WriteLine($" {h} convertido para minutos é: {h}");
           int m = minuteSecondConversion();
           Console.WriteLine($" {m} convertido para minutos é: {m}");
       }
    }
}