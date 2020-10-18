using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        int resultValue;
        public Form1()
        {
            InitializeComponent();
            workLabel.Text = "The computer guessed a number from 1 to 100.You must guess this number";
            Random rnd = new Random();
            resultValue = rnd.Next(1, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startLabel.Visible = true;
            resValue.Visible = true;
            int inputValue = int.Parse(inputBox.Text);
            if (inputValue == resultValue)
            {
                resValue.Text = "matches!";
            }
            else if(inputValue < resultValue)
            {
                resValue.Text = "less";
            }
            else
            {
                resValue.Text = "greater";
            }    
        }
    }
}
