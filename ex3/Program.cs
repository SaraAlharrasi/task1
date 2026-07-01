namespace task_1_ex3;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 exercise 3 
        
        // asking the user for an input 
        Console .WriteLine("Please enter a number: ");
        int num =  int.Parse(Console.ReadLine());
        
        // determine if the number is odd or even 

        if (num % 2 == 0)
        {
            Console.WriteLine("number is even");
        }
        else
        {
            Console.WriteLine("number is odd");
        }
    }
}