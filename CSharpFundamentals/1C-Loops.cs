using System;

public class Loops
{
    public void LearnLoops()
    {
        //  for (int i = 1; i <= 4; i = i + 3)
        // {

        //    for (int j = i; j <= (i+2); j++)
        //    {
        //       Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        // }
        /////////////

        //1 2  3  4
        //5 6  7  8
        //9 10 11 12

        // for (int i = 1; i <= 9; i = i + 4)
        // {
        //    for (int j = i; j <= (i+3); j++)
        //    {
        //       Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //    ///
        // }

        // ClassWork = Declare a number array with atleast 10 items, print squares of each in console

        // int[] numbers = {1,2,3,4,5,6,7,8,9,10};
        // // for (int i = 0; i < numbers.Length; i++) 
        // // {

        // //    Console.Write((numbers[i] * numbers[i]) + "\t");

        // // }

        // foreach(var num in numbers)
        // {
        //    Console.Write((num + " * " + num + " = ") + (num*num));
        //    Console.WriteLine();
        // }

        // Print numtiplication table for 8
        // for (int i = 8; i < 9; i++ )
        // {
        //    for (int j = 1; j <= 10; j++)
        //    {
        //       Console.WriteLine(i + " * " + j + " = " + (i*j) );
        //    }

        // }
        int number = 10;
        for (int n = 1; n < 10; n++)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = number;
                for (int j = 1; j <= 10; j++)
                {
                    int product = num * i;
                    Console.Write(num + "*" + i + "=" + product + " ");
                    num++;
                }
                Console.WriteLine();
            }
            number = number + 10;
        }

        // int num1 = 20;
        // for(int z = 1; z <=10 ; z++)
        // {
        //    Console.Write(num1 + "*" + i + "=" + product + " ");
        //    int product = num1 * i;
        //    num1 ++;    




        // }
        // Console.WriteLine();

    }
}