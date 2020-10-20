using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastHomeWork
{
    public partial class Form1 : Form
    {
        // База данных с вопросами
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
            groupBox2.Enabled = false;
            tboxQuestion.Enabled = false;
        }
        // Обработчик пункта меню Exit
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Обработчик пункта меню New
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }
        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }
        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }
        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }
        // Обработчик пункта меню Save
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }
        // Обработчик пункта меню Open
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                if (database.Count > 0)
                {
                    nudNumber.Minimum = 1;
                    nudNumber.Maximum = database.Count;
                    nudNumber.Value = 1;
                    groupBox2.Enabled = true;
                    tboxQuestion.Enabled = true;
                    tboxQuestion.Text = database[0].Text;
                }
                else
                {
                    MessageBox.Show("База пуста", "Сообщение");
                    return;
                }
            }
        }
        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 about = new Form2();
            about.Show();
        }
    }
}
