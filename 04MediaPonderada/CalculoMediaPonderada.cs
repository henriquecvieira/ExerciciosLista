using System;

class MediaPonderada
{
    public double p1, p2, x1, x2;

    public double calculoMediaPonderada()
    {
        return ((p1*x1)+(p2*x2))/(p1+p2);
    }
    public void messageMediaPonderada()
       {
        double mediaP = calculoMediaPonderada();

        Console.WriteLine($"o resultado da média ponderada é : {mediaP}");
        Console.WriteLine("o resultado da média ponderada é :" + mediaP.ToString("N3"));
               
       }

}