//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        //int ReversedNumber = 0;
        int LargestPalindromeProduct = 0;

        for(int NumberOne = 100; NumberOne < 1000; NumberOne++)
        {
            for(int NumberTwo = 100; NumberTwo < 1000; NumberTwo++)
            {
                int ReversedNumber = 0;
                int MultipliedNumber = NumberOne * NumberTwo;
                int Dividend = MultipliedNumber;
                //Console.WriteLine(Number);
                //Console.WriteLine("{0} x {1} = {2}", NumberOne, NumberTwo, Dividend);

                while(Dividend != 0)
                {
                    int Remainder = Dividend % 10;
                    //Console.WriteLine("Remainder: {0}", Remainder);

                    ReversedNumber = (ReversedNumber * 10) + Remainder;
                    //Console.WriteLine(ReversedNumber);

                    Dividend/=10;
                    //Console.WriteLine("Dividend : {0}", Dividend);
                }

                //Console.WriteLine("Reversed number : {0}", ReversedNumber);

                if(MultipliedNumber == ReversedNumber)
                {
                    //Console.WriteLine("{0} x {1} = Reverse of the {2} is {3}", NumberOne, NumberTwo, MultipliedNumber, ReversedNumber);
                    if(LargestPalindromeProduct < MultipliedNumber)
                    {
                        LargestPalindromeProduct = MultipliedNumber;
                    }
                }

                //NumberTwo++;
            }

            //NumberOne++;
        }

        Console.WriteLine("Largest Palindrome Product : {0}", LargestPalindromeProduct);
    }
}