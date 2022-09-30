using System;
using Bakery;

/*     Console-UI Logic     */ 
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      int qtyBread = 0; 
      int qtyPastry = 0; 

      Console.WriteLine("Welcome to Pierre's Bakery!"); 
      Console.WriteLine("Baseline Prices:  ");
      Console.WriteLine("1 Loaf of Bread - $5");
      Console.Write("1 Pastry - $2 \n\n");
      Console.WriteLine("'Buy 2, Get 1 Free' Deals!--  "); 
      Console.WriteLine("Buy 2 Loaves of Bread, Get 1 Free! - $10"); 
      Console.Write("Buy 2 Pastries, Get 1 Free! - $5 \n\n\n"); 

      Console.WriteLine("How many Loaves of Bread do you want?");
      qtyBread = int.Parse(Console.ReadLine());
      Console.WriteLine("Okay. How about Pastries?");
      qtyPastry = int.Parse(Console.ReadLine()); 
      Console.WriteLine("Alright, we'll get everything started for you.  Here's your receipt!");
      
      Bread breadOrder = new Bread(qtyBread); 
      Pastry pastryOrder = new Pastry(qtyPastry); 
      int breadTotalPrice = breadOrder.DetermineTotalPrice();
      int pastryTotalPrice = pastryOrder.DetermineTotalPrice();

      Console.Write("\n\nYour Order (with Totals)-- \n");
      Console.Write("Bread:  "); 
      if(qtyBread==1){
        Console.Write(qtyBread + " Bread Loaf =  $" + breadTotalPrice);  
      } else {
        Console.Write(qtyBread + " Bread Loaves =  $" + breadTotalPrice);
      }

      if(qtyPastry==1){
        Console.Write("\nPastry:  "); 
        Console.WriteLine(qtyPastry + " Pastry =  $" + pastryTotalPrice);  
      } else { 
        Console.Write("\nPastries:  ");
        Console.WriteLine(qtyPastry + " Pastries =  $" + pastryTotalPrice);
      } 
      Console.WriteLine("Grand Total:  $" + (breadTotalPrice + pastryTotalPrice));
      Console.Write("\n\n\nThank you, come again!");
    }
  }
}
