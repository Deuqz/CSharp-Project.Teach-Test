using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachTest
{
    public partial class ChooseTheoryAndExercisesForm : Form
    {
        GameUser curUser;
        string selectedTopic;
        public ChooseTheoryAndExercisesForm(GameUser cu, string sT)
        {
            InitializeComponent();
            curUser = cu;
            selectedTopic = sT;
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
            TopicsForm TF = new TopicsForm(curUser);
            TF.Show();
        }
        private void TheoryBox_Click(object sender, EventArgs e)
        {
            TheoryBox.BorderStyle = BorderStyle.Fixed3D;
            if (Directory.Exists($@"{Directory.GetCurrentDirectory()}\Resources\Темы\{selectedTopic}\Теория"))
            {
                this.Close();
                TheoryForm TF = new TheoryForm(curUser, selectedTopic);
                TF.Show();
            }
            else
            {
                MessageBox.Show($"Отсутствует папка \"Теория\" по адресу:\n{Directory.GetCurrentDirectory()}\\Темы\\{selectedTopic}\\");
                TheoryBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        private void ExercisesBox_Click(object sender, EventArgs e)
        {
            ExercisesBox.BorderStyle = BorderStyle.Fixed3D;
            string[] strs = Directory.GetFiles($@"{Directory.GetCurrentDirectory()}\Resources\Темы\{selectedTopic}\Задания");
            if (Directory.Exists($@"{Directory.GetCurrentDirectory()}\Resources\Темы\{selectedTopic}\Задания")
                && strs.Length != 0)
            {
                this.Close();
                ExcercisesForm EF = new ExcercisesForm(curUser, selectedTopic);
                EF.Show();
            }
            else if (strs.Length == 0)
            {
                MessageBox.Show("Задания отсутствуют");
                ExercisesBox.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                MessageBox.Show($"Отсутствует папка \"Задания\" по адресу:\n{Directory.GetCurrentDirectory()}\\Темы\\{selectedTopic}\\");
                ExercisesBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }
    }
}
