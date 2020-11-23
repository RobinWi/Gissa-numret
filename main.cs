using System;

class MainClass {
  public static void Main (string[] args) {
    Random r = new Random();

    int vinnNum = r.Next(0, 100);

    bool vinn = false;

    int Gissningar = 0;

    do
    {
      Console.Write("gissa ett nummer mellan 0 till 100: ");
      string s = Console.ReadLine();

      int i = int.Parse(s);
      if (i > vinnNum)
      {
        Console.WriteLine("För högt! ");
        Gissningar++;
      }
      else if (i < vinnNum)
      {
        Console.WriteLine("För lågt! ");
        Gissningar++;
      }
      else if (i == vinnNum)
      {
        Console.WriteLine("Grattis du gissade rätt!");
        Gissningar++;
        vinn = true;
        Console.WriteLine("Antalet gissninger: " + Gissningar);

      }

    }
    while (vinn == false);
    Console.ReadLine();
  }
}