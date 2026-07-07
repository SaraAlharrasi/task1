namespace task_1_part_4;

class Program
{
    //--------------------------------------- task 1 -----------------------------
    /*static void PrintWelcome(string userName)
    {
        Console.WriteLine("Welcome " + userName);
    }
    
    //--------------------------------------- task 2 -----------------------------
    static int square(int sqr)
    {
        sqr = sqr * sqr;
        return sqr;
    }
   
    //--------------------------------------- task 3 -----------------------------
    static double CelsiusToFahrenheit(double celsius)
    {
        double Fahrenheit = (celsius * 9 / 5) + 32;
        return Fahrenheit;
    }
     
    //--------------------------------------- task 4 -----------------------------
    static void DisplayMenu()
    {
        Console.WriteLine("1: star");
        Console.WriteLine("2: Help");
        Console.WriteLine("3: Exit");
        
    }
    
    //--------------------------------------- task 5 -----------------------------
    static bool IsEven(int number)
    {
        return number % 2 ==0 ;
        
    }
    
    //--------------------------------------- task 6 -----------------------------
    static double CalculateArea( double length, double width)
    {
        return length * width;
    }
    static double CalculatePerimeter (double length, double width)
    {
        return 2 * (length + width);
    }
    
    //--------------------------------------- task 7 -----------------------------

    static string GetGradeLetter (int grade)
    {
        if (grade >=90 && grade  <= 100)
        {
            return "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            return "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            return "C";
        }
        else if (grade >= 50 && grade < 70)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }
    
    //--------------------------------------- task 8 -----------------------------

    static void CountDown(int startingNumber)
    {
        for (int i = startingNumber; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }
    
    */
    //--------------------------------------- task 9 -----------------------------

    static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }

    static double Multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static int Multiply(int num1, int num2, int num3)
    {
        return num1 * num2 * num3;
    }
    
    
    
    static void Main(string[] args)
    {
        //--------------------------------------- task 1 -----------------------------
        /*Console.WriteLine("enter your name : ");
        string name = Console.ReadLine();
        PrintWelcome(name);
        
        //--------------------------------------- task 2 -----------------------------
        Console.WriteLine("enter a number ");
        int num = int.Parse(Console.ReadLine());
        
        
        Console.WriteLine("The answer is : " +  square(num));
  
        
        
        //--------------------------------------- task 3 -----------------------------
        Console.WriteLine("enter celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The Fahrenhite is:  " + CelsiusToFahrenheit(celsius));
              
        
        //--------------------------------------- task 4 -----------------------------
        
        DisplayMenu();
       
        
        //--------------------------------------- task 5 -----------------------------
        Console.WriteLine("enter a number");
        int number = int.Parse(Console.ReadLine());

        if (IsEven(number))
        {
            Console.WriteLine("even");
        }
        else
        {
            Console.WriteLine("odd");
        }
         
        //--------------------------------------- task 6 -----------------------------
        
        Console.WriteLine("Please enter the length ot the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Please enter the width ot the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The area of the rectangle is: " +  CalculateArea(length, width));
        Console.WriteLine("The perimeter of the rectangle is: " +  CalculatePerimeter(length, width));
        
        
        
        //--------------------------------------- task 7 -----------------------------

        Console.WriteLine("Enter your score: ");
        int grade = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Your score is " + GetGradeLetter(grade));

        
        //--------------------------------------- task 8 -----------------------------

        Console.WriteLine("please enter the starting number: ");
        int startNumber = int.Parse(Console.ReadLine());
        
        CountDown(startNumber);
*/
        
        //--------------------------------------- task 9 -----------------------------

        Console.WriteLine (Multiply (4, 6));
        Console.WriteLine (Multiply (5.7 , 9.8));
        Console.WriteLine(Multiply (4, 2 , 8));
        
    }
}
