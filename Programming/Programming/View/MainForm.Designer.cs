namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            weekdayParsingGroupControl1 = new View.Panels.WeekdayParsingGroupControl();
            enumerationsGroupControl1 = new View.Panels.EnumerationsGroupControl();
            seasonsHandleGroup1 = new View.Panels.SeasonsHandleGroup();
            ClassesPage = new TabPage();
            FilmsGroupBox = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            RatingTextBox = new TextBox();
            ReleaseYearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            FindFilmButton = new Button();
            FilmsListBox = new ListBox();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            rectanglesControl1 = new View.Panels.RectanglesControl();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            ClassesPage.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Controls.Add(Rectangles);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(827, 503);
            MainTabControl.TabIndex = 1;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(weekdayParsingGroupControl1);
            EnumsPage.Controls.Add(enumerationsGroupControl1);
            EnumsPage.Controls.Add(seasonsHandleGroup1);
            EnumsPage.Location = new Point(4, 29);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(819, 470);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // weekdayParsingGroupControl1
            // 
            weekdayParsingGroupControl1.Location = new Point(3, 324);
            weekdayParsingGroupControl1.Name = "weekdayParsingGroupControl1";
            weekdayParsingGroupControl1.Size = new Size(433, 143);
            weekdayParsingGroupControl1.TabIndex = 4;
            // 
            // enumerationsGroupControl1
            // 
            enumerationsGroupControl1.Location = new Point(-4, 0);
            enumerationsGroupControl1.Name = "enumerationsGroupControl1";
            enumerationsGroupControl1.Size = new Size(815, 318);
            enumerationsGroupControl1.TabIndex = 3;
            // 
            // seasonsHandleGroup1
            // 
            seasonsHandleGroup1.Location = new Point(442, 324);
            seasonsHandleGroup1.Name = "seasonsHandleGroup1";
            seasonsHandleGroup1.Size = new Size(369, 143);
            seasonsHandleGroup1.TabIndex = 2;
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(rectanglesControl1);
            ClassesPage.Controls.Add(FilmsGroupBox);
            ClassesPage.Location = new Point(4, 29);
            ClassesPage.Name = "ClassesPage";
            ClassesPage.Size = new Size(819, 470);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
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
            FilmsGroupBox.Location = new Point(420, 14);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(380, 286);
            FilmsGroupBox.TabIndex = 8;
            FilmsGroupBox.TabStop = false;
            FilmsGroupBox.Text = "Films";
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
            // Rectangles
            // 
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Padding = new Padding(3);
            Rectangles.Size = new Size(819, 470);
            Rectangles.TabIndex = 2;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rectanglesCollisionControl1.AutoSize = true;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(822, 470);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            rectanglesControl1.Location = new Point(8, 14);
            rectanglesControl1.Name = "rectanglesControl1";
            rectanglesControl1.Size = new Size(388, 453);
            rectanglesControl1.TabIndex = 9;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 503);
            Controls.Add(MainTabControl);
            MinimumSize = new Size(845, 550);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            ClassesPage.ResumeLayout(false);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        private void DecreaseRectanglesButton_MouseHover1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private TabPage ClassesPage;
        private GroupBox FilmsGroupBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox RatingTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private Button FindFilmButton;
        private ListBox FilmsListBox;
        private TabPage Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.SeasonsHandleGroup seasonsHandleGroup1;
        private View.Panels.EnumerationsGroupControl enumerationsGroupControl1;
        private View.Panels.WeekdayParsingGroupControl weekdayParsingGroupControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}
