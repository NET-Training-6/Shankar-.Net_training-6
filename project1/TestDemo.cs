using System;

class TestDemo
{

    public static void Test()
    {

        Console.Write("Enter an number:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 3 == 0 && x % 5 == 0)
        {
            Console.WriteLine($"{x} multiple of 3 and 5");


        }

        else
        {

            if (x % 3 == 0)
            {

                Console.WriteLine($"{x} is only multiple of 3");
            }
            else if (x % 5 == 0)
            {

                Console.WriteLine($"{x} is only multiple of 5");
            }

            else
            {
                Console.WriteLine($"{x} is not multiple of 5 and 3");
            }
        }
        /* if ((x % 3 == 0 )&& (x % 5 == 0))
         {

             Console.WriteLine("The number" + x + "is multiple of 3 and 5");
         }

         else
         {
             Console.WriteLine("The number" + x + "is not  multiple of 3 and 5");
         }
     */
        //Console.BackgroundColor = ConsoleColor.Magenta;
        //  string result = ((x % 3 == 0) && (x % 5 == 0)) ? "The number" + x + "is multiple of 3 and 5" : "The number " + x + " is not  multiple of 3 and 5";

        //Console.WriteLine(result);
    }


}