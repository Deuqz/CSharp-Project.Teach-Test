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
    public partial class RatingForm : Form
    {
        GameUser curUser;
        string selectedTopic;
        public RatingForm(GameUser cU, string sT)
        {
            InitializeComponent();
            curUser = cU;
            selectedTopic = sT;
            if (File.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Результаты.ini"))
            {
                TakeUsers();
            }
            else
            {
                MessageBox.Show("Не удалось загрузить результаты. Не найдет файл \"Результаты.ini\"\n "
                    + $" по адресу: {Directory.GetCurrentDirectory()}\\Resources\\Темы\\{selectedTopic}\\");
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
        private void ButtonToChooseTheoryAndExercisesForm_Click(object sender, EventArgs e)
        {
            this.Close();
            ChooseTheoryAndExercisesForm ctaef = new ChooseTheoryAndExercisesForm(curUser, selectedTopic);
            ctaef.Show();
        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();//!!!!
            }
        }
        //__________________________________________________________________________________________________
        private void TakeUsers()
        {
            try
            {
                string[] rating = File.ReadAllLines(Directory.GetCurrentDirectory()
                    + $@"\Resources\Темы\{selectedTopic}\Результаты.ini");
                List<string[]> users = new List<string[]>();
                foreach (string str in rating)
                {
                    users.Add(str.Split(new char[] { ' ' }));
                }
                for (int i=0; i < users.Count; i++)
                {
                    users[i][0] = BackToNormal(users[i][0]);
                    users[i][1] = BackToNormal(users[i][1]);
                }
                foreach (string[] str in users)
                {
                    RatingView.Rows.Add(str);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка программы!");
            }
        }
        private string BackToNormal(string s)
        {
            if (s.Contains("_"))
            {
                s = s.Replace("_", " ");
            }
            return s;
        }
    }
}
