//Even Fibonacci Numbers

using System;

public class Problem02
{
    public static void Main(string[] args)
    {
        int PreviousNumber = 0, CurrentNumber = 1, NextNumber = 0, TotalOfEvenNumbers = 0;
        
        while(CurrentNumber < 4000000)
        {
            NextNumber = PreviousNumber + CurrentNumber;
            PreviousNumber = CurrentNumber;
            CurrentNumber = NextNumber;

            if(NextNumber % 2 == 0)
            {
                TotalOfEvenNumbers = TotalOfEvenNumbers + NextNumber;
            }
        }

        Console.WriteLine("Total of even numbers : {0}", TotalOfEvenNumbers);
    }
}