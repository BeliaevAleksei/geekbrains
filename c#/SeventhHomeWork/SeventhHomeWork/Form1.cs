using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SeventhHomeWork
{
    public partial class Form1 : Form
    {
        Stack<int> numbers = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
            btnAddOne.Text = "+1";
            btnDouble.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            lblCountClick.Text = "0";
            this.Text = "Удвоитель";
            btnAddOne.Enabled = false;
            btnDouble.Enabled = false;
            btnReset.Enabled = false;
            btnRevert.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            ResultLabel.Text = rnd.Next(1, 300).ToString();
            lblNumber.Text = "1";
            lblCountClick.Text = "0";
            btnAddOne.Enabled = true;
            btnDouble.Enabled = true;
            btnReset.Enabled = true;
            winLabel.Visible = false;
            ClearStack();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            int currentNumber = int.Parse(lblNumber.Text);
            AddToNumbers(currentNumber);
            lblNumber.Text = (currentNumber + 1).ToString();
            lblCountClick.Text = (int.Parse(lblCountClick.Text) + 1).ToString();
            ValidateResult();
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            int currentNumber = int.Parse(lblNumber.Text);
            AddToNumbers(currentNumber);
            lblNumber.Text = (currentNumber * 2).ToString();
            lblCountClick.Text = (int.Parse(lblCountClick.Text) + 1).ToString();
            ValidateResult();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCountClick.Text = "0";
            ClearStack();
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (this.numbers.Pop()).ToString();
            lblCountClick.Text = (int.Parse(lblNumber.Text) - 1).ToString();
            ValidateRevertBtn();
        }

        private void ClearStack()
        {
            this.numbers.Clear();
            btnRevert.Enabled = false;
        }
        private void AddToNumbers(int number)
        {
            this.numbers.Push(number);
            ValidateRevertBtn();
        }
        private void ValidateRevertBtn()
        {
            if (this.numbers.Count > 0)
            {
                btnRevert.Enabled = true;
            }
            else
            {
                btnRevert.Enabled = false;
            }
        }

        private void ValidateResult()
        {
            if (int.Parse(ResultLabel.Text) == int.Parse(lblNumber.Text))
            {
                winLabel.Visible = true;
            }
        }
    }
}
