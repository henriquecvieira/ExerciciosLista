using System;

namespace _17AreaEsfera
{
    public class AreaEsfera
    {
        public double raio;

        public double calculoCircunferencia()
        {
            return  Math.PI * raio * 2;
        }  
        public double calculoAreaEsfera()
        {
            return Math.PI * (raio * raio);
        }
        public double calculoVolumeEsfera()
        {
            return(4 * Math.PI * (Math.Pow(raio, 3)))/3;
        }
        public void message()
        {
            double circunferencia = calculoCircunferencia();
            Console.WriteLine($"A circunferência da efera mede: {circunferencia.ToString("N2")}cm");
        
            double areaEsfera = calculoAreaEsfera();
            Console.WriteLine($"A área da efera mede: {areaEsfera.ToString("N2")}cm²");
        
            double volumeEsfera = calculoVolumeEsfera();
            Console.WriteLine($"O volume da esfera mede: {volumeEsfera.ToString("N2")}cm³");
        }
    }
}