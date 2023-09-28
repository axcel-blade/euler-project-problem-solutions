//Largest Prime Factor

using System;

public class Problem03
{
    public static void Main(string[] args)
    {
        long Dividend = 600851475143;
        int LargestPrimeFactor = 0;

        for(int Divisor = 2; Dividend != 1; Divisor++)
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