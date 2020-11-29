using System;

class MainClass {
  public static void Main (string[] args) {
    Random r = new Random(); // Gör så att r är Random

    int vinnNum = r.Next(1, 100); // Gör att random väljer slumpmässigt mellan 1-100 som blir det vinnande nummret

    bool vinn = false; // Säger att vinn är falskt alltså fel nummer

    int Gissningar = 0; // Säger åt att räkna hur många gissningar som gjorts

    do
    {
      Console.Write("gissa ett nummer mellan 0 till 100: "); // 
      string s = Console.ReadLine();

      int i = int.Parse(s); // Att int.Parse(s) är i
      if (i > vinnNum) // Säger åt att i är större än de vinnande nummret
      {
        Console.WriteLine("För högt! "); // Visar att det gissande talet är för högt
        Gissningar++; // Räknar Gissningar när gissningen är för hög
      }
      else if (i < vinnNum) // Säger åt att i är mindre än de vinnande nummret
      {
        Console.WriteLine("För lågt! "); // Visar att det gissande talet är för lågt
        Gissningar++; // Räknar Gissningar när gissningen är för låg 
      }
      else if (i == vinnNum) // säger åt att i är lika mycket som de vinnande nummret
      {
        Console.WriteLine("Grattis du gissade rätt!"); // visar att man har gissat rätt nummer
        Gissningar++; // Räknar gissningen som blir den vinnande gissningen
        vinn = true; // Säger att vinn är sant alltså de rätta nummret
        Console.WriteLine("Antalet gissninger: " + Gissningar); // visar antalet gissningar

      }

    }
    while (vinn == false);
  }
}