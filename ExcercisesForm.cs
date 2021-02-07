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
    public partial class ExcercisesForm : Form
    {
        GameUser curUser;
        string selectedTopic;
        string[] Exercises;
        string[] exLines;
        string curAns, userAns;
        int curEx = 0, correctEx=0;

        bool flag = true;
        int i = 1200, startTime = 1200;
        public ExcercisesForm(GameUser cu, string sT)
        {
            InitializeComponent();
            curUser = cu;
            selectedTopic = sT;
            Exercises = Directory.GetFiles(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Задания");
            textBoxExercises.Text = "";
            textBoxExercises.ScrollBars = ScrollBars.Vertical;
            textBoxAnswer.Focus();
            SetTime();
            WatchExercise(Exercises[0]);
            TimerAsync();
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

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if(textBoxAnswer.Text == "")
            {
                MessageBox.Show("Вы ничего не ввели!");
            }
            else
            {
                userAns = textBoxAnswer.Text.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "").ToLower();
                if (userAns == curAns && curEx < Exercises.Length)    correctEx++;

                curEx++;
                if (curEx == Exercises.Length - 1)   buttonContinue.Text = "Завершить";
                if (curEx < Exercises.Length)
                {
                    WatchExercise(Exercises[curEx]);
                    progressBarEx.Value += progressBarEx.Maximum / Exercises.Length;
                    textBoxAnswer.Text = "";
                    textBoxAnswer.Focus();
                }
                else
                {
                    progressBarEx.Value = progressBarEx.Maximum;
                    flag = false;
                    this.Close();
                    Results R = new Results(curUser, selectedTopic, correctEx, startTime - i, startTime);
                    R.Show();
                }
            }
        }
        //_______________________________________________________________________________________________________________________
        async void TimerAsync()
        {
            await Task.Run(() => Timer());
        }
        void Timer()
        {
            string hour, min, sec;
            int p = i / 3600;
            hour = p.ToString();
            hour = (hour.Length == 1) ? "0" + hour : hour;
            min = ((i - p * 3600) / 60).ToString();
            min = (min.Length == 1) ? "0" + min : min;
            sec = (i % 60).ToString();
            sec = (sec.Length == 1) ? "0" + sec : sec;

            LabelTime.Text = $"Осталось: {hour}:{min}:{sec}";

            while (flag && i > 0)
            {
                Thread.Sleep(1000);
                i--;

                p = i / 3600;
                hour = p.ToString();
                hour = (hour.Length == 1) ? "0" + hour : hour;
                min = ((i - p * 3600) / 60).ToString();
                min = (min.Length == 1) ? "0" + min : min;
                sec = (i % 60).ToString();
                sec = (sec.Length == 1) ? "0" + sec : sec;
                try
                {
                    LabelTime.Text = $"Осталось: {hour}:{min}:{sec}";
                }
                catch { }
            }
        }
        void WatchExercise(string Ex)
        {
            textBoxExercises.Text = "";
            exLines = File.ReadAllLines(Ex);
            curAns = exLines[exLines.Length-1].Replace(" ", "").Replace(",", "").Replace(".", "").Replace("(", "").Replace(")", "").ToLower();
            for (int num = 0; num < exLines.Length - 1; num++)
            {
                textBoxExercises.Text += exLines[num] + "\r\n";
            }
            exLines = null;
        }
        void SetTime()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Settings.ini"))
            {
                string[] s = File.ReadAllLines(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Settings.ini");
                string[] s1 = s[4].Split(new char[] { ' ' });
                i = Convert.ToInt32(s1[s1.Length - 1]) * 60;
                startTime = Convert.ToInt32(s1[s1.Length - 1]) * 60;
            }
            else
            {
                MessageBox.Show("!");
            }
        }
    }
}
