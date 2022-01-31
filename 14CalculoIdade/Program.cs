using System;

namespace _14CalculoIdade
{
    class Program
    {
        public static void Main(string [] args)
        {
            CalculoIdade idade = new CalculoIdade();

            Console.WriteLine("Digite o seu nome");
            idade.nome  = Console.ReadLine();
            Console.WriteLine("Digite o ano atual");
            idade.anoAtual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano que você nasceu");
            idade.anoNascimento = Convert.ToInt32(Console.ReadLine());


            idade.calculoIdadeAnos();
            idade.calculoIdadeMeses();
            idade.calculoIdadeSemanas();
            idade.calculoIdadeDias();
            idade.message();
        }
    }
}