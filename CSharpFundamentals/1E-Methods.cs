class Methods
{
    public void Print()
    {
        Console.WriteLine("I am a simple method");
    }
    // Returns nothing, takes some arguments

    public void PrintSomething(string message)
    {
        Console.WriteLine(message);
    }
    // Returns something, takes some arguments

    public double Add(double num1, double num2, double num3 = 0) // num3 is optional when num3=0
    {
        var sum = num1 + num2 + num3;
        return sum;
    }
    public double AddNumbers(double num1, double num2, double num3 = 0) => num1 + num2 + num3; // => goes to operator


    public int Multiply(params int[] numbers)  // params is used to define infinite arguments
    {
        var product = 1;
        foreach (var num in numbers)
        {
            product = product * num;   //product *= num;
        }
        return product;
    }

    //returns multiple values, takes some argument

    public (byte, byte) GetMinMax(byte[] nums)
    {
        byte min = byte.MaxValue, max = byte.MinValue;
        foreach (byte num in nums)
        {
            if (num < min)
            {
                min = num;
            }

            if (num > max)
            {
                max = num;
            }

        }
        return (min, max); // it is calles tuples
    }

    // ClassWork
    // Write a method which returns average of all 4 numbers supplied as a parameter

    public double Average(short n1, short n2, short n3, short n4)
    {
        double total = n1 + n2 + n3 + n4;
        double average = total / 4;
        return average;   
        
    }

    // CW: Modify this method to take array of numbers and calculate average of all.

    // public double CalculateArrayAverage(double[] numbers)
    // {
    //     double total = 0;
    //     foreach(double n in numbers)
    //     {
    //         total = total + n;
    //     }
    //     double average = total / numbers.Length;
    //     return average;
    // }

    // CW: Modify same method to return average and minimum of all.
    public (double,double) CalculateAverageAndMinimun(double[] numbers)
    {
        double min = double.MaxValue;
        double total = 0;
        foreach(double n in numbers)
        {
            total = total + n;
            if(n < min)
            {
                min = n;
            }
        }
        double average = total / numbers.Length;
        return (average,min); 
        
        
    }
}