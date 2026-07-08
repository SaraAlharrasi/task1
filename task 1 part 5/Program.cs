using System.Diagnostics.Metrics;

namespace task_1_part_5;

class Program
{

    //-------------------------------------- Task 9 -----------------------------------------------
    /*
    static double CalculateAverage(List<int> grades)
    {
        double average = 0 ;
        for (int counter = 0; counter < grades.Count; counter++)
        {
            average += grades[counter];
        }
        average =  average  / grades.Count;
        return average;
    }

    static int FindFirstFailing(List<int> grades)
    {
        int firstToFail = grades.Find(x => x < 60);
        return firstToFail;
    }
    */
    
    static Queue<string> RemoveJob(Queue<string> jobs, string jobToRemove)
    {
        Queue<string> newQueue = new Queue<string>();

        while (jobs.Count > 0)
        {
            string job = jobs.Dequeue();
            if (job != jobToRemove)
            {
                newQueue.Enqueue(job);
            }
        }

        return newQueue;
    }
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
        


        //-------------------------------------- Task 6 -----------------------------------------------

        List<string> shoppingList = new List<string>();

        bool isAdding = true;

        while (isAdding)
        {
            Console.WriteLine("enter item:");
            string item = Console.ReadLine();

            if (item == "done")
            {
                isAdding = false;
            }
            else
            {
                shoppingList.Add(item);
            }
        }
        Console.WriteLine("here is your list" );
        Console.WriteLine(string.Join(" ",shoppingList));

        Console.WriteLine("enter the item you want to remove: ");
        string removeItem = Console.ReadLine();
        shoppingList.Remove(removeItem);
        Console.WriteLine(string.Join(", ", shoppingList));
        
        
        //-------------------------------------- Task 7 -----------------------------------------------


        List<int> gameScore = new List<int>();

        for (int counter = 0; counter < 5; counter++)
        {
            Console.WriteLine($"enter {counter + 1} score" );
            int score = int.Parse(Console.ReadLine());
            gameScore.Add(score);
        }
        
        gameScore.Sort();
        gameScore.Reverse();
        
        Console.WriteLine($"1st place : {gameScore[0]}");
        Console.WriteLine($"2nd place : {gameScore[1]}");
        Console.WriteLine($"3ed place : {gameScore[2]}");
        
        
        
        
        //-------------------------------------- Task 8 -----------------------------------------------
        Stack<string> trackAction = new Stack<string>();

        bool isTrying = true;

        while (isTrying)
        {
            Console.WriteLine("enter action: ");
            string action = Console.ReadLine();

            if (action == "stop")
            {
                isTrying = false;
            }
            else
            {
                trackAction.Push(action);
            }
        }
        Console.WriteLine("undo");
        string undo1 = trackAction.Pop();
        Console.WriteLine(undo1);
        Console.WriteLine("undo");
        string undo2 = trackAction.Pop();
        Console.WriteLine(undo2);


        foreach (string action in trackAction)
        {
            Console.WriteLine(action);
        }
        
        
        
        //-------------------------------------- Task 9 -----------------------------------------------
        Console.WriteLine("how many grades do you want to enter: ");
        int numOfGrades = int.Parse(Console.ReadLine());
        
        List<int> studentGrades = new List<int>();

        for (int i = 0; i < numOfGrades ; i++)
        {
            Console.WriteLine($"Enter grade {i+1}: ");
            int grade = int.Parse(Console.ReadLine());
            studentGrades.Add(grade);
        }

        Console.WriteLine($"Average grade: {CalculateAverage(studentGrades)}");
        Console.WriteLine($"First Failing Grade: {FindFirstFailing(studentGrades)}");
       */

        //-------------------------------------- Task 10 -----------------------------------------------
        
        Queue<string> printQueue = new Queue<string>();
        bool isAdding = true;

        while (isAdding)
        {
            Console.WriteLine("Enter print job name : ");
            string job = Console.ReadLine();

            if (job == "done")
            {
                isAdding = false;
            }
            else
            {
                printQueue.Enqueue(job);
            }
        }

        Console.WriteLine("queue before cancellation :");
        foreach (string job in printQueue)
        {
            Console.WriteLine(job);
        }

        Console.WriteLine("Enter the job name to cancel: ");
        string jobToCancel = Console.ReadLine();

        printQueue = RemoveJob(printQueue, jobToCancel);

        Console.WriteLine("queue after cancellation:");
        foreach (string job in printQueue)
        {
            Console.WriteLine(job);
        }
    

        

    }
}