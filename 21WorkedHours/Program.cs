

namespace _21WorkedHours
{
    class Program
    {
        public static void Main(string[] args)
        {
           WorkedHours wk = new WorkedHours();


            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            wk.horasTrabalhadas = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário mínimo");
            wk.salarioMinimo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o quantidade de horas extras trabalhadas");
            wk.horasExtras = Convert.ToDouble(Console.ReadLine());
                     


            wk.calculoValorHoraTrabalhada();
            wk.calculoValorHoraExtra();
            wk.calculoValorSalarioBruto();
            wk.calculovalorAReceberHoraExtra();
            wk.calculoSalarioTotal();
            wk.message();
        }
    }
}    