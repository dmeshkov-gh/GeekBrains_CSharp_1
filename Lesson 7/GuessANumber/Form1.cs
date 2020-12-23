using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GuessANumber.Model;

namespace GuessANumber
{
    public partial class Form1 : Form
    {
        Number guesser = new Number();
        public Form1()
        {
            InitializeComponent();
            guesser.MyMessage += new Number.Message(ChangeMessage);
            guesser.IsGameEnded += new Action(GameEnded);
        }

        private void GameEnded()
        {
            textboxMyNumber.Visible = false;
            btnStart.Visible = true;
        }

        private void ChangeMessage(string message)
        {
            lblInfo.Text = message;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "You shoud guess a number from 1 to 100";
            textboxMyNumber.Visible = true;
            btnStart.Visible = false;
        }

        private void textboxMyNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                textboxMyNumber.Clear();
                guesser.CheckNumber();
            }
        }

        private void textboxMyNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                guesser.MyNumber = Int32.Parse(textboxMyNumber.Text);
            }
            catch
            {
                lblInfo.Text = "You should enter numbers!";
                textboxMyNumber.Clear();
            }
        }
    }
}
