

namespace _21WorkedHours
{
    public class WorkedHours
    {
        public double  salarioMinimo, horasExtras, horasTrabalhadas;

        public double calculoValorHoraTrabalhada()
        {
            return salarioMinimo / 8; 
        }  
    
        public double calculoValorHoraExtra()
        {
            return salarioMinimo / 4;
        }  
        public double calculoValorSalarioBruto()
        {
            return  horasTrabalhadas * calculoValorHoraTrabalhada();
        }  
        
         public double calculovalorAReceberHoraExtra()
        {
            return horasExtras * calculoValorHoraExtra();
        }  



        public double calculoSalarioTotal()
        {         

            return  calculoValorSalarioBruto() + calculovalorAReceberHoraExtra();
        }


        public void message()
        {
            double ValorHoraTrabalhada = calculoValorHoraTrabalhada();
            Console.WriteLine($"O valor da hora trabalhada é: {ValorHoraTrabalhada.ToString("C")}");

            double ValorHoraExtra = calculoValorHoraExtra();
            Console.WriteLine($"o valor da hora extra é: {ValorHoraExtra.ToString("C")}");  

            double ValorSalarioBruto = calculoValorSalarioBruto();
            Console.WriteLine($"o valor do salário bruto é: {ValorSalarioBruto.ToString("C")}"); 

            double valorAReceberHoraExtra = calculovalorAReceberHoraExtra();
            Console.WriteLine($"o valor das horas extra a receber é: {valorAReceberHoraExtra.ToString("C")}");  

            double SalarioTotal = calculoSalarioTotal();
            Console.WriteLine($"O salário bruto mais as horas extras, contabilizam: {SalarioTotal.ToString("C")}");   
                          
        }
    }
}
    
