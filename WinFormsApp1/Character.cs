using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
  public class Character
  {
    public int HP;
    public int Speed;
    public string Name;
    public List<Ability> Abilities = new List<Ability>();

    public bool HitSuccess(int percent)
    {
      Random rand = new Random();
      if(rand.Next(1,101) <= percent)
      {
        return true;
      }

      return false;
    }
  
    public bool IsCritical(int crit)
    {
      Random rand = new Random();
      if(rand.Next(1,101) <= crit)
      {
        return true;
      }

      return false;
    }

    public int Attack(Ability ability)
    {
      int returnValue = 0;
      Random rand = new Random();

      if(HitSuccess(ability.AccBase))
      {
        if(IsCritical(ability.CritMod))
        {
          returnValue = rand.Next(ability.MinDmg, ability.MaxDmg + 1) * 2;
        }
        else
        {
          returnValue = rand.Next(ability.MinDmg, ability.MaxDmg + 1);
        }
      }

      return returnValue;
    }

    public void TakeDamage(int dmg)
    {
        HP -= dmg;
    }
  }
}
