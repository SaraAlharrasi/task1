namespace task_1_part_5;

class Program
{
    static void Main(string[] args)
    {
        
        //-------------------------------------- Task 1 -----------------------------------------------
        
        /*
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
        */
        
        //-------------------------------------- Task 2 -----------------------------------------------

        List<string> toDo = new List<string>();
        for (int counter = 0; counter < 5; counter++)
        {
            Console.WriteLine($"Enter {counter + 1 } To Do ");
            string toDoTask = Console.ReadLine();
            toDo.Add(toDoTask);
        }
        
        Console.WriteLine("How would you like your To Do List? ");
        Console.WriteLine("1: with numbers");
        Console.WriteLine("2: with bullets ");
        int toDoChoice = int.Parse(Console.ReadLine());
        int toDoNumber = 1;

        switch (toDoChoice)
        {
            case 1:
                foreach (string task in toDo)
                {
                    Console.WriteLine($"{toDoNumber}: {task}");
                    toDoNumber++;
                }

                break;
            case 2:
                foreach (string task in toDo)
                {
                    Console.WriteLine($"\u2022 {task}");
                }

                break;
        }
        
        
        
        
    }
}