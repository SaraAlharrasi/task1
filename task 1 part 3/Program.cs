namespace task_1_part_3;

class Program
{
    static void Main(string[] args)
    {
        ///////////////////////task 1 ///////////////////////////
        /*
        Console.WriteLine("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");  
        int secondNumber = int.Parse(Console.ReadLine());
        
        int subtraction = Math.Abs(secondNumber - firstNumber);
        Console.WriteLine("The subtraction result is: " + subtraction);
       
        
        ///////////////////////task 2 ///////////////////////////
        
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        double sqr = Math.Sqrt(number);
        Console.WriteLine("The square root of " + number + " = " + sqr);

        double pow = Math.Pow(number, 2);
        Console.WriteLine("The square  of " + number + " = " + pow);
        
       
        ///////////////////////task 3 ///////////////////////////
        
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        
        Console.WriteLine("Name in upper case: "+ (name.ToUpper()));
        Console.WriteLine("Name in lower case: "+ (name.ToLower()));
        Console.WriteLine("The number of characters in your name is:  "+ (name.Length));
        
        
        ///////////////////////task 4 ///////////////////////////
        
        Console.WriteLine("Please enter the number of days of a free trial: ");
        int freeTrial = int.Parse(Console.ReadLine());

        DateTime today = DateTime.Today;
        DateTime trialEnds = today.AddDays(freeTrial);
        string Date = trialEnds.ToString("yyyy-MM-dd");
        
        Console.WriteLine("Trial ends in : " + Date);
        
         
        ///////////////////////task 5 ///////////////////////////
        
        Console.WriteLine("please enter your raw exam score: ");
        double rawScore = double.Parse(Console.ReadLine());

        if (Math.Round(rawScore, 0) < 0 || Math.Round(rawScore, 0) > 100)
        {
            Console.WriteLine("invalid input!");
        }
        else if (Math.Round(rawScore, 0) >= 60)
        {
            Console.WriteLine("Your exam score is : " + Math.Round(rawScore, 0) + " You passed! ");
            
        }
        else 
        {
            Console.WriteLine("You failed!");
        }
        
        ///////////////////////task 6 ///////////////////////////
        
        Console.WriteLine("please enter a password: ");
        string password = Console.ReadLine();
        bool IsLongEnough = password.Length > 8;
        bool ContainsPassword = password.ToLower().Contains("password");

        if (IsLongEnough && !ContainsPassword)
        {
            Console.WriteLine("strong password");
        }
        else
        {
            Console.WriteLine("weak password");
        }
        */
        ///////////////////////task 7 ///////////////////////////
        
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter your name again: ");
        string nameAgain = Console.ReadLine();

        if (name.ToLower().Trim() == nameAgain.ToLower().Trim())
        {
            Console.WriteLine("Match!");
        }
        else
        {
            Console.WriteLine("No Match");
        }
        
        
        
        
    }
}