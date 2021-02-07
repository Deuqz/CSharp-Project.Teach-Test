namespace TeachTest
{
    partial class Results
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Results));
            this.topPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCorrectAns = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.seeAllPoints = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(70)))));
            this.topPanel.Controls.Add(this.EscPict);
            this.topPanel.Controls.Add(this.TopText);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 29);
            this.topPanel.TabIndex = 9;
            // 
            // EscPict
            // 
            this.EscPict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EscPict.Image = ((System.Drawing.Image)(resources.GetObject("EscPict.Image")));
            this.EscPict.Location = new System.Drawing.Point(773, 0);
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
            this.TopText.Size = new System.Drawing.Size(800, 29);
            this.TopText.TabIndex = 0;
            this.TopText.Text = "Результаты";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(232, 89);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(62, 34);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Имя";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCorrectAns
            // 
            this.labelCorrectAns.AutoSize = true;
            this.labelCorrectAns.Font = new System.Drawing.Font("Impact", 22F);
            this.labelCorrectAns.Location = new System.Drawing.Point(77, 235);
            this.labelCorrectAns.Name = "labelCorrectAns";
            this.labelCorrectAns.Size = new System.Drawing.Size(155, 37);
            this.labelCorrectAns.TabIndex = 12;
            this.labelCorrectAns.Text = "CorrectAns";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Impact", 22F);
            this.labelTime.Location = new System.Drawing.Point(497, 235);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(77, 37);
            this.labelTime.TabIndex = 13;
            this.labelTime.Text = "Time";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Font = new System.Drawing.Font("Impact", 40F);
            this.labelPoints.Location = new System.Drawing.Point(104, 377);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(144, 66);
            this.labelPoints.TabIndex = 14;
            this.labelPoints.Text = "Очки";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TeachTest.Properties.Resources.Complite;
            this.pictureBox2.Location = new System.Drawing.Point(504, 319);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TeachTest.Properties.Resources.VeryGood;
            this.pictureBox1.Location = new System.Drawing.Point(34, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonBack.Location = new System.Drawing.Point(12, 556);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 30);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Вернуться";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // seeAllPoints
            // 
            this.seeAllPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.seeAllPoints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.seeAllPoints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.seeAllPoints.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.seeAllPoints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.seeAllPoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seeAllPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.seeAllPoints.Location = new System.Drawing.Point(588, 556);
            this.seeAllPoints.Name = "seeAllPoints";
            this.seeAllPoints.Size = new System.Drawing.Size(200, 30);
            this.seeAllPoints.TabIndex = 17;
            this.seeAllPoints.Text = "Посмотреть рейтинг";
            this.seeAllPoints.UseVisualStyleBackColor = false;
            this.seeAllPoints.Click += new System.EventHandler(this.seeAllPoints_Click);
            // 
            // buttonEnd
            // 
            this.buttonEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.buttonEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.buttonEnd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.buttonEnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.buttonEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEnd.Location = new System.Drawing.Point(300, 556);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(200, 30);
            this.buttonEnd.TabIndex = 18;
            this.buttonEnd.Text = "Завершить работу";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.seeAllPoints);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelCorrectAns);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Results";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCorrectAns;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPoints;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button seeAllPoints;
        private System.Windows.Forms.Button buttonEnd;
    }
}