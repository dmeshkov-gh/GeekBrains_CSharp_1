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
        void StatusUpdate()
        {
            lblCurrent.Text = doubler.Current.ToString();
            lblFinish.Text = doubler.Finish.ToString();
            lblSteps.Text = doubler.Steps.ToString();
            lblMinSteps.Text = doubler.MinimalSteps.ToString();
        }
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doubler = new Doubler();
            doubler.Update += new Action(StatusUpdate);
            StatusUpdate();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btbPlus_Click(object sender, EventArgs e)
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
