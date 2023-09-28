//Largest Prime Factor

using System;

public class Problem03
{
    public static void Main(string[] args)
    {
        int Dividend = 600851475143, Dividend, LargestPrimeFactor;

        for(int Divisor = 2, Dividend = 600851475143; Divident != 1; Divisor = Divisor = Divisor + 1)
        {
            if(Dividend % Divisor == 0)
            {
                Dividend = Dividend / Divisor;
                LargestPrimeFactor = Divisor;
            }
        }

        Console.WriteLine(LargestPrimeFactor);
    }
}