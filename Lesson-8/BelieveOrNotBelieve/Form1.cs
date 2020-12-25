using BelieveOrNotBelieve.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelieveOrNotBelieve
{
    public partial class Form1 : Form
    {
        TrueFalse databaseOfQuestions;
        public Form1()
        {
            InitializeComponent();
        }
        private void TurnButtons(bool IsTurned)
        {
            btnAdd.Enabled = IsTurned;
            btnRemove.Enabled = IsTurned;
            btnSave.Enabled = IsTurned;
            nudNumber.Enabled = IsTurned;
            cboxTrue.Enabled = IsTurned;
        }
        private void tsmiNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                databaseOfQuestions = new TrueFalse(saveFileDialog.FileName);
                databaseOfQuestions.AddQuestion("В Японии ученики на доске пишут кисточкой с цветными чернилами?", true);
                databaseOfQuestions.SaveAsXMLFormat();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                TurnButtons(true);
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = databaseOfQuestions[(int)nudNumber.Value - 1].Text;
            //cboxTrue.Checked = databaseOfQuestions[(int)nudNumber.Value - 1].TrueFalse;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(databaseOfQuestions == null)
            {
                MessageBox.Show("Create a new data base", "Message!");
                return;
            }
            databaseOfQuestions.AddQuestion(tboxQuestion.Text.ToString(), cboxTrue.Checked);
            nudNumber.Maximum = databaseOfQuestions.Count;
            nudNumber.Value = databaseOfQuestions.Count;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || databaseOfQuestions == null) return;
            databaseOfQuestions.RemoveQuestion((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (databaseOfQuestions != null) databaseOfQuestions.SaveAsXMLFormat();
            else MessageBox.Show("Data base has not been created");
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                databaseOfQuestions = new TrueFalse(openFileDialog.FileName);
                databaseOfQuestions.LoadFromXMLFormat();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = databaseOfQuestions.Count;
                nudNumber.Value = 1;
                TurnButtons(false);
                cboxTrue.Enabled = true;
                btnAnswer.Enabled = true;
            }
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            databaseOfQuestions[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            databaseOfQuestions[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            if(databaseOfQuestions[(int)nudNumber.Value-1].TrueFalse == cboxTrue.Checked)
            {
                MessageBox.Show("You're right!");
            }
            else
            {
                MessageBox.Show("Not correct!");
            }
            if (nudNumber.Value < nudNumber.Maximum)
                nudNumber.Value++;
            else
                tboxQuestion.Clear();
                TurnButtons(false);
        }
    }
}
