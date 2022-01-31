using System;

class Difference
{ 
              
    public double d1, d2;       

    public double calculo()
    {
        return d1 - d2;
    }  
    public void mensagem()
    {
       double obterCalculo = calculo();

       Console.WriteLine($"a diferença entre o prmeiro e o segundo número é {obterCalculo}");
    }

}
