using System;

    class Multiply
    {              
        public double m1, m2, m3;    

        public double calculoM()
        {
           return m1 * m2 * m3;
        }  
        public void messageM()
        {
          double multiplica = calculoM();

         Console.WriteLine($"o resultado da multiplicação é: {multiplica}");
        }

    }

