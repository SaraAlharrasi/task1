namespace task_1_part_5;

class Program
{
    static void Main(string[] args)
    {
        
        //-------------------------------------- Task 1 -----------------------------------------------
        int[] studentGrades = new int[5];

        int counter = 0;


        for (counter = 0; counter < studentGrades.Length; counter++)
        {
            try
            {
                Console.WriteLine($"Enter student {counter + 1} grade");
                studentGrades[counter] = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input");
            }
            
        }

        foreach (int grade in studentGrades)
        {
            Console.WriteLine($"grade: {grade}");
        }
        
        //-------------------------------------- Task 2 -----------------------------------------------
        
        
        
        
        
    }
}