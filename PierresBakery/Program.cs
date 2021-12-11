using PierresBakery.Models;
using System;
using System.Collections.Generic;

public class Program
{
  private static Dictionary<char, string> _menuItems = new Dictionary<char, string> {
    {'1', "Challah"},
    {'2', "Rye"},
    {'3', "Baguette"},
    {'4', "Olive Loaf"},
    {'5', "Eclair"},
    {'6', "Pain au Chocolat"},
    {'7', "Apple Turnover"}
  };
  private static bool _firstWrite = true;
  public static void Main()
  {
    if (_firstWrite == true)
    {
      Console.WriteLine(
        "====================================================\n" +
        "     ---*** Welcome to Pierre's Bakery! ***---"
        );
      _firstWrite = false;
    }

    Console.WriteLine(
      "====================================================\n\n" +
      "Today's Menu:\n\n" +
      "Bread - $5 each, every 3rd loaf is free.\n" +
      "1. {0}   2. {1}   3. {2}   4. {3}\n\n" +
      "Pastry - $2 each, every 3rd pastry is $1 (3 for $5).\n" +
      "5. {4}   6. {5}   7. {6}\n\n" +
      "====================================================\n\n" +
      "Please type a number to add the item to your order.\n",
      _menuItems['1'], _menuItems['2'], _menuItems['3'], _menuItems['4'], _menuItems['5'], _menuItems['6'], _menuItems['7']);
    
    if (OrderNotEmpty())
    {
      Console.WriteLine(
        "Total Cost: ${0}\n" +
        "Type O to see a detailed order.\n" +
        "Type R to remove an item from order.\n" +
        "Type C to check out and start over.\n",
        TotalOrder());
    }

    HandleInput();
    Main();
  }

  private static bool OrderNotEmpty()
  {
    return Bread.Loaves.Count > 0 || Pastry.Pastries.Count > 0;
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
        DisplayOrder();
        waitInput = false;
      }
      else if (inputChar == 'r' || inputChar == 'R')
      {
        HandleRemove();
        waitInput = false;
      }
      else if (inputChar == 'c' || inputChar == 'C')
      {
        ClearOrder();
        waitInput = false;
      }
      else if ('1' <= inputChar && inputChar <= '4')
      {
        string breadName = _menuItems[inputChar];
        Bread newBread = new Bread(breadName);
        Console.WriteLine(
          "====================================================\n\n" +
          "Adding one {0} to order for ${1}\n", 
          breadName, newBread.Price);
        waitInput = false;
      }
      else if ('5' <= inputChar && inputChar <= '7')
      {
        string pastryName = _menuItems[inputChar];
        Pastry newPastry = new Pastry(pastryName);
        Console.WriteLine(
          "====================================================\n\n" +
          "Adding one {0} to order for ${1}\n",
          pastryName, newPastry.Price);
        waitInput = false;
      }
    }
    
  }
  private static void DisplayOrder()
  {
    if (OrderNotEmpty())
    {
      Console.WriteLine(
        "====================================================\n\n" +
        "Detailed Order:\n"
        );
      if (Bread.Loaves.Count > 0)
      {
        foreach (Bread loaf in Bread.Loaves)
        {
          Console.WriteLine("{0}: ${1}", loaf.Name, loaf.Price);
        } 
      }
      if (Pastry.Pastries.Count > 0)
      {
        foreach (Pastry pastry in Pastry.Pastries)
        {
          Console.WriteLine("{0}: ${1}", pastry.Name, pastry.Price);
        } 
      }
      Console.WriteLine("\nTotal: ${0}\n", TotalOrder());
    }
    else
    {
      Console.WriteLine(
        "====================================================\n\n" +
        "No items have been ordered yet.\n"
        );
    }
  }

  private static void HandleRemove()
  {
    Console.WriteLine(
      "====================================================\n\n" +
      "Please type a number to remove that item.\n" +
      "Press M to return to Menu without removing any item.\n"
      );
    bool waitInput = true;
    char inputChar;
    while (waitInput)
    {
      inputChar = Console.ReadKey(true).KeyChar;
      if (inputChar == 'm' || inputChar == 'M')
      {
        waitInput = false;
      }
      else if ('1' <= inputChar && inputChar <= '4')
      {
        string breadName = _menuItems[inputChar];
        Bread foundBread = Bread.Loaves.Find(loaf => loaf.Name == breadName);
        if (foundBread != null)
        {
          foundBread.RemoveLoaf();
          Console.WriteLine(
            "====================================================\n\n" +
            "Removing one {0} from order.\n",
            breadName);
        }
        else
        {
          Console.WriteLine(
            "====================================================\n\n" +
            "There is no {0} in the order to remove.\n",
            breadName);
        }
        waitInput = false; 
      }
      else if ('5' <= inputChar && inputChar <= '7')
      {
        string pastryName = _menuItems[inputChar];
        Pastry foundPastry = Pastry.Pastries.Find(pastry => pastry.Name == pastryName);
        if (foundPastry != null)
        {
          foundPastry.RemovePastry();
          Console.WriteLine(
            "====================================================\n\n" +
            "Removing one {0} from order.\n",
            pastryName);
        }
        else
        {
          Console.WriteLine(
            "====================================================\n\n" +
            "There is no {0} in the order to remove.\n",
            pastryName);
        }
        waitInput = false; 
      }
    }
  }

  private static void ClearOrder()
  {
    if (OrderNotEmpty())
    {
      Console.WriteLine(
        "====================================================\n\n" +
        "Your total is ${0}.\n" +
        "Thank you! Please come again!\n" +
        "(Type Control-C at any time to exit program.)\n\n" + 
        "====================================================\n\n\n\n",
        TotalOrder());
      Bread.ClearAll();
      Pastry.ClearAll();
      _firstWrite = true;
    }
    else
    {
      Console.WriteLine(
        "====================================================\n\n" +
        "No items have been ordered yet.\n"
        );
    }
  }
}
