//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        double MultipliedNumber = 0, LargestPalindromeNumber = 0, ReversedNumber = 0;

        for(int i = 100; i < 1000; i++)
        {
            for(int j = 100; j < 1000; j++)
            {
                MultipliedNumber = i * j;

                //Reverse the multiplied numbers
                for(int k = 4; k >= 1; k--)
                {
                    //Get the quotient of the multiplied numbers
                    double Quotient = Math.Floor(MultipliedNumber / Math.Pow(10, k-1));

                    //Get the remainder of the multiplied numbers
                    double Remainder = MultipliedNumber % Math.Pow(10, k-1);

                    //Console.WriteLine(Quotient);
                    //Console.WriteLine(Remainder);

                    ReversedNumber = ReversedNumber + Quotient * Math.Pow(10, k);

                    MultipliedNumber = Remainder;
                }

                if(ReversedNumber == MultipliedNumber)
                {
                    LargestPalindromeNumber = MultipliedNumber;
                }
            }
        }

        Console.WriteLine(LargestPalindromeNumber);
    }
}