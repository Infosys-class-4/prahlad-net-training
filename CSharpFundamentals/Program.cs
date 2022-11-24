using System;

class Program
{
    public static void Main()
    {
        Methods m = new();
       // m.Print();
       // m.PrintSomething("Hello");
        var s = m.Add(1.1, 2.2, 3.3);
        var s1 = m.Add(1, 2);
        var multiply = m.Multiply(1, 2, 3, 10, 5, 2, 100);
        //Console.WriteLine($"Sum1 = {s} \t Sum2 = {s1} \t Product = {multiply}");

        //byte[] numbers = { 34, 56, 12, 33, 89, 65, 21, 90 };
        //var (minimun, maximum) = m.GetMinMax(numbers);
        //Console.WriteLine(maximum);

        var avg = m.Average(1,2,3,4);
        //Console.WriteLine(avg);

        // double[] numbers = {1.1, 25.3, 65, 22, 999, 1234};
        // double avgg = m.CalculateArrayAverage(numbers);
        // Console.WriteLine(avgg);

        double[] numbers = {0.1,1.1, 25.3, 65, 22, 999, 1234};
        var(average,minimum)=m.CalculateAverageAndMinimun(numbers);
        Console.WriteLine($"Average is: = {average}  Minimum is: = {minimum}");

        Person a = new();
        var name = a.Name("Prahlad", "Shakya");
        Console.WriteLine("Your Full Name is: " + name);

        var name1 = a.AddName("Ram","Hari");
        Console.WriteLine("Your Full Name is: " + name1);

        //string[] details = {"Prahlad", "Bhaisepati"};
        var (nam,address) = a.GetNameAddress("Prahlad","aa");
        Console.WriteLine("Your name is: " + nam + "   Your address is: " + address);
        







    }

}




