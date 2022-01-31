using System;

namespace _10AreaQuadrado
{
    public class AreaQuadrado
    {
        public double lado;

        public double calculoAreaQuadrado()
        {
            return lado*lado;        
        }
        
        public void messageCalculoAreaQuadrado()
        {
            double areaCalculada = calculoAreaQuadrado();
            Console.WriteLine($"A área do quadrado: {areaCalculada}cm²");
        }
    }
}