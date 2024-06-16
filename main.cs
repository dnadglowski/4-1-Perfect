using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Enter a Number.");
    int user_number = Int32.Parse(Console.ReadLine());
    int sum = 0;
    
    for(int i = 1; i < user_number; i++)
      if(user_number%i==0)
      {
        sum += i;
        }
        
          if(user_number==sum)
        {
          
          Console.WriteLine($"{user_number} is a perfect number." );
        
          }
          else
          {
            Console.WriteLine($"{user_number} is not a perfect number");
           
          }
      }
  }