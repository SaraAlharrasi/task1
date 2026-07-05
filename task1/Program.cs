namespace task1;

class Program
{
    static void Main(string[] args)
    {
        /*
        // Task 1 exercise 1 
        //declaring variables 
        string name = "Maryam";
        int userAge = 40;
        double height = 160;
        bool IsStudent = false;
        
        //print out personal card info 
        
        Console.WriteLine("///////// card info /////////");
        
        Console.WriteLine("Name: " +  name);
        Console.WriteLine("Age: " +  userAge);
        Console.WriteLine("height: " +  height);
        Console.WriteLine("student: " +  IsStudent);
        
        
            // ----------------------------------------exercise 2--------------------------------
            // taking input from the user 
        
            Console.WriteLine("please enter the first number");
            int recLength = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter the second number");
            int recWidth = int.Parse(Console.ReadLine());
        
            // calculating area and perimeter 
        
            int recArea = recLength * recWidth;
            int recPerimeter = 2 *(recArea + recWidth);
        
            // printing out the result

            Console.WriteLine("The rectangle area is: "+ recArea);
            Console.WriteLine("The rectangle perimeter is: "+ recPerimeter);
            
            
            
           // ----------------------------------------exercise 3--------------------------------
           
           // asking the user for an input 
           Console .WriteLine("Please enter a number: ");
           int num =  int.Parse(Console.ReadLine());
        
           // determine if the number is odd or even 

           if (num % 2 == 0)
           {
               Console.WriteLine("number is even");
           }
           else
           {
               Console.WriteLine("number is odd");
           }
           
           // ----------------------------------------exercise 4--------------------------------
           
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
           
           // ----------------------------------------exercise 5--------------------------------
           
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
           // ----------------------------------------exercise 6--------------------------------
                   // Temperature Converter 
        
                   // ask the user to enter a temperature 
        
                   Console.WriteLine("////////Temperature Converter/////////");
                   Console.WriteLine("Please enter the temperature in celsius");
                   double celTemp = double.Parse(Console.ReadLine());
        
                   // convert the temperature
        
                   double fehTemp = (celTemp * 9 / 5) + 32;
        
                   // determine if weather is hot or cold 

                   if (fehTemp < 10)
                   {
                       Console.WriteLine("The temperature in Fahrenheit is " + fehTemp);
                       Console.WriteLine("The weather is cold ");
                   }
                   else if( fehTemp >= 10 && fehTemp <=30)
                   {
                       Console.WriteLine("The temperature in Fahrenheit is " + fehTemp);
                       Console.WriteLine("The weather is mild");
                   }
                   else if (fehTemp> 30)
                   {
                       Console.WriteLine("The temperature in Fahrenheit is " + fehTemp);
                       Console.WriteLine("The weather is hot");
                   }
                   else
                   {
                       Console.WriteLine("unvalid entry");
                   }
                   
               
        // ----------------------------------------exercise 7--------------------------------
           
                    // asking the user to enter their age 

                    Console.WriteLine("Please enter your age: ");
                    int NewAge = int.Parse(Console.ReadLine());
                    
                    // determine ticket price according to age 
                    if (NewAge <=12)
                    {
                        Console.WriteLine("category: children" );
                        Console.WriteLine("Ticket price: 2.00 OMR ");
                    }
                    else if( NewAge >= 13 && NewAge <= 59)
                    {
                        Console.WriteLine("category: Adults");
                        Console.WriteLine("Ticket price: 5.00 OMR ");
                    }
                    else if (NewAge>= 60)
                    {
                        Console.WriteLine("category:Seniors");
                        Console.WriteLine("Ticket price: 3.00 OMR ");
                    }
                    else
                    {
                        Console.WriteLine("unvalid entry");
                    }
                    
       
        // ----------------------------------------exercise 8--------------------------------
                    Console.WriteLine("Please enter your total bill mount: ");
                    double bill = double.Parse(Console.ReadLine());
                    Console.WriteLine("are you a loyality member? (true/ false) ");
                    bool isMember = bool.Parse(Console.ReadLine());

                    if (bill > 20 && isMember== true )
                    {
                        Console.WriteLine("your bill is: " + bill);
                        Console.WriteLine("discount 15%");
                        Console.WriteLine("Final Price: " +  bill * 0.85);
                        
                    }
                    else
                    {
                        Console.WriteLine("discount does not apply");
                        Console.WriteLine("Final Price: " +  bill);
                    }
                        
                       
        // ----------------------------------------exercise 9--------------------------------
        
                Console.WriteLine("plese enter the day number: ");
                int dayNumber = int.Parse(Console.ReadLine());


                switch (dayNumber)  
                {
                    case 1: Console.WriteLine("Sunday"); 
                        break;
                    case 2: Console.WriteLine("Monday"); 
                        break;
                    case 3: Console.WriteLine("Tuesday"); 
                        break;
                    case 4: Console.WriteLine("Wednesday"); 
                        break;
                    case 5: Console.WriteLine("Thursday"); 
                        break;
                    case 6: Console.WriteLine("Friday"); 
                        break;
                    case 7: Console.WriteLine("Saturday"); 
                        break;
                    default: Console.WriteLine("Invalid day number"); 
                        break;
                }
                 
        // ----------------------------------------exercise 10--------------------------------
                    Console.WriteLine("Please enter the first number: ");
                    int firstNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter the second number: ");
                    int secondNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please choose your desired operation (+, - , *, / %) ");
                    string operation = Console.ReadLine();

                    switch (operation)
                    {
                        case "+":
                            Console.WriteLine("the answer is : " + firstNumber + secondNumber);
                            break;

                        case "*":
                            Console.WriteLine("the answer is : " + firstNumber * secondNumber);
                            break;
                        case "-":
                            Console.WriteLine("the answer is : " + (firstNumber - secondNumber));
                            break;
                        case "/":
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Cannot devide by zero");
                            }
                            else
                            {
                                Console.WriteLine("the answer is : " + firstNumber * secondNumber);
                            }

                            break;
                        case "%":
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Cannot devide by zero");
                            }
                            else
                            {
                                Console.WriteLine("the answer is : " + firstNumber * secondNumber);
                            }

                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;

                    }
                     
        // ----------------------------------------exercise 11-----------------------------------
        
        Console.WriteLine("Welcome to the bank!");
        Console.WriteLine("please answer these three questions");
        Console.WriteLine("How old are you?");
        int LoanAge = int.Parse(Console.ReadLine());
        Console.WriteLine("how much is your monthly income? ");
        int MonthlyIncome = int.Parse(Console.ReadLine());
        Console.WriteLine("Do you have an existing loan? (true/ false)");
        bool ExistingLoan = bool.Parse(Console.ReadLine());


        if (LoanAge < 21 || LoanAge > 60) 
        {
            Console.WriteLine("sorry age out of range!");
        }
        if (ExistingLoan == true)
        {
            Console.WriteLine("sorry! you already have a loan");
        }
        if(MonthlyIncome < 400)
        {
            Console.WriteLine("sorry income too low");
        }
        if (LoanAge >= 21 && LoanAge <= 60 && MonthlyIncome >= 400 && ExistingLoan == false)
        {
            Console.WriteLine("ok you can have a loan!");
        }
        
        // ----------------------------------------exercise 12-----------------------------------
           Console.WriteLine("Hello and welcome to our store ");
           Console.WriteLine("Please enter the region code (A, B, C)");
           string regionCode = (Console.ReadLine());
           Console.WriteLine("Please enter the package weight in Kg");
           double PackageWheight= double.Parse(Console.ReadLine());

           double AbaseCoast = 1.000;
           double BbaseCoast = 3.000;
           double CbaseCoast = 7.000;
           

           switch (regionCode)
           {
               case "A": Console.WriteLine("Region : Local");
                   
                   if (PackageWheight > 5 && PackageWheight < 10)
                   {
                       Console.WriteLine("cost before extra charge: "+ AbaseCoast + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 2) + " OMR");
                   }
                   else if (PackageWheight > 10 )
                   {
                       Console.WriteLine("cost before extra charge: " + AbaseCoast  + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 5 ) + " OMR");
                   }
                   else
                   {
                       Console.WriteLine("No extra charge !");
                       Console.WriteLine("cost  : " + (AbaseCoast) + " OMR");
                       
                   }
                   break;
               
               
               case "B": Console.WriteLine("Region : National");
                   
                   if (PackageWheight > 5 && PackageWheight < 10)
                   {
                       Console.WriteLine("cost before extra charge: "+ BbaseCoast + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 2) + " OMR");
                   }
                   else if (PackageWheight > 10 )
                   {
                       Console.WriteLine("cost before extra charge: " + BbaseCoast  + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 5 ) + " OMR");
                   }
                   else
                   {
                       Console.WriteLine("No extra charge !");
                       Console.WriteLine("cost  : " + (BbaseCoast) + " OMR");
                       
                   }
                   break;
               
               case "C": Console.WriteLine("Region : International");
                   
                   if (PackageWheight > 5 && PackageWheight < 10)
                   {
                       Console.WriteLine("cost before extra charge: "+ CbaseCoast + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 2) + " OMR");
                   }
                   else if (PackageWheight > 10 )
                   {
                       Console.WriteLine("cost before extra charge: " + CbaseCoast  + " OMR");
                       Console.WriteLine("cost after   : " + (PackageWheight + 5 ) + " OMR");
                   }
                   else
                   {
                       Console.WriteLine("No extra charge !");
                       Console.WriteLine("cost  : " + (CbaseCoast) + " OMR");
                       
                   }
                   break;
                   }
                
               // ----------------------------------------exercise 13-----------------------------------
               Console.WriteLine("please enter first length: ");
               int lng1 = int.Parse(Console.ReadLine());
               Console.WriteLine("please enter second length: ");
               int lng2 = int.Parse(Console.ReadLine());
               Console.WriteLine("please enter third length: ");
               int lng3 = int.Parse(Console.ReadLine());

               if ((lng1 + lng2) > lng3 && (lng2 + lng3) > lng1 && (lng1 + lng3) > lng2)
               {
                   Console.WriteLine("valid triangle");

                   if (lng1 == lng2 && lng1 == lng3)
                   {
                       Console.WriteLine("Equilateral");
                   }
                   else if (lng1 == lng2 || lng1 == lng3 || lng2 == lng3)
                   {
                       Console.WriteLine("Isosceles");
                   }
                   else
                   {
                       Console.WriteLine("Scalene");
                   }
               }
               else
               {
                   Console.WriteLine("invalid triangle");
               }
               */
               
               // ----------------------------------------exercise 14 -----------------------------------
               
               Console.WriteLine("Single item check out ");
               Console.WriteLine("please enter product code:");
               Console.WriteLine("1: Headphones");
               Console.WriteLine("2: Keyboard");
               Console.WriteLine("3: Mouse");
               int productCode = int.Parse(Console.ReadLine());
               Console.WriteLine("enter quantity of product");
               int quantity = int.Parse(Console.ReadLine());
               Console.WriteLine("do you have discount code? (yes/no)");
               string discountCode = Console.ReadLine();
               double headphonecost = 8.500;
               double keyboardcost = 12.00;
               double mousecost = 5.00;
               double Subtotal = 0;
               double tax = 0;
               double discountAmount = 0;
               double finalTotal = 0;

               switch (productCode)
               {
                   case 1:
                       Console.WriteLine("Your product cost : " + headphonecost);
                       Subtotal = headphonecost * quantity;
                       break;
                   case 2:
                       Console.WriteLine("Your product cost : " + keyboardcost);
                       Subtotal = keyboardcost * quantity;
                       break;
                   case 3:
                       Console.WriteLine("Your product cost : " + mousecost);
                       Subtotal = mousecost * quantity;
                       break;
                   default:
                       Console.WriteLine("Invalid product code");
                       break;
               }

               if (productCode == 1 || productCode == 2 || productCode == 3)
               {
                   if (discountCode == "yes" && Subtotal > 20)
                   {
                       discountAmount = Subtotal * 0.10;
                   }

                   double afterDiscount = Subtotal - discountAmount;
                   tax = afterDiscount * 0.05;
                   finalTotal = afterDiscount + tax;

                   Console.WriteLine("Subtotal : " + Subtotal);
                   Console.WriteLine("Discount : " + discountAmount);
                   Console.WriteLine("Tax : " + tax);
                   Console.WriteLine("Final total : " + finalTotal);
               }
               
               
              
    }
}