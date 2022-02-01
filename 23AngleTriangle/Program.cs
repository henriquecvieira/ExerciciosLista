using System;

namespace _23AngleTriangle
{
    class Program
    {
        public static void Main(string[] args)
        {
           AngleTriangle aT = new AngleTriangle();

            Console.WriteLine("Digite o valor do primeiro ângulo");
            aT.angle1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo ângulo");
            aT.angle2 = Convert.ToInt32(Console.ReadLine());

            aT.computAngle();
            aT.messagecomputAngle();
        }    
    }      
}      