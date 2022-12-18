using System;
class Test
{

    public static void Main()
    {
        Console.Write("Enter an amount:");
        int amt = int.Parse(Console.ReadLine());
        Console.Write("Enter a Time period:");
        int ti = int.Parse(Console.ReadLine());
        Console.Write("Enter interest interest:");
         int rate = int.Parse(Console.ReadLine());
        int si=amt*ti*rate/100;
        Console.WriteLine("The simple interest is="+si);
        

    }


}