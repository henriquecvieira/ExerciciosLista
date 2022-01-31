using System;

namespace _12QuantosSalarios
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            QuantosSalarios salario = new QuantosSalarios();
                       
            Console.WriteLine("qual é o nome do funcionário?");            
            salario.nome = Console.ReadLine();
            
            Console.WriteLine("qual é o valor do salário do funcionário?");
            salario.salarioFuncionario = Convert.ToDouble(Console.ReadLine());

            salario.calculoQuantosSalariosMinimos();
            salario.messageQuantosSalariosMinimos();
        }

            
    }
}
