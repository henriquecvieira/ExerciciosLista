using System;

namespace _16Hipotenusa
{
    public class Hipotenusa
    {
        public double catetoAdj, catetoOp;

        public double calculoHipotenusa()
        {
            return Math.Sqrt((catetoAdj*catetoAdj)+(catetoOp*catetoOp));
        }      
        public void message()
        {
            double hipo = calculoHipotenusa();
            Console.WriteLine($"O valor da Hipotenusa em centimetros é: {hipo.ToString("N3")}cm");
            
        }
    }
}