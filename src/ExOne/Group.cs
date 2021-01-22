// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace ExOne 
// {
//     class Group 
//     {
//         public  int CalculateGroupPrice(int age)
//            {
//                 string input = Console.ReadLine();
//                 int age;
//                 int total = 0;
               
//                 var isNumeric = int.TryParse(input, out age);
//                             if(age <= 0)
//                          {
//                               Console.WriteLine("Please enter a valid age!"); 
//                               return 0;
//                          } else if( age < 20)
//                          {
//                             return total += 80;
//                          }else if (age >=20 && age < 64)
//                          {
//                              return total+= 120;
//                          }else if (age > 63)
//                          {
//                              return total+= 90;
//                          }
//            }
//     }
// }