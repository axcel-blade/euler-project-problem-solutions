//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        long MultipliedNumber = 0, LargestPalindromeNumber = 0, ReversedNumber = 0;
        string ReversedNumberString = "";

        for(int i = 100; i < 1000; i++)
        {
            for(int j = 100; j < 1000; j++)
            {
                MultipliedNumber = i * j;
                string MultipliedNumberString = MultipliedNumber.ToString();
                //Console.WriteLine(MultipliedNumberString);
                //Console.WriteLine(MultipliedNumberString.Length);

                //Reverse the multiplied numbers
                for(int k = MultipliedNumberString.Length; k > 1; k--)
                {
                    //Get the quotient of the multiplied numbers
                    //double Quotient = Math.Floor(MultipliedNumber / Math.Pow(10, k-1));

                    //Get the remainder of the multiplied numbers
                    //double Remainder = MultipliedNumber % Math.Pow(10, k-1);

                    //Console.WriteLine(Quotient);
                    //Console.WriteLine(Remainder);

                    //ReversedNumber = ReversedNumber + (Quotient * Math.Pow(10, k-1));

                    //MultipliedNumber = Remainder;

                    ReversedNumberString = ReversedNumberString + MultipliedNumberString[k-1];
                    Console.WriteLine(ReversedNumberString);
                }

                ReversedNumber = Int64.Parse(ReversedNumberString);

                if(ReversedNumber == MultipliedNumber)
                {
                    LargestPalindromeNumber = MultipliedNumber;
                }
            }
        }

        Console.WriteLine(LargestPalindromeNumber);
    }
}