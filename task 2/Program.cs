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
        */
        
        
        
        
        /////////////////////// Task 2 ////////////////////////////////////////
        
        
        Console.WriteLine("please enter a positive whole number: ");
        int N = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i <= N ; i++)
        {
            sum += i;
        }
        Console.WriteLine("final sum is : " + sum);
    }
}