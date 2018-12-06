using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCiv
{
    public partial class Civilization : Form
    {
        Game game = new Game();
        AuthorizationSettings settings = new AuthorizationSettings();
        public Civilization()
        {
            InitializeComponent();

            //lCountry = settings.Civilization;
            trackArmy.Minimum = game.MinCountArmy;
            trackArmy.Maximum = game.MaxCountArmy;
            trackTerritories.Minimum = game.MinCaptured;
            trackTerritories.Maximum = game.MaxCaptured;
            trackWarrios.Minimum = game.MinCountWarrios;
            trackWarrios.Maximum = game.MaxCountWarrios;

            
        }

        private void bBuy_Click(object sender, EventArgs e)
        {
            game.Army += trackArmy.Value;
            lArmy.Text = (trackArmy.Value).ToString();
        }

        private void bSchool_Click(object sender, EventArgs e)
        {
            game.School += 1;
            if ((game.School) == 10)
                game.Education += 5;
        }

        private void bChurch_Click(object sender, EventArgs e)
        {
            game.Church += 1;
            if ((game.Church) == 5)
                game.Religion += 10;
        }

        private void bBur_Click(object sender, EventArgs e)
        {
            game.Bar += 1;
            if ((game.Bar) == 20)
                game.HappinessLvl += 10;
        }
    }
}
