using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
  public class TABLE_Abilities
  {
    public List<Ability> Abilities_Hellion = new List<Ability>();
    public List<Ability> Abilities_Occultist = new List<Ability>();

    public TABLE_Abilities()
    {
      CreateHellionList();
      CreateOccultistList();
    }

    void CreateOccultistList()
    {
      int[] from = new int[4] { 0, 1, 1, 1 };
      int[] to = new int[4] { 1, 1, 1, 0 };

      Abilities_Occultist.Add(new Ability("Sacrificial Stab", 6, 12, 80, 9, from, to));

      from = new int[4] { 1, 1, 0, 0 };
      to = new int[4] { 0, 0, 1, 1 };

      Abilities_Occultist.Add(new Ability("Abyssal Artilery", 6, 12, 85, 0, from, to));


    }

    void CreateHellionList()
    {
      int[] from = new int[4] { 0,0,1,1};
      int[] to = new int[4] { 1,1,0,0};
      
      Abilities_Hellion.Add(new Ability("Wicked Hack", 6, 12, 85, 4,from , to));

      from = new int[4] { 0, 0, 0, 1 };
      to = new int[4] { 0, 0, 0, 1 };

      Abilities_Hellion.Add(new Ability("Iron Swan", 6, 12, 85, 5, from, to));


    }
  }
}
