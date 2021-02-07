namespace TeachTest
{
    partial class ChooseTheoryAndExercisesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseTheoryAndExercisesForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.EscPict = new System.Windows.Forms.PictureBox();
            this.TopText = new System.Windows.Forms.Label();
            this.LabelTheory = new System.Windows.Forms.Label();
            this.LabelExercises = new System.Windows.Forms.Label();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.ExercisesBox = new System.Windows.Forms.PictureBox();
            this.TheoryBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryBox)).BeginInit();
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
            this.topPanel.TabIndex = 7;
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
            this.TopText.Text = "Выбор";
            this.TopText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseDown);
            this.TopText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopText_MouseMove);
            // 
            // LabelTheory
            // 
            this.LabelTheory.AutoSize = true;
            this.LabelTheory.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTheory.Location = new System.Drawing.Point(131, 87);
            this.LabelTheory.Name = "LabelTheory";
            this.LabelTheory.Size = new System.Drawing.Size(134, 45);
            this.LabelTheory.TabIndex = 11;
            this.LabelTheory.Text = "Теория";
            // 
            // LabelExercises
            // 
            this.LabelExercises.AutoSize = true;
            this.LabelExercises.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExercises.Location = new System.Drawing.Point(523, 87);
            this.LabelExercises.Name = "LabelExercises";
            this.LabelExercises.Size = new System.Drawing.Size(161, 45);
            this.LabelExercises.TabIndex = 12;
            this.LabelExercises.Text = "Задания";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(123)))), ((int)(((byte)(138)))));
            this.ButtonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(125)))), ((int)(((byte)(245)))));
            this.ButtonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(58)))), ((int)(((byte)(80)))));
            this.ButtonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(108)))));
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBack.Location = new System.Drawing.Point(29, 529);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(120, 35);
            this.ButtonBack.TabIndex = 13;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // ExercisesBox
            // 
            this.ExercisesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExercisesBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExercisesBox.Image = global::TeachTest.Properties.Resources.ExercisePicture;
            this.ExercisesBox.Location = new System.Drawing.Point(477, 180);
            this.ExercisesBox.Name = "ExercisesBox";
            this.ExercisesBox.Size = new System.Drawing.Size(250, 250);
            this.ExercisesBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExercisesBox.TabIndex = 9;
            this.ExercisesBox.TabStop = false;
            this.ExercisesBox.Click += new System.EventHandler(this.ExercisesBox_Click);
            // 
            // TheoryBox
            // 
            this.TheoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TheoryBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TheoryBox.Image = global::TeachTest.Properties.Resources.TheoryPicture;
            this.TheoryBox.Location = new System.Drawing.Point(72, 180);
            this.TheoryBox.Name = "TheoryBox";
            this.TheoryBox.Size = new System.Drawing.Size(250, 250);
            this.TheoryBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TheoryBox.TabIndex = 8;
            this.TheoryBox.TabStop = false;
            this.TheoryBox.Click += new System.EventHandler(this.TheoryBox_Click);
            // 
            // ChooseTheoryAndExercisesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(197)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.LabelExercises);
            this.Controls.Add(this.LabelTheory);
            this.Controls.Add(this.ExercisesBox);
            this.Controls.Add(this.TheoryBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChooseTheoryAndExercisesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EscPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TheoryBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox EscPict;
        private System.Windows.Forms.PictureBox TheoryBox;
        private System.Windows.Forms.PictureBox ExercisesBox;
        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Label LabelTheory;
        private System.Windows.Forms.Label LabelExercises;
        private System.Windows.Forms.Button ButtonBack;
    }
}