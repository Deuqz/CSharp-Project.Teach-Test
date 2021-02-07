namespace TeachTest
{
    partial class ExcercisesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcercisesForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.progressBarEx = new System.Windows.Forms.ProgressBar();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.LabelTextAnswer = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.textBoxExercises = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
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
            this.topPanel.TabIndex = 8;
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
            this.TopText.Text = "Задания";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.buttonContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.buttonContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.buttonContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(588, 558);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(200, 30);
            this.buttonContinue.TabIndex = 9;
            this.buttonContinue.Text = "Следующее задание";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // progressBarEx
            // 
            this.progressBarEx.BackColor = System.Drawing.Color.Black;
            this.progressBarEx.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBarEx.Location = new System.Drawing.Point(12, 43);
            this.progressBarEx.Name = "progressBarEx";
            this.progressBarEx.Size = new System.Drawing.Size(776, 8);
            this.progressBarEx.TabIndex = 18;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(182, 520);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(606, 31);
            this.textBoxAnswer.TabIndex = 19;
            // 
            // LabelTextAnswer
            // 
            this.LabelTextAnswer.AutoSize = true;
            this.LabelTextAnswer.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTextAnswer.Location = new System.Drawing.Point(102, 523);
            this.LabelTextAnswer.Name = "LabelTextAnswer";
            this.LabelTextAnswer.Size = new System.Drawing.Size(74, 24);
            this.LabelTextAnswer.TabIndex = 20;
            this.LabelTextAnswer.Text = "Ответ:";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTime.Location = new System.Drawing.Point(329, 63);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(108, 24);
            this.LabelTime.TabIndex = 21;
            this.LabelTime.Text = "LabelTime";
            // 
            // textBoxExercises
            // 
            this.textBoxExercises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(228)))), ((int)(((byte)(97)))));
            this.textBoxExercises.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExercises.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxExercises.Location = new System.Drawing.Point(12, 99);
            this.textBoxExercises.Multiline = true;
            this.textBoxExercises.Name = "textBoxExercises";
            this.textBoxExercises.ReadOnly = true;
            this.textBoxExercises.Size = new System.Drawing.Size(776, 401);
            this.textBoxExercises.TabIndex = 22;
            // 
            // ExcercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.textBoxExercises);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelTextAnswer);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.progressBarEx);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcercisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExcercisesForm";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.ProgressBar progressBarEx;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label LabelTextAnswer;
        private System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.TextBox textBoxExercises;
    }
}