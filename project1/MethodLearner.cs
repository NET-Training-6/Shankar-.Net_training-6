class MethodLearner
{

    public bool EvenOdd(int x)
    {
        if (x % 2 == 0)
        {
            return true;


        }
        else
        {

            return false;
        }
        // return x %2== 0;
        //return (x & 1) == 0;

    }

    public double ArrayAsArguments(params int[] numbers)
    {
        var sum1 = 0;
        for (int i = 0; i < numbers.Length; i++)
        {

            sum1 = (sum1 + numbers[i]) / numbers.Length;
        }

        return sum1;
    }

    //Write a method that takes bunch of numbers and returns minimum among them;

    public int GetMinimum(params int[] numbers)
    {
        int min = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] < min)
            {
                min = numbers[i];

            }
        }
        return min;
    }

}

class DemoTest
{
    public static void Main1()
    {
        MethodLearner m1 = new MethodLearner();

        // int [] numbers={23,21,45,65,12};
        Console.WriteLine(m1.ArrayAsArguments(5,5));
        // Console.WriteLine(m1.GetMinimum(12, 23, 45,49));


    }


}
