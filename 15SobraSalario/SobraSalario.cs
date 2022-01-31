using System;

namespace _15SobraSalario
{
    class SobraSalario
    {
        public double salario, conta1, conta2;
        public string? nome = null;
    

        public double calculoJurosConta1()
        {
            return conta1 + (conta1 * 2 /(100));
        }
        public double calculoJurosConta2()
        {
            return conta2 + (conta2 * 2 /(100));
        }
        public double calculoSobraSalario()
        {
            return salario - (calculoJurosConta1() + calculoJurosConta2());
        }
        public void message()
        {
            double despesa1 =  calculoJurosConta1();
            double despesa2 =  calculoJurosConta2();
            double sobra = calculoSobraSalario();

            Console.WriteLine($"Senhor(a) {nome} \n o valor da conta 01 é: {despesa1.ToString("C")}");
            Console.WriteLine($"o valor da conta 02 é: {despesa2.ToString("C")}");
            Console.WriteLine($"sobrará do seu salário: {sobra.ToString("C")}");
        }



    }

    
}