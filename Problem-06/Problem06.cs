//Sum Square Difference

using System;

public class Problem06
{
    public static void Main(string[] args)
    {
        double SquareSum = 0, Sum = 0;

        for(int i = 1; i < 101; i++)
        {
            SquareSum = SquareSum + Math.Pow(i, 2);
            Sum = Sum + i;
        }

        double Subtraction = Math.Pow(Sum, 2) - SquareSum;
        Console.WriteLine(Subtraction);
    }
}