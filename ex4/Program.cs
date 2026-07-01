namespace ex4;

class Program
{
    static void Main(string[] args)
    {
        // ask the user about his/her age 
        
        Console.WriteLine("Please Enter your Age: ");
        int age = int.Parse(Console.ReadLine());
        
        // ask the user if they own a national Id card 
        
        Console.WriteLine("Do you own a national ID card? (true/ false)");
        bool IdCard = bool.Parse(Console.ReadLine());
        
        // determine if user can vote 

        if (age < 17)
        {
            Console.WriteLine("you are under age ! wait till you grow up");
        }
        else if (IdCard == false)
        {
            Console.WriteLine("You do not own an Id Card");
        }
        else if(age >= 18 && IdCard == true)
        {
            
            Console.WriteLine("You can vote! ");
        }
        else
        {
            Console.WriteLine("something went wrong!");
        }
    }
}