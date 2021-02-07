namespace TeachTest
{
    partial class RatingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.RatingView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorrectAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonToChooseTheoryAndExercisesForm = new System.Windows.Forms.Button();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingView)).BeginInit();
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
            this.topPanel.TabIndex = 10;
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
            this.TopText.Text = "Рейтинг";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // RatingView
            // 
            this.RatingView.AllowUserToAddRows = false;
            this.RatingView.AllowUserToDeleteRows = false;
            this.RatingView.AllowUserToResizeColumns = false;
            this.RatingView.AllowUserToResizeRows = false;
            this.RatingView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.RatingView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RatingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RatingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.Surname,
            this.ColumnCorrectAnswers,
            this.ColumnTime,
            this.ColumnPoints});
            this.RatingView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RatingView.Location = new System.Drawing.Point(25, 40);
            this.RatingView.Name = "RatingView";
            this.RatingView.ReadOnly = true;
            this.RatingView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.RatingView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RatingView.ShowCellErrors = false;
            this.RatingView.ShowCellToolTips = false;
            this.RatingView.ShowEditingIcon = false;
            this.RatingView.ShowRowErrors = false;
            this.RatingView.Size = new System.Drawing.Size(750, 500);
            this.RatingView.TabIndex = 11;
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.HeaderText = "Имя";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 200;
            // 
            // Surname
            // 
            this.Surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Surname.Width = 200;
            // 
            // ColumnCorrectAnswers
            // 
            this.ColumnCorrectAnswers.HeaderText = "Правильные ответы";
            this.ColumnCorrectAnswers.Name = "ColumnCorrectAnswers";
            this.ColumnCorrectAnswers.ReadOnly = true;
            this.ColumnCorrectAnswers.Width = 80;
            // 
            // ColumnTime
            // 
            this.ColumnTime.HeaderText = "Время выполнения";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 120;
            // 
            // ColumnPoints
            // 
            this.ColumnPoints.HeaderText = "Очки";
            this.ColumnPoints.Name = "ColumnPoints";
            this.ColumnPoints.ReadOnly = true;
            this.ColumnPoints.Width = 107;
            // 
            // ButtonToChooseTheoryAndExercisesForm
            // 
            this.ButtonToChooseTheoryAndExercisesForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonToChooseTheoryAndExercisesForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonToChooseTheoryAndExercisesForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonToChooseTheoryAndExercisesForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonToChooseTheoryAndExercisesForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonToChooseTheoryAndExercisesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToChooseTheoryAndExercisesForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonToChooseTheoryAndExercisesForm.Location = new System.Drawing.Point(25, 558);
            this.ButtonToChooseTheoryAndExercisesForm.Name = "ButtonToChooseTheoryAndExercisesForm";
            this.ButtonToChooseTheoryAndExercisesForm.Size = new System.Drawing.Size(110, 30);
            this.ButtonToChooseTheoryAndExercisesForm.TabIndex = 13;
            this.ButtonToChooseTheoryAndExercisesForm.Text = "Вернуться";
            this.ButtonToChooseTheoryAndExercisesForm.UseVisualStyleBackColor = false;
            this.ButtonToChooseTheoryAndExercisesForm.Click += new System.EventHandler(this.ButtonToChooseTheoryAndExercisesForm_Click);
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
            this.buttonEnd.Location = new System.Drawing.Point(575, 558);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(200, 30);
            this.buttonEnd.TabIndex = 19;
            this.buttonEnd.Text = "Завершить работу";
            this.buttonEnd.UseVisualStyleBackColor = false;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.ButtonToChooseTheoryAndExercisesForm);
            this.Controls.Add(this.RatingView);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RatingForm";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RatingView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.DataGridView RatingView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorrectAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPoints;
        private System.Windows.Forms.Button ButtonToChooseTheoryAndExercisesForm;
        private System.Windows.Forms.Button buttonEnd;
    }
}