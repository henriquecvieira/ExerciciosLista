namespace _08KilosEmGramas
{
    public class KilosEmGramas
    {
        public double K;

        public double conversionKG()
        {
            return K*1000;
        }

        public void messageConversion()
        {
            
            double conversion = conversionKG();
            Console.WriteLine($"O valor {K} convertido de quilo para gramas é:  {conversion}g");
        }
    }
}