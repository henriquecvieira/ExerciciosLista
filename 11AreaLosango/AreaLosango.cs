using System;

namespace _11AreaLosango
{
    public class AreaLosango
    {
        public double ladoMaior, ladoMenor;        

        public double calculoAreaLosango()
        {
            return (ladoMaior*ladoMenor)/2;
        }

        public void messageCalculoAreaLosango()
        {
            double areaLosangoCalculada = calculoAreaLosango();
            Console.WriteLine("A área do trapézio: " +areaLosangoCalculada.ToString("F") + "cm²");
        }
    }
    
}