using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
  public class Hellion : Character
  {
    TABLE_Abilities table = new TABLE_Abilities();

    public Hellion()
    {
      Name = "Hellion Test";
      HP = 26;
      Speed = 0;
      Abilities.Add(table.Abilities_Hellion[0]);
      Abilities.Add(table.Abilities_Hellion[1]);
    }

    public Hellion(string name)
    {
      Name = name;
      HP = 26;
      Speed = 0;
      Abilities.Add(table.Abilities_Hellion[0]);
      Abilities.Add(table.Abilities_Hellion[1]);
    }
  }
}
