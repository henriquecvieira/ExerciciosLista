using System;

namespace _18CelsiusFahrenheit  
{
    public class CelsiusFahrenheit  
    {
        public double Celsius;

        public double calculoCelsiusParaFahrenheit()
        {
            return  Celsius * 1.8 + (32);
        }  
        
        public void message()
        {
            double temperaturaConvertida = calculoCelsiusParaFahrenheit();
            Console.WriteLine($"A temperatura convertida é: {temperaturaConvertida.ToString("N2")}°F");                   
        }
    }
}