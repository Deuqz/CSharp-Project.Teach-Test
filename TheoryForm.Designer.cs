namespace TeachTest
{
    partial class TheoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TheoryForm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.ButtonForward = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ButtonToChooseTheoryAndExercisesForm = new System.Windows.Forms.Button();
            this.pictureBoxTheory = new System.Windows.Forms.PictureBox();
            this.textBoxTheory = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheory)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(247)))), ((int)(((byte)(70)))));
            this.TopPanel.Controls.Add(this.EscPict);
            this.TopPanel.Controls.Add(this.TopText);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(784, 29);
            this.TopPanel.TabIndex = 7;
            // 
            // EscPict
            // 
            this.EscPict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EscPict.Image = ((System.Drawing.Image)(resources.GetObject("EscPict.Image")));
            this.EscPict.Location = new System.Drawing.Point(757, 0);
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
            this.TopText.Size = new System.Drawing.Size(784, 29);
            this.TopText.TabIndex = 1;
            this.TopText.Text = "Теория";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // ButtonForward
            // 
            this.ButtonForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonForward.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonForward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonForward.Location = new System.Drawing.Point(672, 519);
            this.ButtonForward.Name = "ButtonForward";
            this.ButtonForward.Size = new System.Drawing.Size(100, 30);
            this.ButtonForward.TabIndex = 9;
            this.ButtonForward.Text = "Далее";
            this.ButtonForward.UseVisualStyleBackColor = false;
            this.ButtonForward.Click += new System.EventHandler(this.ButtonForward_Click);
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonBack.Location = new System.Drawing.Point(12, 519);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 30);
            this.ButtonBack.TabIndex = 10;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
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
            this.ButtonToChooseTheoryAndExercisesForm.Location = new System.Drawing.Point(338, 519);
            this.ButtonToChooseTheoryAndExercisesForm.Name = "ButtonToChooseTheoryAndExercisesForm";
            this.ButtonToChooseTheoryAndExercisesForm.Size = new System.Drawing.Size(110, 30);
            this.ButtonToChooseTheoryAndExercisesForm.TabIndex = 11;
            this.ButtonToChooseTheoryAndExercisesForm.Text = "Вернуться";
            this.ButtonToChooseTheoryAndExercisesForm.UseVisualStyleBackColor = false;
            this.ButtonToChooseTheoryAndExercisesForm.Click += new System.EventHandler(this.ButtonToChooseTheoryAndExercisesForm_Click);
            // 
            // pictureBoxTheory
            // 
            this.pictureBoxTheory.Location = new System.Drawing.Point(12, 47);
            this.pictureBoxTheory.Name = "pictureBoxTheory";
            this.pictureBoxTheory.Size = new System.Drawing.Size(760, 455);
            this.pictureBoxTheory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTheory.TabIndex = 12;
            this.pictureBoxTheory.TabStop = false;
            // 
            // textBoxTheory
            // 
            this.textBoxTheory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(228)))), ((int)(((byte)(97)))));
            this.textBoxTheory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTheory.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTheory.Location = new System.Drawing.Point(12, 47);
            this.textBoxTheory.Multiline = true;
            this.textBoxTheory.Name = "textBoxTheory";
            this.textBoxTheory.ReadOnly = true;
            this.textBoxTheory.Size = new System.Drawing.Size(760, 455);
            this.textBoxTheory.TabIndex = 23;
            // 
            // TheoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textBoxTheory);
            this.Controls.Add(this.pictureBoxTheory);
            this.Controls.Add(this.ButtonToChooseTheoryAndExercisesForm);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonForward);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TheoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheoryForm";
            this.TopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTheory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Button ButtonForward;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Button ButtonToChooseTheoryAndExercisesForm;
        private System.Windows.Forms.PictureBox pictureBoxTheory;
        private System.Windows.Forms.TextBox textBoxTheory;
    }
}