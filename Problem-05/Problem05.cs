//Smallest Multiple

using System;

public class Problem05
{
    public static void Main(string[] args)
    {
        int Number = 1;

        while(Number > 0)
        {
            int Count = 0;

            for(int i = 1; i < 21; i++)
            {
                if(Number % i == 0)
                {
                    Count++;

                    if(Count == 20)
                    {
                        Console.WriteLine("Smallest Multiple is {0}", Number);
                        Number = -2;
                    }
                }
            }

            Number++;
        }
    }
}