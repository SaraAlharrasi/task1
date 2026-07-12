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
                    PrintBalance();
                    break;
                
                case 2:
                    updateAddress();
                    break;
                
                case 3:
                    Deposite();
                    break;
                
                case 4:
                    Withdraw();
                    break;
                case 5:
                    ViewProduct();
                    break;
                case 6:
                    RegisterStudent();
                    break;
                case 7:
                    CompareBalances();
                    break;
                case 8:
                    ProductCheck();
                    break;
                case 9 :
                    TransferBetweenAccounts();
                    break;
                case 10:
                    UpdateStudentGrade();
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    Console.WriteLine("Have a nice day :)!");
                    exitApp = true;
                    break;
            }
        }
        
    }
    
    //--------------------------- case 1 --------------------------
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

    static void PrintBalance()
    {
        BankAccount choosen1 = ChoosenAccount();
        Console.WriteLine($"Current balance is : {choosen1.CheckBalance()}");
    }

    //--------------------------- case 2 ---------------------------
    
    static Student ChoosenStudent()
    {
        Console.WriteLine("Choose a student:  (1/2)"); 
        
        string StudentChoice =  Console.ReadLine();
        if (StudentChoice == "1")
        {
            return student1;
        }
        else
        {
            return student2;
        }

    }
    static void updateAddress()
    {
        Student choosen2 = ChoosenStudent();
        Console.WriteLine("Enter new address: ");
        string newAddress = Console.ReadLine();
        choosen2.Address =  newAddress;
        Console.WriteLine($"new address: {choosen2.Address}");
    }
    
    //---------------------------- case 3 ---------------------------

    static void Deposite()
    {
        BankAccount choosen1 = ChoosenAccount();
        double depositAmount;
        
        Console.WriteLine("Enter an amount: ");

        try
        { 
            depositAmount = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        
        choosen1.Deposit(depositAmount);
        
        Console.WriteLine($"Account holder's name: {choosen1.HolderName}");
        Console.WriteLine($"Balance: {choosen1.Balance}");
    }
    
    
    //---------------------------- case 4 ---------------------------

    static void Withdraw()
    {
        BankAccount choosen1 = ChoosenAccount();
        Console.WriteLine("Enter an amount: ");
        double withdrawalAmount;

        try
        { 
            withdrawalAmount = double.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        
        choosen1.Withdraw(withdrawalAmount);
        
        Console.WriteLine($"Balance:  {choosen1.Balance}");
        
        
    }
    
    //---------------------------- case 5 ---------------------------
    static Product ChoosenProduct()
    {
        Console.WriteLine("Choose a product:  (1/2)"); 
        
        string Product =  Console.ReadLine();
        if (Product == "1")
        {
            return product1;
        }
        else
        {
            return product2;
        }

    }

    static void ViewProduct()
    {
        Product choosen3 = ChoosenProduct();

        Console.WriteLine($"Total inventory value: {choosen3.GetInventoryValue()}");
    }
    
    //---------------------------- case 6 ---------------------------

    static void RegisterStudent()
    {
        Student choosen2 = ChoosenStudent();
        Console.WriteLine("Enter your email: ");
        string email = Console.ReadLine();
        
        choosen2.Register(email);
        
        Console.WriteLine("Email has been registered successfully");
    }
    
    
    //---------------------------- case 7 ---------------------------

    static void CompareBalances()
    {
        BankAccount firstAccount = account1;
        BankAccount secondAccount = account2;

        if (firstAccount.Balance < secondAccount.Balance)
        {
            Console.WriteLine($"{secondAccount.HolderName} has more balance than {firstAccount.HolderName}");
        }
        else if (firstAccount.Balance == secondAccount.Balance)
        {
            Console.WriteLine($"{firstAccount.HolderName} is equal to {secondAccount.HolderName}");
        }
        else
        {
            Console.WriteLine($"{firstAccount.HolderName} has more balance than {secondAccount.HolderName}");
        }

    }
    
    
    //---------------------------- case 8 ---------------------------

    static void ProductCheck()
    {
        Product choosen3 = ChoosenProduct();
        int quantity;

        Console.WriteLine("Enter quantity: ");

        try
        {
            quantity = int.Parse(Console.ReadLine());
            choosen3.Restock(quantity);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input");
        }

        if (choosen3.StockQuantity < 10)
        {
            Console.WriteLine("Low");
        }
        else if (choosen3.StockQuantity <= 49)
        {
            Console.WriteLine("Moderate");
        }
        else
        {
            Console.WriteLine("Well stocked");
        }

    }
    
    //---------------------------- case 9 ---------------------------

    static void TransferBetweenAccounts()
    {
        BankAccount SourceAccount = ChoosenAccount();
        BankAccount DestinationAccount = ChoosenAccount();
        
        Console.WriteLine("Enter the amount to transfer: ");
        double amount = double.Parse(Console.ReadLine());

        if (SourceAccount.Balance >= amount)
        {
            SourceAccount.Withdraw(amount);
            DestinationAccount.Deposit(amount);
            
            Console.WriteLine($"Transfered {amount} from {SourceAccount.HolderName} to {DestinationAccount.HolderName}");
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }
    }
    
    
    //---------------------------- case 10 ---------------------------

    static void UpdateStudentGrade()
    {
        Student choosen2 = ChoosenStudent();
        int grade;
        
        Console.WriteLine("Enter new grade: ");
        try
        {
            grade = int.Parse(Console.ReadLine());
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("grade must be between 0 and 100");
            }
            else
            {
                choosen2.Grade = grade;
                Console.WriteLine($"Grade: {choosen2.Grade}");
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid input");
        }

        
        
        
    }
    
    
}