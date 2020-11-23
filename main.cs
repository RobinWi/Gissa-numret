using System;

class MainClass {
  public static void Main (string[] args) {
    Random r = new Random();

    int vinnNum = r.Next(0, 100);

    bool vinn = false;

    CurrentGuess = Int32.Parse(Console.ReadLine());

    do
    {
      Console.Write("gissa ett nummer mellan 0 till 100: ");
      string s = Console.ReadLine();

      int i = int.Parse(s);
      if (i > vinnNum)
      {
        Console.WriteLine("För högt! Gissa igen: ");
      }
      else if (i < vinnNum)
      {
        Console.WriteLine("För lågt! Gissa igen: ");
      }
      else if (i == vinnNum)
      {
        Console.WriteLine("Grattis du gissade rätt!");
        vinn = true;
      }

    }
    while (vinn == false);
    Console.ReadLine();
    Console.WriteLine("Antal gissningar: " + CurrentGuess);
  }
}