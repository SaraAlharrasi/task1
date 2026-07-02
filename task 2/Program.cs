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


        /////////////////////// Task 6 ////////////////////////////////////////

        try
        {
            Console.WriteLine("please enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            
            int divisionSum = num1 / num2;
            
            Console.WriteLine("The sum is : "+ divisionSum);

        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can not divide by zero ");
        }
        
    */
        /////////////////////// Task 7 ////////////////////////////////////////

        bool menue = true;
        while (menue)
        {
            Console.WriteLine("Welcome to your favourite restaurant!");
            Console.WriteLine("Please choose a number between 1 and 3");
            Console.WriteLine("1: Say Hello");
            Console.WriteLine("2: good morning");
            Console.WriteLine("3: exit");
            try
            {
                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello! hope you enjoy your time here!");
                        break;
                    case 2: Console.WriteLine("Good Morning! Enjoy your breakFast!");
                        break;
                    case 3: Console.WriteLine("Have a nice day!");
                        menue = false;
                        break;
                    default: Console.WriteLine("Please pick a number between 1 and 3!");
                        break;
                }

               
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input");
            }
            
        }


        
        
    }
}