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
    */
    //--------------------------------------- task 3 -----------------------------
    static double CelsiusToFahrenheit(double celsius)
    {
        double Fahrenheit = (celsius * 9 / 5) + 32;
        return Fahrenheit;
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
        */
        
        
        //--------------------------------------- task 3 -----------------------------
        Console.WriteLine("enter celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The Fahrenhite is:  " + CelsiusToFahrenheit(celsius));
    }
}
