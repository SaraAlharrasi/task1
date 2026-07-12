namespace OOP_task1;

public class BankAccount
{
    public int AccountNumber { get; set; }
    public string HolderName { get; set; }
    public double Balance { get; set; }

   public void Deposit (double amount)
    {
        Balance += amount;
        SendEmail();
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        SendEmail();
    }

    public double CheckBalance()
    {
        PrintInformation();
        return Balance;
    }

    private void PrintInformation()
    {
        Console.WriteLine($"Holder Name: {HolderName}");
        Console.WriteLine($"Balance: {Balance}");
        
    }

    private void SendEmail()
    {
        Console.WriteLine("Email notification sent!");
    }
    
}

public class Student
{
    public int  Grade { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    private string Email { get; set; } 
    int Age { get; set; }



    public void Register(string email)
    {
        Console.WriteLine("Enter Email: ");
        Email = email;
        SendEmail();
    }

    private void SendEmail()
    {
        Console.WriteLine("Registration Email sent!");
    }
}


public class Product
{
    public string ProductName { get; set; }
    public double Price { get; set; } 
    public int StockQuantity { get; set; }


    public void Sell(int quantity)
    {
        if (StockQuantity >= quantity)
        {
            StockQuantity -= quantity;
        }
        else
        {
            Console.WriteLine("Not enough stock");
        }

        LogTransaction();

    }

    public void Restock(int quantity)
    {
        StockQuantity += quantity;
        LogTransaction();
    }

    public double GetInventoryValue()
    {
        PrintDetails();
        return Price * StockQuantity;
    }

    private void PrintDetails()
    {
        Console.WriteLine($"Product Name: {ProductName}"); 
        Console.WriteLine($"Product Price: {Price}");
        Console.WriteLine($"Stock Quantity: {StockQuantity}");
    }

    private void LogTransaction()
    {
        Console.WriteLine("Transaction Logged!");
    }
}

class Program
{
    
    static BankAccount account1 = new BankAccount{AccountNumber = 1163, HolderName = "karim", Balance = 120};
    static BankAccount account2 = new BankAccount{AccountNumber = 15203, HolderName = "Ali", Balance = 63};
    
    static Student student1 = new Student{ Name= "Mohammed", Address = "Muscat", Grade = 63};
    static Student student2 = new Student{ Name= "Fatima", Address = "Nizwa", Grade = 90};
    
    static Product product1 = new Product{ ProductName = "wireless mouse", Price = 5.500, StockQuantity = 50};
    static Product product2 = new Product{ ProductName = "mechanical keyboard", Price = 15.750, StockQuantity = 20};
    
    
    static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to the system!");

        bool exitApp = false;

        while (!exitApp)
        {
            Console.WriteLine("what would you like to do? ");
            
            Console.WriteLine("1. View Account Details");
            Console.WriteLine("2. Update Student Address");
            Console.WriteLine("3.  Make a Deposit");
            Console.WriteLine("4. Make a Withdrawal");
            Console.WriteLine("5. View Product Details");
            Console.WriteLine("6. Register a Student");
            Console.WriteLine("7. Compare Two Account Balances");
            Console.WriteLine("8. Restock Product & Stock Level Check");
            Console.WriteLine("9. Transfer Between Accounts");
            Console.WriteLine("10.  Update Student Grade");
            Console.WriteLine("11.  Student Report Card");
            Console.WriteLine("12. Account Health Status");
            Console.WriteLine("13. Bulk Sale With Revenue Calculation");
            Console.WriteLine("14. Scholarship Eligibility Check");
            Console.WriteLine("15. Full Balance Top-Up Flow");
            Console.WriteLine("16. Quick Account Opening");
            Console.WriteLine("17. Total Students Counter");
            Console.WriteLine("18. Overdrawn Account Check");
            Console.WriteLine("19. Set Student Security PIN ");
            Console.WriteLine("20. Exit");
            
            
            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    BankAccount choosen1 = ChoosenAccount();
                    Console.WriteLine($"Current balance is : {choosen1.CheckBalance()}");
                    break;
                
                case 2:
                    Student choosen2 = ChoosenStudent();
                    Console.WriteLine("Enter new address: ");
                    string NewAddress = Console.ReadLine();
                    choosen2.Address =  NewAddress;
                    
                    Console.WriteLine($"new address: {choosen2.Address}");
                    break;
                    
            }
        }




            
            
       
        
    }
    
    static  BankAccount ChoosenAccount()
    {
        Console.WriteLine("Choose a bank account:  (1/2)"); 
        
        string bankaccount =  Console.ReadLine();
        if (bankaccount == "1")
        {
            return account1;
        }
        else
        {
            return account2;
        }
            
    }

    static Student ChoosenStudent()
    {
        Console.WriteLine("Choose a student:  (1/2)"); 
        
        string Student =  Console.ReadLine();
        if (Student == "1")
        {
            return student1;
        }
        else
        {
            return student2;
        }

    }
    
    
}