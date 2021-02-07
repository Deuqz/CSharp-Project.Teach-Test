using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachTest
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            SetTextBoxes();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != "Введите имя" && surnameBox.Text != "Введите фамилию")
            {
                nameBox.BackColor = Color.FromArgb(170, 170, 180);
                nameBox.Enabled = false;
                surnameBox.BackColor = Color.FromArgb(170, 170, 180);
                surnameBox.Enabled = false;
                if (!Directory.Exists(Directory.GetCurrentDirectory() + @"\Resources"))
                {
                    MessageBox.Show($"Отсутствует папка \"Resources\" по адресу: {Directory.GetCurrentDirectory()}\\");
                    Application.Exit();
                }
                if (File.Exists(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt"))
                {
                    this.Hide();
                    TopicsForm tF = new TopicsForm(new GameUser(GetTextBoxStr(nameBox.Text), GetTextBoxStr(surnameBox.Text)));
                    tF.Show();
                }
                else
                {
                    MessageBox.Show($"Список тем отсутствует.\nНе найдет файл \"Topics.txt\" по адресу: {Directory.GetCurrentDirectory()}\\Resources\\");
                    nameBox.Enabled = true;
                    surnameBox.Enabled = true;
                    SetTextBoxes();
                    nameBox.BackColor = Color.White;
                    surnameBox.BackColor = Color.White;
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели данные.");
            }
        }
        private void nameBox_Enter(object sender, EventArgs e)
        {
            CursorEnterTextBox(nameBox, "Введите имя");
        }
        private void nameBox_Leave(object sender, EventArgs e)
        {
            CursorLeaveTextBox(nameBox, "Введите имя");
        }
        private void surnameBox_Enter(object sender, EventArgs e)
        {
            CursorEnterTextBox(surnameBox, "Введите фамилию");
        }
        private void surnameBox_Leave(object sender, EventArgs e)
        {
            CursorLeaveTextBox(surnameBox, "Введите фамилию");
        }
        private void EscPict_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Point pointTopPanel = new Point();
        private void TopText_MouseDown(object sender, MouseEventArgs e)
        {
            pointTopPanel = new Point(e.X, e.Y);
        }
        private void TopText_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - pointTopPanel.X;
                this.Top += e.Y - pointTopPanel.Y;
            }
        }
        private void ButtonTeacher_Click(object sender, EventArgs e)
        {
            this.Hide();
            PasswordForm pf = new PasswordForm();
            pf.Show();
        }
        //=======================================================================================//
        private void CursorEnterTextBox(TextBox box, string s)
        {
            if (box.Text == s)
            {
                box.Text = "";
                box.ForeColor = Color.Black;
            }
        }
        private void CursorLeaveTextBox(TextBox box, string s)
        {
            if (box.Text == "")
            {
                box.Text = s;
                box.ForeColor = Color.Gray;
            }
        }
        private void SetTextBoxes()
        {
            nameBox.Text = "Введите имя";
            nameBox.ForeColor = Color.Gray;
            surnameBox.Text = "Введите фамилию";    //Проблема: при загрузке фокусируется на nameBox. 
            surnameBox.ForeColor = Color.Gray;      //Поставил TabBox на False. Почему то теперь не фокусируется
        }
        private string GetTextBoxStr(string str)
        {
            if (str.Contains(" "))
            {
                str = str.Replace(" ","_");
            }
            return str;
        }
    }
}
