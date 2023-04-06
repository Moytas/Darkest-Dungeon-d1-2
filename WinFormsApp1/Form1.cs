using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
  public partial class Form1 : Form
  {
    List<Button> PlayerTeamImages = new List<Button>();
    List<Character> PlayerTeam = new List<Character>();
    List<Button> OpponentTeamImages = new List<Button>();
    List<Character> OpponentTeam = new List<Character>();

    public Form1()
    {
      InitializeComponent();
      for (int i = 0; i < 4; i++)
      {
        PlayerTeam.Add(new Hellion());
      }

      for (int i = 0; i < 4; i++)
      {
        OpponentTeam.Add(new Hellion());
      }


      PlayerTeamImages.Add(button5);
      PlayerTeamImages.Add(button6);
      PlayerTeamImages.Add(button7);
      PlayerTeamImages.Add(button8);

      for (int i = 0; i < PlayerTeamImages.Count; i++)
      {
        PlayerTeamImages[i].Text = PlayerTeam[i].Name;
      }

      OpponentTeamImages.Add(button9);
      OpponentTeamImages.Add(button10);
      OpponentTeamImages.Add(button11);
      OpponentTeamImages.Add(button12);
    }

    void ShowPosition(int playerIndex,int abilityIndex)
    {
      for(int i = 0; i < PlayerTeam[playerIndex].Abilities[abilityIndex].PositionTo.Length; i++)
      {
        if(PlayerTeam[playerIndex].Abilities[abilityIndex].PositionTo[i] == 1)
        {
          OpponentTeamImages[i].BackColor = Color.Green;
        }
        else
        {
          OpponentTeamImages[i].BackColor = Color.Gray;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ShowPosition(0, 0);
    }
  }
}
