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
            seasonsHandleGroup1 = new View.Panels.SeasonsHandleGroup();
            WeekdayParsingGroupBox = new GroupBox();
            ParseButton = new Button();
            ParseOutputLabel = new Label();
            ParseTextBox = new TextBox();
            label4 = new Label();
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
            RectanglesGroupBox = new GroupBox();
            IdTextBox = new TextBox();
            label13 = new Label();
            RectangleCenterGroupBox = new GroupBox();
            CenterYTextBox = new TextBox();
            CenterXTextBox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            FindRectangleButton = new Button();
            RectanglesListBox = new ListBox();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            enumerationsGroupControl1 = new View.Panels.EnumerationsGroupControl();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectangleCenterGroupBox.SuspendLayout();
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
            EnumsPage.Controls.Add(enumerationsGroupControl1);
            EnumsPage.Controls.Add(seasonsHandleGroup1);
            EnumsPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsPage.Location = new Point(4, 29);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(819, 470);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // seasonsHandleGroup1
            // 
            seasonsHandleGroup1.Location = new Point(442, 324);
            seasonsHandleGroup1.Name = "seasonsHandleGroup1";
            seasonsHandleGroup1.Size = new Size(369, 143);
            seasonsHandleGroup1.TabIndex = 2;
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WeekdayParsingGroupBox.Controls.Add(ParseButton);
            WeekdayParsingGroupBox.Controls.Add(ParseOutputLabel);
            WeekdayParsingGroupBox.Controls.Add(ParseTextBox);
            WeekdayParsingGroupBox.Controls.Add(label4);
            WeekdayParsingGroupBox.Location = new Point(8, 324);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(418, 137);
            WeekdayParsingGroupBox.TabIndex = 1;
            WeekdayParsingGroupBox.TabStop = false;
            WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(252, 68);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 3;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ParseOutputLabel
            // 
            ParseOutputLabel.AutoSize = true;
            ParseOutputLabel.Location = new Point(16, 114);
            ParseOutputLabel.Name = "ParseOutputLabel";
            ParseOutputLabel.Size = new Size(0, 20);
            ParseOutputLabel.TabIndex = 2;
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(18, 69);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(228, 27);
            ParseTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 33);
            label4.Name = "label4";
            label4.Size = new Size(158, 20);
            label4.TabIndex = 0;
            label4.Text = "Type value for parsing:";
            // 
            // ClassesPage
            // 
            ClassesPage.Controls.Add(FilmsGroupBox);
            ClassesPage.Controls.Add(RectanglesGroupBox);
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
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(label13);
            RectanglesGroupBox.Controls.Add(RectangleCenterGroupBox);
            RectanglesGroupBox.Controls.Add(label7);
            RectanglesGroupBox.Controls.Add(label6);
            RectanglesGroupBox.Controls.Add(label5);
            RectanglesGroupBox.Controls.Add(ColorTextBox);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(HeightTextBox);
            RectanglesGroupBox.Controls.Add(FindRectangleButton);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(8, 14);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(380, 447);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(233, 26);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 10;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(199, 26);
            label13.Name = "label13";
            label13.Size = new Size(27, 20);
            label13.TabIndex = 9;
            label13.Text = "ID:";
            // 
            // RectangleCenterGroupBox
            // 
            RectangleCenterGroupBox.Controls.Add(CenterYTextBox);
            RectangleCenterGroupBox.Controls.Add(CenterXTextBox);
            RectangleCenterGroupBox.Controls.Add(label12);
            RectangleCenterGroupBox.Controls.Add(label11);
            RectangleCenterGroupBox.Location = new Point(199, 237);
            RectangleCenterGroupBox.Name = "RectangleCenterGroupBox";
            RectangleCenterGroupBox.Size = new Size(159, 121);
            RectangleCenterGroupBox.TabIndex = 8;
            RectangleCenterGroupBox.TabStop = false;
            RectangleCenterGroupBox.Text = "Center";
            // 
            // CenterYTextBox
            // 
            CenterYTextBox.Location = new Point(30, 71);
            CenterYTextBox.Name = "CenterYTextBox";
            CenterYTextBox.ReadOnly = true;
            CenterYTextBox.Size = new Size(46, 27);
            CenterYTextBox.TabIndex = 3;
            // 
            // CenterXTextBox
            // 
            CenterXTextBox.Location = new Point(30, 35);
            CenterXTextBox.Name = "CenterXTextBox";
            CenterXTextBox.ReadOnly = true;
            CenterXTextBox.Size = new Size(46, 27);
            CenterXTextBox.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 74);
            label12.Name = "label12";
            label12.Size = new Size(20, 20);
            label12.TabIndex = 1;
            label12.Text = "Y:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 38);
            label11.Name = "label11";
            label11.Size = new Size(21, 20);
            label11.TabIndex = 0;
            label11.Text = "X:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 170);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 7;
            label7.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 117);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 59);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Height";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(199, 193);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(159, 27);
            ColorTextBox.TabIndex = 4;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(199, 140);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(159, 27);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(199, 82);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(159, 27);
            HeightTextBox.TabIndex = 2;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(199, 401);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(159, 29);
            FindRectangleButton.TabIndex = 1;
            FindRectangleButton.Text = "Find";
            FindRectangleButton.UseVisualStyleBackColor = true;
            FindRectangleButton.Click += FindRectangleButton_Click;
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(182, 404);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesBox_SelectedIndexChanged;
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
            // enumerationsGroupControl1
            // 
            enumerationsGroupControl1.Location = new Point(-4, 0);
            enumerationsGroupControl1.Name = "enumerationsGroupControl1";
            enumerationsGroupControl1.Size = new Size(815, 318);
            enumerationsGroupControl1.TabIndex = 3;
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
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            ClassesPage.ResumeLayout(false);
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectangleCenterGroupBox.ResumeLayout(false);
            RectangleCenterGroupBox.PerformLayout();
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
        private GroupBox WeekdayParsingGroupBox;
        private Button ParseButton;
        private Label ParseOutputLabel;
        private TextBox ParseTextBox;
        private Label label4;
        private TabPage ClassesPage;
        private GroupBox RectanglesGroupBox;
        private ListBox RectanglesListBox;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Button FindRectangleButton;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox FilmsGroupBox;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox RatingTextBox;
        private TextBox ReleaseYearTextBox;
        private TextBox DurationTextBox;
        private Button FindFilmButton;
        private ListBox FilmsListBox;
        private GroupBox RectangleCenterGroupBox;
        private Label label11;
        private TextBox CenterYTextBox;
        private TextBox CenterXTextBox;
        private Label label12;
        private Label label13;
        private TextBox IdTextBox;
        private TabPage Rectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.SeasonsHandleGroup seasonsHandleGroup1;
        private View.Panels.EnumerationsGroupControl enumerationsGroupControl1;
    }
}
