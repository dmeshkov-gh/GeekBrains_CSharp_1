using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoublerWF
{
    public partial class Form1 : Form
    {
        Doubler doubler;
        public Form1()
        {
            InitializeComponent();
        }
        private void CheckEndGame()
        {
            if(doubler.Steps > doubler.MinimalSteps)
            {
                MessageBox.Show("You lose! Too many steps!", "Bad luck!");
                TurnBottons(false);
            }
            if(doubler.Finish == doubler.Current)
            {
                MessageBox.Show("You win!", "Congratulations!");
                TurnBottons(false);
            }
            if (doubler.Finish < doubler.Current)
            {
                MessageBox.Show("Too many!", "Oooops!");
                TurnBottons(false);
            }
        }
        private void TurnBottons(bool IsTurnedOn)
        {
            btnBack.Enabled = IsTurnedOn;
            btnMulti.Enabled = IsTurnedOn;
            btnReset.Enabled = IsTurnedOn;
            btnPlus.Enabled = IsTurnedOn;  
        }
        private void StatusUpdate()
        {
            lblCurrent.Text = doubler.Current.ToString();
            lblFinish.Text = doubler.Finish.ToString();
            lblSteps.Text = doubler.Steps.ToString();
            lblMinimalSteps.Text = doubler.MinimalSteps.ToString();
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler();
            TurnBottons(true);
            MessageBox.Show("You should end the game within the least possible steps", "Game rules");
            doubler.Update += new Action(StatusUpdate);
            doubler.IsGameEnded += new Action(CheckEndGame);
            StatusUpdate();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            doubler.Plus();
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            doubler.Multi();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            doubler.Back();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doubler.Reset();
        }

    }
}
