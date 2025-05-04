namespace Programming.View.Panels
{
    partial class MoviesGroupControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FilmsGroupBox = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            RatingTextBox = new TextBox();
            ReleaseYearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            FindFilmButton = new Button();
            FilmsListBox = new ListBox();
            FilmsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmsGroupBox
            // 
            FilmsGroupBox.Controls.Add(label8);
            FilmsGroupBox.Controls.Add(label9);
            FilmsGroupBox.Controls.Add(label10);
            FilmsGroupBox.Controls.Add(RatingTextBox);
            FilmsGroupBox.Controls.Add(ReleaseYearTextBox);
            FilmsGroupBox.Controls.Add(DurationTextBox);
            FilmsGroupBox.Controls.Add(FindFilmButton);
            FilmsGroupBox.Controls.Add(FilmsListBox);
            FilmsGroupBox.Location = new Point(3, 3);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(400, 283);
            FilmsGroupBox.TabIndex = 9;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
            FilmsGroupBox.Enter += FilmsGroupBox_Enter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(199, 126);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 7;
            label8.Text = "Rating";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(199, 73);
            label9.Name = "label9";
            label9.Size = new Size(92, 20);
            label9.TabIndex = 6;
            label9.Text = "Release Year";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(199, 15);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 5;
            label10.Text = "Duration in Minutes";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(199, 149);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(165, 27);
            RatingTextBox.TabIndex = 4;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(199, 96);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(165, 27);
            ReleaseYearTextBox.TabIndex = 3;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(199, 38);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(165, 27);
            DurationTextBox.TabIndex = 2;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // FindFilmButton
            // 
            FindFilmButton.Location = new Point(199, 240);
            FindFilmButton.Name = "FindFilmButton";
            FindFilmButton.Size = new Size(125, 29);
            FindFilmButton.TabIndex = 1;
            FindFilmButton.Text = "Find";
            FindFilmButton.UseVisualStyleBackColor = true;
            FindFilmButton.Click += FindFilmButton_Click;
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.Location = new Point(17, 26);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(171, 244);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // MoviesGroupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(FilmsGroupBox);
            Name = "MoviesGroupControl";
            Size = new Size(411, 289);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmsGroupBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox RatingTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private Button FindFilmButton;
        private ListBox FilmsListBox;
    }
}
