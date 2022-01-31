using System;

namespace _19LightPerMeter
{
    public class LightPerMeter
    {
        public double largura, comprimento;

        public double calculoAreaQauarto()
        {
            return largura * comprimento;
        }  
        
        public double calculoPotencia()
        {
            return 18 *calculoAreaQauarto();
        }  
        
        public void message()
        {
            double area = calculoAreaQauarto();
            Console.WriteLine($"A área do quarto corresponde a: {area.ToString("N2")}m²");
            double potencia = calculoPotencia();
            Console.WriteLine($"A potência necessária é de: {potencia.ToString("N2")}W");                   
        }
    }
}
    
