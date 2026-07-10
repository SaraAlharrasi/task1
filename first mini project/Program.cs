using System;
using System.Collections.Generic;

namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();

        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6.List All Accounts");
                Console.WriteLine("7. Close an account");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }

                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        ListAllAccounts();
                        break;
                    case 7:
                        CloseAccount();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }

        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.

        static void AddAccount()
        {
            Console.WriteLine("Enter customer name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter new account number:");
            string numberOfAccount = Console.ReadLine();

            double depositAmount;


            if (accountNumbers.Contains(numberOfAccount))
            {
                Console.WriteLine("Account number already exists, please try a different one");
            }
            else
            {
                Console.WriteLine("To open the account you must deposite initial amount of money");
                try
                { 
                    depositAmount = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid amount entered.");
                    return;
                }
                if (depositAmount <= 0)
                {
                    Console.WriteLine("please enter a positive number.");
                }
                else
                {
                    customerNames.Add(customerName);
                    accountNumbers.Add(numberOfAccount);
                    balances.Add(depositAmount);
                }
            }
        }

        static void DepositMoney()
        {
            Console.WriteLine("Enter account number:");
            string numberOfAccount = Console.ReadLine();

            int index = accountNumbers.IndexOf(numberOfAccount);

            if (index == -1)
            {
                Console.WriteLine("Account number does not exists");
            }
            else
            {
                Console.WriteLine("Enter deposite amount: ");
                try
                {
                    double depositAmount = double.Parse(Console.ReadLine());
                    if (depositAmount <= 0)
                    {
                        Console.WriteLine("please enter a positive number.");
                    }
                    else
                    {
                        balances[index] += depositAmount;
                        Console.WriteLine(" Current balance is : " + balances[index]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid amount entered.");
                    return;
                }
            }

        }

        static void WithdrawMoney()
        {
            Console.WriteLine("Enter account number:");
            string numberOfAccount = Console.ReadLine();

            int index = accountNumbers.IndexOf(numberOfAccount);
            if (index == -1)
            {
                Console.WriteLine("Account number does not exists");
            }
            else
            {
                Console.WriteLine("Enter withdrawal amount: ");
                try
                {
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    if (withdrawalAmount <= 0 || withdrawalAmount > balances[index])
                    {
                        Console.WriteLine("Error! enter withdrawal amount again");
                    }
                    else
                    {
                        balances[index] -= withdrawalAmount;
                        Console.WriteLine(" Current balance is : " + balances[index]);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid amount entered.");
                }

            }

        }

        static void ShowBalance()
        {
            Console.WriteLine("Enter account number:");
            string numberOfAccount = Console.ReadLine();

            int index = accountNumbers.IndexOf(numberOfAccount);

            if (index == -1)
            {
                Console.WriteLine("Account number does not exists");
            }
            else
            {
                Console.WriteLine("Customer name: " + customerNames[index]);
                Console.WriteLine("Account number " + accountNumbers[index]);
                Console.WriteLine("Balance: " + balances[index]);

            }

        }

        static void TransferAmount()
        {
            Console.WriteLine("Enter Sender account number: ");
            string senderAccountNumber = Console.ReadLine();

            Console.WriteLine("Enter receiver account number: ");
            string receiverAccountNumber = Console.ReadLine();

            int indexSender = accountNumbers.IndexOf(senderAccountNumber);
            int indexReceiver = accountNumbers.IndexOf(receiverAccountNumber);

            double transferAmount;

            if (indexSender == -1 || indexReceiver == -1)
            {
                Console.WriteLine("account number does not exists");
            }
            else
            {
                Console.WriteLine("Enter amount of transfered money: ");

                try
                {
                    transferAmount = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                if (transferAmount <= 0)
                {
                    Console.WriteLine("please enter a positive number.");
                }
                else if (transferAmount > balances[indexSender])
                {
                    Console.WriteLine("balance not sufficient");
                }
                else
                {
                    balances[indexSender] -= transferAmount;
                    balances[indexReceiver] += transferAmount;

                    Console.WriteLine($"Sender's current balance: {balances[indexSender]}");
                    Console.WriteLine($"Reciever's current balance: {balances[indexReceiver]}");
                }



            }
        }

        static void ListAllAccounts()
        {
            Console.WriteLine("Here are all the customers accounts: ");



            if (accountNumbers.Count == 0)
            {
                Console.WriteLine("No accounts exists yet!");
            }
            else
            {
                for (int i = 0; i < accountNumbers.Count; i++)
                {
                    Console.WriteLine($"Customer : {customerNames[i]}");
                    Console.WriteLine($"Account number : {accountNumbers[i]}");
                    Console.WriteLine($"Balance : {balances[i]}");
                }
            }
        }

        static void CloseAccount()
        {
            Console.WriteLine("Enter The account number you want to delete: ");
            string accountNumber = Console.ReadLine();

            int index = accountNumbers.IndexOf(accountNumber);
            if (index == -1)
            {
                Console.WriteLine("Account number does not exists");
            }
            else
            {
                accountNumbers.RemoveAt(index);
                customerNames.RemoveAt(index);
                balances.RemoveAt(index);
                Console.WriteLine(" account number has been deleted");
            }
        }

    }
}
    
