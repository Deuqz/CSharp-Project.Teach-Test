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
    public partial class Results : Form
    {
        GameUser curUser;
        string selectedTopic;
        int numCorrect, Time, startTime;
        int pointsOnCorrectAns=500, pointsOnTime=1;
        public Results(GameUser cu, string sT, int nC, int T, int startT)
        {
            InitializeComponent();
            curUser = cu;
            selectedTopic = sT;
            numCorrect = nC;
            Time = T;
            startTime = startT;

            SetPoints();

            PointIncreaseAsync();
            UpdateRating();  //!!!!
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
        private void Results_Load(object sender, EventArgs e)
        {
            labelName.Text = $"{curUser.Name} {curUser.Surname},\n Вы ответили на все вопросы";

            labelCorrectAns.Text = "Правильные ответы: " + numCorrect.ToString();

            string hour, min, sec;
            int p = Time / 3600;
            hour = p.ToString();
            hour = (hour.Length == 1) ? "0" + hour : hour;
            min = ((Time - p * 3600) / 60).ToString();
            min = (min.Length == 1) ? "0" + min : min;
            sec = (Time % 60).ToString();
            sec = (sec.Length == 1) ? "0" + sec : sec;
            labelTime.Text = $"Ваше время: {hour}:{min}:{sec}";

            //PointIncreaseAsync();
            //labelPoints.Text = $"Очки: {numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime}";
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseTheoryAndExercisesForm ctaef = new ChooseTheoryAndExercisesForm(curUser, selectedTopic);
                ctaef.Show();
                this.Close();
            }
            catch { }
        }
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Сообщение", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();//!!!!
            }
        }
        private void seeAllPoints_Click(object sender, EventArgs e)
        {
            try
            {
                RatingForm rf = new RatingForm(curUser, selectedTopic);
                rf.Show();
                this.Close();
            }
            catch { }
        }
        //________________________________________________________________________________________________________
        private void SetPoints()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Settings.ini"))
            {
                string[] s = File.ReadAllLines(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Settings.ini");
                string[] s1 = s[1].Split(new char[] { ' ' });
                string[] s2 = s[2].Split(new char[] { ' ' });
                pointsOnCorrectAns = Convert.ToInt32(s1[s1.Length - 1]);
                pointsOnTime = Convert.ToInt32(s2[s2.Length - 1]);
            }
            else
            {
                MessageBox.Show("!");
            }
        }
        async void PointIncreaseAsync()
        {
            await Task.Run(() => PointIncrease());
        }
        private void PointIncrease()
        {
            int points = numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime;
            for (int i = 0; i <= points; i++)
            {
                try
                {
                    labelPoints.Text = "Очки: " + i.ToString();
                    Thread.Sleep(1);
                }
                catch { return; }
            }
        }
        //=========================================================================================================
        class GUser : IComparable<GUser>
        {
            public string chOfUser;
            public string[] ch = new string[5];
            public int points;
            public void MakeNormal()
            {
                chOfUser = $"{ch[0]} {ch[1]} {ch[2]} {ch[3]} {ch[4]}";
            }
            public int CompareTo(GUser u)
            {
                if (this.points > u.points)
                {
                    return -1;
                }
                else if (this.points == u.points)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
        GUser[] users;
        List<string[]> rating = new List<string[]>();
        bool needAddUser = true;
        private void UpdateRating()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + $@"\Resources\Темы\{selectedTopic}\Результаты.ini"))
            {
                TakeAndSortUsers();
                UpdateFile();
            }
            else
            {
                MessageBox.Show("Не удалось обновить результаты.\n Не найдет файл \"Результаты.ini\""
                    + $" по адресу: {Directory.GetCurrentDirectory()}\\Resources\\Темы\\{selectedTopic}\\");
            }
        }
        private void TakeAndSortUsers()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()
                + $@"\Resources\Темы\{selectedTopic}\Результаты.ini");
            try
            {
                while (!sr.EndOfStream)
                {
                    rating.Add(sr.ReadLine().Split(new char[] { ' ' }));
                }
            }
            catch { }
            sr.Close();

            checkUser();

            if (needAddUser)    users = new GUser[rating.Count + 1];
            else                users = new GUser[rating.Count];

            for (int i = 0; i < rating.Count; i++)
            {
                users[i] = new GUser();
                for (int j=0; j<5; j++)
                {
                    users[i].ch[j] = rating[i][j];
                }
                users[i].points = Convert.ToInt32(rating[i][4]);
                users[i].MakeNormal();
            }
            if (needAddUser)
            {
                users[rating.Count] = new GUser();
                users[rating.Count].ch[0] = curUser.Name;
                users[rating.Count].ch[1] = curUser.Surname;
                users[rating.Count].ch[2] = numCorrect.ToString();
                users[rating.Count].ch[3] = InstalTime(Time);
                users[rating.Count].ch[4] = (numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime).ToString();
                users[rating.Count].points = numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime;
                users[rating.Count].MakeNormal();
            }

            Array.Sort(users);
        }
        private void UpdateFile()
        {
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory()
                + $@"\Resources\Темы\{selectedTopic}\Результаты.ini", false);
            foreach(GUser i in users)
            {
                sw.WriteLine(i.chOfUser);
            }
            sw.Close();
        }
        private void checkUser()
        {
            for (int i=0; i<rating.Count; i++)
            {
                if (rating[i][0] == curUser.Name && rating[i][1] == curUser.Surname)
                {
                    needAddUser = false;
                    if (Convert.ToInt32(rating[i][4]) < numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime)
                    {
                        rating[i][2] = numCorrect.ToString();
                        rating[i][3] = InstalTime(Time);
                        rating[i][4] = (numCorrect * pointsOnCorrectAns + (startTime - Time) * pointsOnTime).ToString();
                    }
                    return;
                }
            }
        }
        private string InstalTime(int t)
        {
            string hour, min, sec;
            int p = t / 3600;
            hour = p.ToString();
            hour = (hour.Length == 1) ? "0" + hour : hour;
            min = ((t - p * 3600) / 60).ToString();
            min = (min.Length == 1) ? "0" + min : min;
            sec = (t % 60).ToString();
            sec = (sec.Length == 1) ? "0" + sec : sec;

            return $"{hour}:{min}:{sec}";
        }
    }
}