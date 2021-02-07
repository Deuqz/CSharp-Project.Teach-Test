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
    public struct GameUser
    {
        public string Name;
        public string Surname;
        public GameUser(string n, string s)
        {
            Name = n;
            Surname = s;
        }
    };
    public partial class TopicsForm : Form
    {
        GameUser curUser;
        public TopicsForm(GameUser curUser1)
        {
            InitializeComponent();
            curUser = curUser1;
        }

        private void TopicsForm_Load(object sender, EventArgs e)
        {
            string[] topics = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt");
            foreach (string i in topics)
            {
                TopicsList.Items.Add(i);
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
        private void TopicsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{TopicsList.SelectedItem.ToString()}"))
                {
                    this.Close();
                    ChooseTheoryAndExercisesForm ctaef = new ChooseTheoryAndExercisesForm(curUser, TopicsList.SelectedItem.ToString());
                    ctaef.Show();
                }
                else
                {
                    MessageBox.Show($"Отсутствует папка \"{TopicsList.SelectedItem.ToString()}\" по адресу:\n{Directory.GetCurrentDirectory()}\\Resources\\Темы\\");
                }
            }
            catch { }
        }

    }
}
