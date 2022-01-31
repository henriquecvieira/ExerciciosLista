using System;

namespace _20MedidaEscada
{
    public class MedidaEscada
    {
        public double caAdj, angulo;

        public double calculoCosseno()
        {
            return Math.Cos(angulo * (Math.PI / 180)); 
        }  
        
        public double calculoHipotenusa()
        {
            return caAdj / calculoCosseno();
        }  
        
        public void message()
        {
            double cosseno = calculoCosseno();
            Console.WriteLine($"O valor do cosseno do angulo apresentado é: {cosseno.ToString("F")}°");
            double hipotenusa = calculoHipotenusa();
            Console.WriteLine($"A medida da escada é: {hipotenusa.ToString("F")} metros");                   
        }
    }
}
    
