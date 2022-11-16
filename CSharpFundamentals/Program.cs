//  Cars car1 = new();
//          car1.name = "Hyundai";
//          car1.color = "Red";
//          car1.cc = 1200;
         
//          string message = car1.GetCarCc();
//          Console.WriteLine(message);

// using System;
// using LivingThings;



using System;

 class Program
 {
     public static void Main()
     {
        // Console.Write("Enter a number: ");
        // var number = Convert.ToInt16(Console.ReadLine());
        // //var number = short.Parse(numberText);

        
        
        // if (number % 2 == 0)
        // {
        //     Console.WriteLine(number + " is even");
        // }
        // else
        // {
        //     Console.WriteLine(number + " is odd");

        // }


      //   Console.Write("Enter your name: ");
      //   string name = Console.ReadLine();
      //   string finalName = name.ToUpper();
      //   Console.WriteLine(finalName);

         Console.Write("Enter a number: ");
         var num = Convert.ToInt16(Console.ReadLine());

         if (num % 2 == 0)
         {
            Console.WriteLine("It's even number");
         
         }
         else if (num % 3 == 0 && num % 5 == 0)
         {
            Console.WriteLine("It's multiple of 3 and 5");

         }
         else if (num % 3 == 0 )
         {
            Console.WriteLine("It's multiple of 3 ");
         }


     }
}




