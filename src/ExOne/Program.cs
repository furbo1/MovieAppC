using System;

namespace ExOne
{
    class Program
    {

        // static Group group = new Group();
        static void Main(string[] args)
        {
           
           do 
           {
                MainMenu();
               UserAction();
           }
           while(true);

             static void MainMenu()
           {
               Console.WriteLine("Welcome to Hollywood Cinema menu!\nPrices: Regular -120Kr, Youth - 80Kr , Retired- 90Kr");
               Console.WriteLine("1.Press '1' to enter your age.");
               Console.WriteLine("2.Groups- Press '2' to enter ages for each person in the group.");
               Console.WriteLine("3.Press '0' to exit");
           }
            
          
             static void  UserAction()
           {  
            //    string input = Console.ReadLine();
            //     int num = Int32.Parse(input);
               switch(Console.ReadLine())
               {
                 case "0":
                    Environment.Exit(0);
                    break;
                 case "1":
                    Console.WriteLine("Please enter your age below:");
                    CheckAgeAndPrintTicketPrice() ;
                    break;
                case "2":
                    // Console.WriteLine("Please enter your ages below:");
                    CheckAgeAndPrintGroupTicketPrice() ;
                    break;
                 default:
                   Console.WriteLine("Please enter 0, 1 or 2 only\n");
                   break;
               }
               
           }
            static void CheckAgeAndPrintTicketPrice()
           {
               string input = Console.ReadLine();
               int age = Int32.Parse(input);
                if (age <= 0 )
               {
                   Console.WriteLine("Enter a valid age \n");

               } else if (age > 63)
               {
                   Console.WriteLine("Pensioner price: 90kr \n");
               } else if ( age > 0 && age < 20)
               {
                   Console.WriteLine("Youth price: 80kr \n");
               }else if (age >=20 && age < 64)
               {
                   Console.WriteLine("Regular price: 120Kr \n");
               } 
               else 
               {
                   Console.WriteLine("Please enter a valid age! \n");
               }
           }

             static void CheckAgeAndPrintGroupTicketPrice()
           {
             
                Console.WriteLine("Enter Ages for all members of your group:");
                Console.WriteLine("Press 'Q' when you are done");

                string input = Console.ReadLine();
                int age;
                int total = 0;
               
                var isNumeric = int.TryParse(input, out age);
                if(input == "Q")
                {
                     MainMenu();
                     UserAction();
                    
                  
                   
                } else if(!isNumeric)
                {
                     Console.WriteLine("Please enter a valid number!");
                     
                } else
                 {
                     CheckAgeAndPrintGroupTicketPrice();
                    
                     do {
                         
                     if(age <= 0)
                         {
                             Console.WriteLine("Please enter a valid age!"); 
                            
                         } else if( age < 20)
                         {
                             total += 80;
                            
                         }else if (age >=20 && age < 64)
                         {
                              total+= 120;
                             
                         }else if (age > 63)
                         {
                              total+= 90;
                             
                             
                         }
                         

                         }while(isNumeric);
                       
                      Console.WriteLine($"Group total payment is {total}");
                 } 
                 
                    
                      
                }

           }
            
          
        }
    }