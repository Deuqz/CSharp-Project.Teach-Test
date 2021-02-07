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
    public partial class PasswordForm : Form
    {
        string password = "7890";
        public PasswordForm()
        {
            InitializeComponent();
            PasswordBox.Text = "Введите пароль";
            PasswordBox.ForeColor = Color.Gray;
            if (File.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Password.ini"))
            {
                string[] s = File.ReadAllLines(Directory.GetCurrentDirectory() + $@"\Resources\Password.ini");
                string[] s1 = s[0].Split(new char[] { ' ' });
                password = s1[s1.Length - 1].Trim();
            }
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
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm sf = new StartForm();
            sf.Show();
        }
        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Введите пароль")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
                PasswordBox.UseSystemPasswordChar = true;
            }
        }
        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Введите пароль";
                PasswordBox.ForeColor = Color.Gray;
                PasswordBox.UseSystemPasswordChar = false;
            }
        }
        private void ButtonContinue_Click(object sender, EventArgs e)
        {
            if(PasswordBox.Text == password)
            {
                this.Close();
                TeacherForm tf = new TeacherForm();
                tf.Show();
            }
            else
            {
                MessageBox.Show("Пароль неверный!");
            }
        }
    }
}
