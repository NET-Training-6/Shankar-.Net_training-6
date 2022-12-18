using System;

class Test
{

    public static void Main()
    {
        Console.Write("Enter an number:");
        int x = Convert.ToInt32(Console.ReadLine());
        /* if ((x % 3 == 0 )&& (x % 5 == 0))
         {

             Console.WriteLine("The number" + x + "is multiple of 3 and 5");
         }

         else
         {
             Console.WriteLine("The number" + x + "is not  multiple of 3 and 5");
         }
     */

        String result = ((x % 3 == 0) && (x % 5 == 0)) ? "The number is multiple of 3 and 5" : "The number is not  multiple of 3 and 5";

        Console.WriteLine(result);
    }


}