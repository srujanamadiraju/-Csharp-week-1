using System;
namespace student_proj
{
  class Program
  {
    static void Main(string [] args)
    {  
      //PROGRAM 2
      Console.WriteLine("enter the no of matches :");
      int Y = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("enter the no of points:");
      int X = Convert.ToInt32(Console.ReadLine());
      int count;
      // cases available:
      string possibility= " "; 
      switch(possibility)
      {
        case "Win":
        count =2;
        break;
        case "Tie":
        count =1;
        break;
        case "lose":
        count=0;
        break;
        default:
        count=-1;
        break; 
      }
      
      int average ;
      average = (X+Y)/2;
      Console.WriteLine(average);



// PROGRAM 1
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