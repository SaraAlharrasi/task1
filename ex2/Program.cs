namespace task_1_ex2;

class Program
{
    static void Main(string[] args)
    {
        // task 1 exercise 2 
        
        // taking input from the user 
        
        Console.WriteLine("please enter the first number");
        int recLength = int.Parse(Console.ReadLine());
        Console.WriteLine("please enter the second number");
        int recWidth = int.Parse(Console.ReadLine());
        
        // calculating area and perimeter 
        
        int recArea = recLength * recWidth;
        int recPerimeter = 2 *(recArea + recWidth);
        
        // printing out the result

        Console.WriteLine("The rectangle area is: "+ recArea);
        Console.WriteLine("The rectangle perimeter is: "+ recPerimeter);
        


    }
}