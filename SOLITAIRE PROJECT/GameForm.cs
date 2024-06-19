using SOLITAIRE_PROJECT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOLITAIRE_PROJECT
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            PlayingCard p = new PlayingCard();
            p.Parent = this;
            p.Top = 100;
            p.Left = 100;
            p.Visible = true;
            this.Controls.Add(p);
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
