using System;
using System.Threading;


class program 
{
  static void Main()
    {
        Console.Write(" enter your name: ");
        string username = Console.ReadLine();

        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);

            if (i == 5)
            {
               
                Thread.Sleep(500);
            }
            else if (i > 0)
            {
               
                Thread.Sleep(1000);
            }
           
        }

      
        Console.WriteLine($"Welcome {username}!");
    }
}