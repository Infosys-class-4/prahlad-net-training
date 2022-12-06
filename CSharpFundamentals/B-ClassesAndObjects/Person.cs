// C# is object oriented programming language

// Procedural: C, PASCAL, BASIC, Go
// Imperative: Go, C#, C, C++
// Declarative: Python
// Object Oriented: C#, Java, Python
// Funcational: F#, Scala, Haskell, C#
// Dynamic: JS, Ruby, Python
// Static: C#, Java

// C# is multi-paradigm language


class Person
{
    public string name;
    public byte age;
    public string GetLegalGreeting()
    {
        if (age < 18)
        {
            return "You are under age";
        }
        else
        {
            return "You are adult now";
        }
    }

}


// Assignment 2


class Cars
{
    public string name;
    public string color;
    public int cc;

    public string GetCarCc()
    {
        if (cc > 1000)
        {
            return "Damn!, you have great power";
        }
        else
        {
            return "Oops!, you dont have much power";

        }
    }
}



















