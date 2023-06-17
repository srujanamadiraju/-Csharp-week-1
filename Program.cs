using System;
namespace student_proj
{
  class Program
  {
    static void Main(string [] args)
    {  
      //PROGRAM 1
       Console.WriteLine("enter number:");
         int n = Convert.ToInt32(Console.ReadLine());
         int fact=1;
         int flag =0;
         for (int i=n; i>0;i--)
         {
          fact =fact*i;
         }
         Console.WriteLine("the factorial is " +fact);
         // to find the number of trailing zeroes 
         while(fact!=0)
         {
              if(fact%10==0)
              {
                flag++;
                fact=fact/10;
              }
              else 
              {
                break;
              }
         }
         Console.WriteLine("the number of zeroes in the factorial number is: "+ flag);



     



    }
  }
}