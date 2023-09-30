//Largest Palindrome Product

using System;

public class Problem04
{
    public static void Main(string[] args)
    {
        int MultipliedNumber = 0, ReversedNumber = 0, Number = 0, Remainder = 0, NumberOne = 10, NumberTwo = 10;

        while(NumberOne < 91)
        {
            while(NumberTwo < 99)
            {
                MultipliedNumber = NumberOne * NumberTwo;
                Number = MultipliedNumber;
                //Console.WriteLine(Number);

                while(Number != 0)
                {
                    Remainder = Number % 10;
                    //Console.WriteLine(Remainder);

                    ReversedNumber = ReversedNumber * 10 + Remainder;
                    //Console.WriteLine(ReversedNumber);

                    Number = Number / 10;
                    //Console.WriteLine(Number);
                }

                if(MultipliedNumber == ReversedNumber)
                {
                    Console.WriteLine(MultipliedNumber);
                }

                NumberTwo = NumberTwo + 1;
            }

            NumberOne = NumberOne + 1;
        }

        Console.WriteLine(ReversedNumber);
    }
}