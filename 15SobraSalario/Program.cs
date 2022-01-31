using System;

namespace _15SobraSalario
{
    class Program
    {
        public static void Main(string [] args)
        {
            SobraSalario s = new SobraSalario();

            Console.WriteLine("Digite o seu nome");
            s.nome = Console.ReadLine();
            Console.WriteLine("Digite o valor do seu salário");
            s.salario  = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta 1");
            s.conta1  = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine("Digite o valor da conta 2");
            s.conta2  = Convert.ToDouble(Console.ReadLine());


            s.calculoJurosConta1();
            s.calculoJurosConta2();
            s.calculoSobraSalario();
            s.message();
            


        }
    }
}