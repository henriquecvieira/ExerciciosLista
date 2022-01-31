using System;

namespace _12QuantosSalarios
{
    public class QuantosSalarios
    {
        public double salarioMinimo = 1212;    
        public double salarioFuncionario;  
        public string? nome = null!;           

        public double calculoQuantosSalariosMinimos()
        {
            return salarioFuncionario/salarioMinimo;
        }

     
        public void messageQuantosSalariosMinimos()
        {
            double calculoSalario = calculoQuantosSalariosMinimos();
            Console.WriteLine($"o funcionário {nome} recebe {calculoSalario.ToString("F")} salários minímos");
        }


    }
}