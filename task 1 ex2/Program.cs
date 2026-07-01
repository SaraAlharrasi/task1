namespace task_1_ex2;

class Program
{
    static void Main(string[] args)
    {
        // task 1 exercise 2 
        
        // taking input from the user 
        int recLength = int.Parse(Console.ReadLine());
        int recWidth = int.Parse(Console.ReadLine());
        
        // calculating area and perimeter 
        
        int recArea = recLength * recWidth;
        int recPerimeter = 2 *(recArea + recWidth);
        
        // printing out the result

        Console.WriteLine("The rectangle area is: "+ recArea);
        Console.WriteLine("The rectangle perimeter is: "+ recPerimeter);
        


    }
}