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
    public partial class TheoryForm : Form
    {
        GameUser curUser;
        string selectedTopic;
        string[] Lists;
        int i = 0;
        public TheoryForm(GameUser cu, string sT)
        {
            InitializeComponent();
            curUser = cu;
            selectedTopic = sT;
            Lists = Directory.GetFiles(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Теория");
            pictureBoxTheory.Visible = false;
            textBoxTheory.Visible = false;
            textBoxTheory.ScrollBars = ScrollBars.Vertical;
            ButtonBack.Visible = false;
            switch (Lists.Length)
            {
                case 0:
                    ButtonForward.Visible = false;
                    textBoxTheory.Visible = true;
                    textBoxTheory.Text = "Теория отсутствует";
                    break;
                case 1:
                    ButtonForward.Visible = false;
                    ShowList(Lists[0]);
                    break;
                default:
                    ShowList(Lists[0]);
                    break;
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

        private void ButtonForward_Click(object sender, EventArgs e)
        {
            i++;
            ShowList(Lists[i]);
            if (i == Lists.Length - 1)
            {
                ButtonForward.Visible = false;
            }
            if (i > 0)
            {
                ButtonBack.Visible = true;
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            i--;
            ShowList(Lists[i]);
            if (i < Lists.Length - 1)
            {
                ButtonForward.Visible = true;
            }
            if (i == 0)
            {
                ButtonBack.Visible = false;
            }
        }
        //____________________________________________________________________________________________________________
        private void ShowList(string s)
        {
            if (s.Contains("txt"))
            {
                textBoxTheory.Visible = true;
                pictureBoxTheory.Visible = false;
                textBoxTheory.Text = File.ReadAllText(s);
            }
            else
            {
                textBoxTheory.Visible = false;
                pictureBoxTheory.Visible = true;
                pictureBoxTheory.Image = new Bitmap(s);
            }
        }
    }
}
