using System;


namespace _06WageComission
{

    class Program
    {

        static void Main(string[] args)
        {         

        WageComission wg = new WageComission();

          
        Console.WriteLine("report your wage");
        wg.wage = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("report the comission value");
        wg.comission = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("report the sales value");
        wg.sales = Convert.ToDouble(Console.ReadLine());

        wg.ComissionCalculation();
        wg.WageMoreComission();
        wg.messageWageComission();
        }
    }

}