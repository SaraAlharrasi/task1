using System.Linq.Expressions;

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
        
        ///////////////////////task 8 ///////////////////////////

        Console.WriteLine("Please enter your membership start date  like this format (2026-01-10): ");
        string MembershipStartDate = Console.ReadLine();

        Console.WriteLine("Please enter the number of valid membership days: ");
        int validDays = int.Parse(Console.ReadLine());

        DateTime startDate = DateTime.Parse(MembershipStartDate);
        DateTime expiryDate = startDate.AddDays(validDays);

        if (expiryDate >= DateTime.Today)
        {
            Console.WriteLine("Active - your membership expires on " + expiryDate);
        }
        else
        {
            Console.WriteLine("Expired - your membership expired on " + expiryDate);
        }                                                                                    
        
        ///////////////////////task 9 ///////////////////////////
        
        
        Console.WriteLine("please enter a decimal number: ");
        double decimalNumber = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The number rounded to the nearest whole number is: "+ Math.Round(decimalNumber));
        Console.WriteLine("The number always rounded up is : "+  Math.Ceiling(decimalNumber));
        Console.WriteLine("The number always rounded down is : "+  Math.Floor(decimalNumber));
       
        ///////////////////////task 10 ///////////////////////////
        
        
        Console.WriteLine("Please enter a sentence: ");
        string sentence = Console.ReadLine();
        Console.WriteLine("Please enter the word you want to check:  ");
        string word = Console.ReadLine();

        int firstIndex = sentence.IndexOf(word);
        int lastIndex = sentence.LastIndexOf(word);

        if (firstIndex == -1)
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            Console.WriteLine("The word /" +word +"/ first appear in " + firstIndex);
            Console.WriteLine("The word /" +word +"/ last appear in " + lastIndex);
             
        
        
        ////////////////////////////////////////////task 11 /////////////////////////////
        
       
         int randomNumber = new Random().Next(1000, 10000);
         Console.WriteLine(randomNumber);

         bool verified = true;
         
         for (int i = 1; i <= 3; i++)
         {
             Console.WriteLine("please enter the verification code: ");
             try
             {
                 int code = int.Parse(Console.ReadLine());
                 if (code == randomNumber)
                 {
                     Console.WriteLine("verified");
                     verified = false;
                     break;
                 }
                 
             }
             catch (FormatException)
             {
                 Console.WriteLine("invalid input");
             }
             
         }
         if (verified)
         {
             Console.WriteLine("verification failed");
         }
*/
        ////////////////////////////////////////////task 12 /////////////////////////////
        
        Console.WriteLine("Enter your date of birth (e.g. 2000-01-25)");
        string dateOfBirth = Console.ReadLine();
        
        DateTime BirthDate = DateTime.Parse(dateOfBirth);
        DateTime today = DateTime.Today;
        
        int age  = today.Year - BirthDate.Year;

        if (today.Month < BirthDate.Month || (today.Month == BirthDate.Month && today.Day < BirthDate.Day))
        {
            age = age - 1;
        }
        Console.WriteLine("Your age is : " + age);
        Console.WriteLine("The week you were born in is : "+ BirthDate.DayOfWeek) ;


    }
}