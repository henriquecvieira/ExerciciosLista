using System;

namespace _22PoligonoConvexo
{
    public class PoligonoConvexo
    {
        public int n;
        public int calculoNumeroDiagonais()
        {
            return (n * (n  -3))/2;
        }
        public void messageNumeroDiagonais()
        {
            int diagonais = calculoNumeroDiagonais();
            Console.WriteLine($"O número de diagonais é: {diagonais}");
        }
    }
}