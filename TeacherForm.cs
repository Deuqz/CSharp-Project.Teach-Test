using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TeachTest
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
            TopicBox.Text = "Введите тему";
            TopicBox.ForeColor = Color.Gray;
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
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StartForm sf = new StartForm();
            sf.Show();
        }
        private void TopicBox_Enter(object sender, EventArgs e)
        {
            if (TopicBox.Text == "Введите тему")
            {
                TopicBox.Text = "";
                TopicBox.ForeColor = Color.Black;
            }
            if (labelMessage.Text == "Такая тема уже существует") labelMessage.Text = "";
        }
        private void TopicBox_Leave(object sender, EventArgs e)
        {
            if (TopicBox.Text == "")
            {
                TopicBox.Text = "Введите тему";
                TopicBox.ForeColor = Color.Gray;
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt")
                && TopicBox.Text != "" && TopicBox.Text != "Введите тему"
                && !Directory.Exists(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text))
            {
                StreamWriter sw1 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt", true);
                sw1.WriteLine();
                sw1.WriteLine(TopicBox.Text);
                sw1.Close();
                string[] strs = File.ReadAllLines(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt");
                StreamWriter sw2 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Resources\Topics.txt", false);
                foreach (string i in strs)
                {
                    if (i != "")    sw2.WriteLine(i);
                }
                sw2.Close();
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text + @"\Теория");
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text + @"\Задания");
                File.Create(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text + @"\Результаты.ini").Close();
                File.Create(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text + @"\Settings.ini").Close();
                StreamWriter sw3 = new StreamWriter(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text + @"\Settings.ini", false);
                sw3.WriteLine("Игрок получает следующее количество очков:");
                sw3.WriteLine("за правильный ответ: 500");
                sw3.WriteLine("за каждую оставшуюся секунду: 1");
                sw3.WriteLine();
                sw3.WriteLine("Время, которое игрок выполняет задания(в минутах): 20");
                sw3.Close();

                MessageBox.Show($"Теперь по адресу: {Directory.GetCurrentDirectory()}\\Resources\\Темы\\{TopicBox.Text}\n"
                    + "созданы папки \"Теория\" и \"Задания\", в которых можно писать собственные теорию и задания,\n"
                    + "а также файлы \"Результаты.ini\", в котором будут размещаться результаты,\n"
                    + "и \"Settings.ini\", в котором можно настроить выполнение заданий");
                TopicBox.Text = "Введите тему";
                TopicBox.ForeColor = Color.Gray;
            }
            else if (TopicBox.Text == "" || TopicBox.Text == "Введите тему")
            {
                MessageBox.Show("Вы не ввели тему");
            }
            else if (Directory.Exists(Directory.GetCurrentDirectory() + @"\Resources\Темы\" + TopicBox.Text))
            {
                labelMessage.Text = "Такая тема уже существует";
            }
            else
            {
                MessageBox.Show("Отсутствует файл \"Topics.txt\" по адресу:\n"
                    + $@"{Directory.GetCurrentDirectory()} \Resources\");
            }
        }
    }
}
