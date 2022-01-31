using System;


namespace _07BodyWeight
{
    class Program
    {
        public static void Main(string [] args)
        {
            
           double currentWeight, pastWeight;

            Console.WriteLine("report your past weight");
            pastWeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("report your current weight");
            currentWeight = Convert.ToDouble(Console.ReadLine());

            void DisplayWeightReport()
            {
                if(currentWeight > pastWeight+(pastWeight*(15/100)))
                {
                    Console.WriteLine("seu peso é de 15% ou mais o que na última medição");
                }  
                else if(currentWeight < pastWeight-(pastWeight*(20/100)))
                {
                    Console.WriteLine("seu peso é de 20% ou mais menos desde a última medição");
                }
                else
                {
                    Console.WriteLine("seu peso está joinha");
                }
            }  
            DisplayWeightReport();
            

        }            
        
    }

}