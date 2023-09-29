//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        int MultipliedNumber = 0, ReversedNumber = 0, Remainder = 0, Number = 0, LargestPalindromeProduct = 0;

        for(int i = 91; i < 99; i = i + 1)
        {
            for(int j = 91; j < 99; j = j + 1)
            {
                MultipliedNumber = i * j;
                Number = MultipliedNumber;

                while(Number != 0)
                {
                    Remainder = Number % 10;
                    ReversedNumber = ReversedNumber * 10 + Remainder;
                    Number = Number / 10;
                }

                if(MultipliedNumber == ReversedNumber)
                {
                    LargestPalindromeProduct = MultipliedNumber;
                    //Console.WriteLine(ReversedNumber);
                    Console.WriteLine(LargestPalindromeProduct);
                }
            }
        }

        //Console.WriteLine(LargestPalindromeProduct);
        //Console.WriteLine(ReversedNumber);
    }
}