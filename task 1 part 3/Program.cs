namespace task_1_part_3;

class Program
{
    static void Main(string[] args)
    {
        ///////////////////////task 1 ///////////////////////////
        
        Console.WriteLine("Please enter the first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number: ");  
        int secondNumber = int.Parse(Console.ReadLine());
        
        int subtraction = Math.Abs(secondNumber - firstNumber);
        Console.WriteLine("The subtraction result is: " + subtraction);
    }
}