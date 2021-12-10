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
        "Total Cost: {0}", total
      );
    }
  }

  private static int TotalOrder()
  {
    int total = 0;

    //check loaves and pastries

    return total;
  }
}

// bool waitInput = true;
// char inputChar;
// while (waitInput)
// {
//   inputChar = Console.ReadKey(true).KeyChar;
//   if (inputChar == 'M' || inputChar == 'O')
//   {
//     Console.WriteLine("yay");
//     waitInput = false;
//   }
// }