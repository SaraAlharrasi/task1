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
       
        
        //-------------------------------------- Task 3 -----------------------------------------------
        
        Stack<string> browserHistory = new Stack<string>();

        for (int counter = 0; counter < 3; counter++)
        {
            Console.WriteLine("Enter a URL: ");
            string url = Console.ReadLine();
            browserHistory.Push(url);
        }
        
        
        browserHistory.Pop();
        Console.WriteLine($"last page : {browserHistory.Peek()}");
        
       
        //-------------------------------------- Task 4 -----------------------------------------------
        
        Queue<string> CustomerQueue = new Queue<string>();

        for (int counter = 0; counter <= 2; counter++)
        {
            Console.WriteLine("enter customer name : ");
            string customerName = Console.ReadLine();
            CustomerQueue.Enqueue(customerName);
        }
        // calling out customer name (indicating that its their time to be served)
        
        Console.WriteLine(CustomerQueue.Peek().ToUpper()); // using all caps to indicate load voice for calling out loud
        
        Console.WriteLine($"{CustomerQueue.Dequeue()} was served!");
         
        
        
        //-------------------------------------- Task 5 -----------------------------------------------


        int[] studentGrades = new int[5];
        double average = 0;
        double averageGrade =  average/ studentGrades.Length;
       

        for (int counter = 0; counter < studentGrades.Length; counter++)
        {
            Console.WriteLine($"Enter student grade {counter + 1} : ");
            studentGrades[counter] = int.Parse(Console.ReadLine());
            average += studentGrades[counter];
        }
        
        Array.Sort(studentGrades);
        
        Console.WriteLine($"Lowest grade:  {studentGrades[0]}");
        Console.WriteLine($"Highest grade:  {studentGrades[4]}");
        Console.WriteLine($"Average  grade: {averageGrade}");
        
*/

        //-------------------------------------- Task 6 -----------------------------------------------



    }
}