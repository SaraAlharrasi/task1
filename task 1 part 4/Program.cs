namespace task_1_part_4;

class Program
{
    
    static void PrintWelcome(string userName)
    {
        Console.WriteLine("Welcome " + userName);
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine("enter your name : ");
        string name = Console.ReadLine();
        PrintWelcome(name);
    }
}
