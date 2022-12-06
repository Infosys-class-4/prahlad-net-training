// LINQ = Language Integrated Query
// powerful feature to query collections

using System;
using System.Collections.Generic;
using System.Linq;
using LivingThings;

class LINQ
{
    public void Test()
    {
        byte[] numbers = { 23, 45, 11, 22, 33, 12, 90, 98, 87, 65, 55 };

        // Filtering
        // Get all even numbers
        var evenNumbersWithLinq = numbers.Where(number => number % 2 == 0);

        // CW: Get all odd numbers
        // CW: Get all numbers less than 50
        // CW: Get all odd numbers which are less than 50        
        var oddNumbersLessThan50 = numbers.Where(x => x < 50 && x % 2 == 1);
        PrintOutput(oddNumbersLessThan50, "oddNumbersLessThan50");

        string[] names = { "Arun", "Barun", "Chet", "Anil", "Bishwo" };

        //Get all names which starts with letter B
        var namesStartingB = names.Where(x => x.StartsWith("B"));
        PrintOutput(namesStartingB, "namesStartingB");

        // Projections
        // Get squares of each element in "numbers" array
        var squares = numbers.Select(x => x * x);
        PrintOutput(squares, "squares");

    }

    public void PrintOutput<T>(IEnumerable<T> items, string displayText)
    {
        Console.WriteLine($"Printing {displayText}");
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }

    public void Assignment()
    {
        byte[] numbers = { 23, 45, 11, 21, 33, 12, 90, 98, 87, 65, 55, 99, 234, 76, 10, 82 };

        // square of numbers grater than 70.

        //METHOD Syntax
        var squareOfNumbersGreaterThan70 = numbers.Where(x => x > 70).Select(y => y * y);
        PrintOutput(squareOfNumbersGreaterThan70, "squareOfNumbersGreaterThan70");

        //EXPRESSION Syntax
        squareOfNumbersGreaterThan70 = from x in numbers where x > 70 select x * x;

        // Square root of numbers which are multiple of 3

        //METHOD Syntax
        var squareRootOfNumbersWhichAreMultipleOf3 = numbers.Where(x => x % 3 == 0).Select(y => Math.Sqrt(y));
        PrintOutput(squareRootOfNumbersWhichAreMultipleOf3, "squareRootOfNumbersWhichAreMultipleOf3");

        //EXPRESSION Syntax
        squareRootOfNumbersWhichAreMultipleOf3 = from x in numbers
                                                 where x % 3 == 0
                                                 select Math.Sqrt(x);

        // Check if any of the number is multiple of 7 on numbers
        var multipleOf7 = numbers.Where(x => x % 7 == 0).Count() > 1;

        // any return bool
        var multipleOf7withany = numbers.Any(x => x % 7 == 0);



        // Check if all the numbers in "numbers" are multiple of 7
        // all
        var multipleOf7withall = numbers.All(x => x % 7 == 0);



        // Print first 5 items from Numbers
        var first5 = numbers.Take(5);
        // foreach(var item in first5)
        // {
        //     Console.WriteLine(item);
        // }


        // Skip first 5 and get next five
        var skip2AndGetNext5 = numbers.Skip(2).Take(5);


        Person p1 = new Person();
        p1.age = 23;

        Person p2 = new Person();
        p2.age = 32;

        Person p3 = new Person();
        p3.age = 33;

        Person p4 = new Person();
        p4.age = 20;

        Person p5 = new Person();
        p5.age = 26;

        Person p6 = new Person();
        p6.age = 12;

        Person[] people = { p1, p2, p3, p4, p5, p6 };

        // Get all people who are adult now
        var adults = people.Where(x => x.age > 18);


        // Create list/array of animals using Animal class we wrote.
        // Query that collection to find following:
        // Get list of all domestic animals
        // Get list of animals which has more than 4 legs

        Animal a1 = new Animal();
        Animal a2 = new Animal();
        Animal a3 = new Animal();
        Animal a4 = new Animal();
        Animal a5 = new Animal();

        Animal[] animal = { a1, a2, a3, a4, a5 };

        var isDomestic = animal.Where(x => x.domestic == true);

        var hasMoreThan4Legs = animal.Where(x => x.numberOfLegs > 4);






    }
}
