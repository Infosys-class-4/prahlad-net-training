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

         // Console.Write("Enter a number: ");
         // var num = Convert.ToInt16(Console.ReadLine());

         // if (num % 2 == 0)
         // {
         //    Console.WriteLine("It's even number");
         
         // }
         // else if (num % 3 == 0 && num % 5 == 0)
         // {
         //    Console.WriteLine("It's multiple of 3 and 5");

         // }
         // else if (num % 3 == 0 )
         // {
         //    Console.WriteLine("It's multiple of 3 ");
         // }

         // for(int counter = 2; counter <= 100; counter = counter + 2)
         // {
         //    Console.Write(counter + " ");

         // }

         // int counter = 1;
         // while (counter <= 100)
         // {
         //    Console.Write(counter + " ");
         //    counter++;
         // }

         // Print "Hello" until user press "y" in the console

         // char yes = 'y';
         // while(yes == 'y')
         // {
         //    Console.WriteLine("Hello");
         //    Console.Write("Print another hello?");
         //    var keyPressed = Console.ReadKey();
         //    yes = keyPressed.KeyChar;
         // }

         // for (int i = 1; i <= 2; i++)
         // {
            
         //    for (int j = 1; j <= 3; j++)
         //    {
         //       Console.Write(j + " ");
         //    }
         //    Console.WriteLine();
         // }

          // 1 2 3
         // 4 5 6

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

         for (int i = 1; i <= 9; i = i + 4)
         {
            for (int j = i; j <= (i+3); j++)
            {
               Console.Write(j + " ");
            }
            Console.WriteLine();
         }
     }

}




