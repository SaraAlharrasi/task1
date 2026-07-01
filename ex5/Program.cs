namespace ex5;

class Program
{
    static void Main(string[] args)
    {
        // ask the user for the grade 
        
        Console.WriteLine("Please Enter your grade (A,B,C,D,F)");
        char grade = char.Parse(Console.ReadLine());

        switch (grade)
        {
            case 'A':
                Console.WriteLine("excellent");
                break;

            case 'B':
                Console.WriteLine("Very good");
                break;
            
            case 'C':
                Console.WriteLine("Good");
                break;
            case 'D':
                Console.WriteLine("Pass");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid grade");
                break;
        }

    }
}