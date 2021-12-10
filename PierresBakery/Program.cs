using PierresBakery.Models;
using System;

public class Program
{
  public static void Main()
  {
    Console.WriteLine(
      "====================================================\n" +
      "     ---*** Welcome to Pierre's Bakery! ***---\n" +
      "Today's Menu:\n\n" +
      "Bread - $5 each, every 3rd loaf is free.\n" +
      "1. Challah   2. Rye   3. Baguette   4. Olive Loaf\n\n" +
      "Pastry - $2 each, every 3rd pastry is $1 (3 for $5).\n" +
      "5. Eclair   6. Pan a Chocolat   7. Apple Turnover\n" +
      "====================================================\n\n" +
      "Please type a number to add the item to your order."
      );
    
    int total = TotalOrder();
    if (total > 0)
    {
      Console.WriteLine(
        "(Type O to see a detailed order.)\n" +
        "Total Cost: ${0}", total
      );
    }
    HandleInput();
    Main();
  }

  private static int TotalOrder()
  {
    int total = 0;
    if (Bread.Loaves.Count > 0)
    {
      foreach (Bread loaf in Bread.Loaves)
      {
        total += loaf.Price;
      } 
    }
    if (Pastry.Pastries.Count > 0)
    {
      foreach (Pastry pastry in Pastry.Pastries)
      {
        total += pastry.Price;
      } 
    }
    return total;
  }

  private static void HandleInput()
  {
    bool waitInput = true;
    char inputChar;
    while (waitInput)
    {
      inputChar = Console.ReadKey(true).KeyChar;
      if (inputChar == 'o' || inputChar == 'O')
      {
        // Display detailed order
        waitInput = false;
      }
      else if ('1' <= inputChar && inputChar <= '4')
      {
        string breadName = "";
        switch (inputChar)
        {
          case '1':
            breadName = "Challah";
            break;
          case '2':
            breadName = "Rye";
            break;
          case '3':
            breadName = "Baguette";
            break;
          case '4':
            breadName = "Olive Loaf";
            break;
        }
        Bread newBread = new Bread(breadName);
        Console.WriteLine("\nAdding one {0} to order for ${1}\n", breadName, newBread.Price);
        waitInput = false;
      }
      else if ('5' <= inputChar && inputChar <= '7')
      {
        string pastryName = "";
        switch (inputChar)
        {
          case '5':
            pastryName = "Eclair";
            break;
          case '6':
            pastryName = "Pan a Chocolat";
            break;
          case '7':
            pastryName = "Apple Turnover";
            break;
        }
        Pastry newPastry = new Pastry(pastryName);
        Console.WriteLine("\nAdding one {0} to order for ${1}\n", pastryName, newPastry.Price);
        waitInput = false;
      }
    }
  }
}
