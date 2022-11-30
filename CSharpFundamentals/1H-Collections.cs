class Collection
{
    public void LearnList()
    {
        string[] names = { "Bishnu", "Ram", "Tek" };

        List<string> nameList = new List<string> { "Bishnu", "Ram", "Tek" };


        //CW: Define list of 10 even numbers.

        List<int> evenNumbers = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };


        // stack and queue

        Stack<string> plates = new Stack<string>();   //LIFO
        plates.Push("Plate1");
        plates.Push("Plate2");
        plates.Push("Plate3");
        plates.Pop();
        
        foreach(var item in plates)
        {
           // Console.WriteLine(item);
        }

        Queue<string> plateKoLine = new Queue<string>();    //FIFO
        plateKoLine.Enqueue("Plate1");
        plateKoLine.Enqueue("Plate2");
        plateKoLine.Enqueue("Plate3");
        plateKoLine.Dequeue();

        foreach(var item in plateKoLine)
        {
            Console.WriteLine(item);
        }

 

    }

    public void LearnDictionary()
    {
        Dictionary<string, string> countryCapitals= new();
        countryCapitals.Add("Nepal","Kathmandu");
        countryCapitals.Add("India","Delhi");
        countryCapitals.Add("China","Beijing");
        countryCapitals.Add("Bhutan","Thimpu");

        foreach(var item in countryCapitals)
        {
            Console.WriteLine(item.Key + "=>" + item.Value);
        }

        // Define dictionary to hold country and its population
        // Print output as following
        //  Country     Population
        //  -----------------------
        //  Nepal       39254646
        //  India       12345678

        Dictionary<string,double> countryPopulation = new();
        countryPopulation.Add("Nepal",123456789);
        countryPopulation.Add("India",987654321);

        Console.WriteLine("Country\t\t\t" + "Population");
        Console.WriteLine("----------------------------------");


        foreach(var item in countryPopulation)
        {
            Console.WriteLine(item.Key + "\t\t\t" + item.Value);
        }



        
    }
}