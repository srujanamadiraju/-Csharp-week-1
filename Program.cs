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

       


     



    }
  }
}