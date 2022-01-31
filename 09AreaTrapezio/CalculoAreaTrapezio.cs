namespace _09AreaTrapezio
{
    public class CalculoAreaTrapezio
    {
        public double baseMaior, baseMenor;

        public double calculoAreaTrapezio()
        {
            return ((baseMaior*baseMenor)/2);
        }

        public void messageCalculoAreaTrapezio()
        {
            double areaCalculada = calculoAreaTrapezio();
            Console.WriteLine($"A área do trapézio é: {areaCalculada}cm²");
        }
           
    }
}