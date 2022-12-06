class Advanced
{
    void Test()
    {   
        //SEQUENTIAL Way
        for(int i = 1000; i < 10000; i = i + 1000)
        {
            FindNthPrime(i);
        }

        //PARALLEL Way
        Parallel.For(1000,10000, (i)=>{
            FindNthPrime(i);
        });
    }

    void Test2()
    {
        // async and await
        // Asynchronous programming: Non-blocking
    }
    public double FindNthPrime(int n)
    {
        // Calculate prime
        Thread.Sleep(1000);
        return 0;
    }
}