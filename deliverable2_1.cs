using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine("Welcome " + name + " Do you want to do the COIN FLIP CHALLENGE? YES/NO");
      
        string answer = Console.ReadLine();
      
      //start of if statement  
      if (answer == "YES")
        { 

          //initialize score variable to 0
          int score = 0;
          
          // LOOP STARTS HERE
          for (int i = 0; i < 5; i++)
          {
              Console.WriteLine("HEADS OR TAILS?");
            string guess = Console.ReadLine();
            
            // Random number generator
            Random random = new Random();
            bool isHeads = random.Next(2) == 0;
            
            // Check the user's guess against the actual result
            if ((guess.ToUpper() == "HEADS" && isHeads) || (guess.ToUpper() == "TAILS" && !isHeads))
            {
                Console.WriteLine("Correct!");
              score++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
          }
          Console.WriteLine("Thank You " + name + ". You got a score of " + score + "!");
          } 
      else
      {
        Console.WriteLine("YOU ARE A COWARD " + name);
        }
      
    }
  
}