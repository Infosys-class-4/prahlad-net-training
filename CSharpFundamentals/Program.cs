// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//byte a = 255;

// DateTime now = DateTime.Now;
// Console.WriteLine(now);


// Task 1

// string name = "Prahlad";
// byte age = 21;
// string weight = "70kg";
// bool passport = true;
// string dob = "23rd october 2001";
// DateTime dob = new DateTime(2001,10,23);


// Task 2

// Console.WriteLine(name);
// Console.WriteLine(age);
// Console.WriteLine(weight);
// Console.WriteLine(passport);
// Console.WriteLine(dob);



// Person person1 = new();
// person1.name = "Sitaram";
// person1.age = 8;

// string message = person1.GetLegalGreeting();
// Console.WriteLine(message);



// Assignment 2

class Program
{
    public static void Main()
    {
        Cars car1 = new();
        car1.name = "Hyundai";
        car1.color = "Red";
        car1.cc = 1200;

        string message = car1.GetCarCc();
        Console.WriteLine(message);

    }
}



