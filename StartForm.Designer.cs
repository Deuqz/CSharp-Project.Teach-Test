namespace TeachTest
{
    partial class StartForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.ButtonTeacher = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать\r\nПожалуйста, введите свои данные для таблицы результатов";
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.nameBox.Location = new System.Drawing.Point(178, 108);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(225, 31);
            this.nameBox.TabIndex = 1;
            this.nameBox.TabStop = false;
            this.nameBox.Enter += new System.EventHandler(this.nameBox_Enter);
            this.nameBox.Leave += new System.EventHandler(this.nameBox_Leave);
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(372, 219);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 30);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "Начать";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(130)))), ((int)(((byte)(145)))));
            this.surnameBox.Location = new System.Drawing.Point(178, 164);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(225, 31);
            this.surnameBox.TabIndex = 3;
            this.surnameBox.TabStop = false;
            this.surnameBox.Enter += new System.EventHandler(this.surnameBox_Enter);
            this.surnameBox.Leave += new System.EventHandler(this.surnameBox_Leave);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(70)))));
            this.TopPanel.Controls.Add(this.EscPict);
            this.TopPanel.Controls.Add(this.TopText);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(484, 29);
            this.TopPanel.TabIndex = 5;
            // 
            // EscPict
            // 
            this.EscPict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EscPict.Image = ((System.Drawing.Image)(resources.GetObject("EscPict.Image")));
            this.EscPict.Location = new System.Drawing.Point(457, 0);
            this.EscPict.Name = "EscPict";
            this.EscPict.Size = new System.Drawing.Size(27, 29);
            this.EscPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EscPict.TabIndex = 6;
            this.EscPict.TabStop = false;
            this.EscPict.Click += new System.EventHandler(this.EscPict_Click);
            // 
            // TopText
            // 
            this.TopText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(70)))));
            this.TopText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopText.Location = new System.Drawing.Point(0, 0);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(484, 29);
            this.TopText.TabIndex = 2;
            this.TopText.Text = "Ввод данных";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // UserPicture
            // 
            this.UserPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserPicture.Image = global::TeachTest.Properties.Resources.userPicture;
            this.UserPicture.Location = new System.Drawing.Point(55, 108);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(94, 87);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPicture.TabIndex = 4;
            this.UserPicture.TabStop = false;
            // 
            // ButtonTeacher
            // 
            this.ButtonTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonTeacher.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonTeacher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonTeacher.Location = new System.Drawing.Point(12, 219);
            this.ButtonTeacher.Name = "ButtonTeacher";
            this.ButtonTeacher.Size = new System.Drawing.Size(100, 30);
            this.ButtonTeacher.TabIndex = 8;
            this.ButtonTeacher.Text = "Учителю";
            this.ButtonTeacher.UseVisualStyleBackColor = false;
            this.ButtonTeacher.Click += new System.EventHandler(this.ButtonTeacher_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.ButtonTeacher);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.UserPicture);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(-7, 0);
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод данных";
            this.TopMost = true;
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.Button ButtonTeacher;
        private System.Windows.Forms.Label TopText;
    }
}

