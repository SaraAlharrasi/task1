namespace task_2;

class Program
{
    static void Main(string[] args)
    {
        /*
        /////////////////////// Task 1 ////////////////////////////////////////
        
        Console.WriteLine("please enter a starting number: ");
        int num = int.Parse(Console.ReadLine());

        for (; num >= 1; num--)
        {
            Console.WriteLine(num);
        }
        Console.WriteLine("liftoff ");
        
        
        
        
        
        /////////////////////// Task 2 ////////////////////////////////////////
        
        
        Console.WriteLine("please enter a positive whole number: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N ; i++)
        {
            sum += i;
        }
        Console.WriteLine("final sum is : " + sum);
        
        
        
        
        
        /////////////////////// Task 3 ////////////////////////////////////////
        
        
        
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine( i + "x" + number + " = " + i*number);
            
        }
        
       
        
        
        
        /////////////////////// Task 4 ////////////////////////////////////////

        
        while(true)
        {
            string password = "Spark2026";
           Console.WriteLine("Please enter password: "); 
           string passwordInput = Console.ReadLine();

           if (passwordInput != password)
           {
               Console.WriteLine("invalid password");
           }
           else
           {
               Console.WriteLine("Correct Password!");
               break;
           }
           }

 */
        /////////////////////// Task 5 ////////////////////////////////////////

           int counter = 0;

           do
           {

               int secretNumber = 7;
               Console.WriteLine("Enter your guess: ");
               int guess = int.Parse(Console.ReadLine());

               if (guess != secretNumber)
               {
                   Console.WriteLine("Wrong guess! try again");
                   counter++;
               }
               else
               {
                   Console.WriteLine("You got it!");
                   break;
               }

           } while (true);
           
           Console.WriteLine("It took you " + counter + " guesses");



    }
}