//10001st Prime

using System;

public class Problem07
{
    public static void Main(string[] args)
    {
        int Number = 1, PrimeNumberCount = 0;

        while(PrimeNumberCount < 10002)
        {
            int Count = 0;

            for(int i = 1; i <= Number; i++)
            {
                if(Number % i == 0)
                {
                    Count++;
                    //int Remainder = Number % i;
                    //Console.WriteLine("{0} % {1} = {2}", Number, i, Remainder);
                }
            }

            if(Count == 2)
            {
                //Console.WriteLine("Prime number : {0}", Number);
                PrimeNumberCount++;
                //Console.WriteLine(PrimeNumberCount);

                if(PrimeNumberCount == 10001)
                {
                    Console.WriteLine("10001st prime number : {0}", Number);
                    break;
                }
            }

            Number++;
        }
    }
}