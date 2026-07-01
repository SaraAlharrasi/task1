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
                   */
               
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
        
    }
}