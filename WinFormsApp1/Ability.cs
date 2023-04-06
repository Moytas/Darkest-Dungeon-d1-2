using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
  public class Ability
  {
    public string Name;
    public int MinDmg, MaxDmg;
    public int AccBase, CritMod;
    public int[] PositionFrom = new int[4];
    public int[] PositionTo = new int[4];

    public Ability(string name,int min,int max,int acc,int crit,int[] from,int[] to)
    {
      Name = name;
      MinDmg = min;
      MaxDmg = max;
      AccBase = acc;
      CritMod = crit;
      PositionFrom = from;
      PositionTo = to;
    }
  }
}
