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
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            Civilization civ_form1 = new Civilization();
            civ_form1.Show();
            this.Hide();
        }
    }
}
