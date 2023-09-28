//Largest Prime Factor

using System;

public class Problem03
{
    public static void Main(string[] args)
    {
        long Divisor = 1, Quotient = 0;
        const long Dividend = 600851475143;

        while(Divisor <= Dividend)
        {
            if(Dividend % Divisor == 0)
            {
                Quotient = Dividend % Divisor;
            }
            Divisor = Divisor + 1;
        }

        Console.WriteLine("Largest prime factor : {0}", Quotient);
    }
}