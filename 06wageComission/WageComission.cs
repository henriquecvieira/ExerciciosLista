using System;

namespace _06WageComission
{
    class WageComission
    {
        public double wage, comission, sales;

        public double ComissionCalculation()
        {
            return (sales * (comission/100));        
        }

        public double WageMoreComission()
        {
            return wage + ComissionCalculation();
        }

       public void messageWageComission()
        {
            double wageCalculation = ComissionCalculation();

            Console.WriteLine("o valor das comissões é :" + wageCalculation.ToString("C"));

            double wageMoreComissionCalculation = WageMoreComission();
       
            Console.WriteLine("O valor do salário mais as comissões é: " + wageMoreComissionCalculation.ToString("C"));
        }
    }


}


    