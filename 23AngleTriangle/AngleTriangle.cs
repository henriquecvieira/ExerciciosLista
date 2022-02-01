using System;

namespace _23AngleTriangle
{
    public class AngleTriangle
    {
        public double angle1, angle2;

        public double computAngle()
        {
            return 180 - (angle1 + angle2);
        }
        public void messagecomputAngle()
        {
            double comput = computAngle();
            Console.WriteLine($"o valor do angulo restante é: {comput}°");
        }        
    }
}