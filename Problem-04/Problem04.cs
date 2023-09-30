//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        int ReversedNumber = 0;

        for(int NumberOne = 10; NumberOne < 20; NumberOne++)
        {
            for(int NumberTwo = 10; NumberTwo < 20; NumberTwo++)
            {
                int MultipliedNumber = NumberOne * NumberTwo;
                int Dividend = MultipliedNumber;
                //Console.WriteLine(Number);
                //Console.WriteLine("{0} x {1} = {2}", NumberOne, NumberTwo, Dividend);

                while(Dividend != 0)
                {
                    int Remainder = Dividend % 10;
                    //Console.WriteLine(Remainder);

                    ReversedNumber = ReversedNumber * 10 + Remainder;
                    //Console.WriteLine(ReversedNumber);

                    Dividend = Dividend / 10;
                    Console.WriteLine(Dividend);
                }

                //Console.WriteLine(ReversedNumber);

                if(MultipliedNumber == ReversedNumber)
                {
                    Console.WriteLine(MultipliedNumber);
                }

                //NumberTwo++;
            }

            //NumberOne++;
        }

        //Console.WriteLine(ReversedNumber);
    }
}