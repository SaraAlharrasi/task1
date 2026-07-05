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
        */
        
        
        ///////////////////////task 2 ///////////////////////////
        
        Console.WriteLine("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        double sqr = Math.Sqrt(number);
        Console.WriteLine("The square root of " + number + " = " + sqr);

        double pow = Math.Pow(number, 2);
        Console.WriteLine("The square  of " + number + " = " + pow);
        
        

    }
}