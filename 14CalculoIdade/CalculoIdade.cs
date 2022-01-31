using System;

namespace _14CalculoIdade
{
    class CalculoIdade
    {
        public string? nome = null;
        public int anoNascimento, anoAtual;
        
        public int calculoIdadeAnos() 
        {
            return  anoAtual - anoNascimento;             
        }
        public int calculoIdadeMeses() 
        {
             return  12 * calculoIdadeAnos();
        }
        public int calculoIdadeSemanas()
        {
            return 4 * calculoIdadeMeses();
        }
        public int calculoIdadeDias()
        {
            return 365 * calculoIdadeAnos();
        }
        public void message()
        {
            int anos = calculoIdadeAnos();
            int meses = calculoIdadeMeses();
            int semanas = calculoIdadeSemanas();
            int dias = calculoIdadeDias();
            Console.WriteLine($"{nome} voce tem {anos} anos, equivalente a {meses} meses, {semanas} semanas e {dias} dias de vida");

        }

    }
    
}

