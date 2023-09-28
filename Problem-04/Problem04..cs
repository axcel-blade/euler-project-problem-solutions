//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        int MultipledNumber = 0, ReversedNumber = 0, Quotient = 0, Remainder = 0;

        for(int i = 100; i < 1000; i++)
        {
            for(int j = 100; j < 100; j++)
            {
                MultipledNumber = i * j

                for(int k = 4; k >= 1; k--)
                {
                    Quotient = MultipledNumber / 10 ** (k-1)
                    Remainder = MultipledNumber % 10**(k-1)

                    ReversedNumber = ReversedNumber * (10 ** k) + Quotient
                }
            }
        }
    }
}