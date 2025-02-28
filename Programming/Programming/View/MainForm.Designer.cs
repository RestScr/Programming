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
            EnumGroupBox = new GroupBox();
            label3 = new Label();
            ValueTextBox = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            label1 = new Label();
            EnumsListBox = new ListBox();
            MainTabControl = new TabControl();
            EnumsPage = new TabPage();
            SeasonGroupBox = new GroupBox();
            GoButton = new Button();
            SeasonComboBox = new ComboBox();
            SeasonLabel = new Label();
            WeekdayParsingGroupBox = new GroupBox();
            ParseButton = new Button();
            ParseOutputLabel = new Label();
            ParseTextBox = new TextBox();
            label4 = new Label();
            ClassesPage = new TabPage();
            RectanglesGroupBox = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            ColorTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            FindRectangleButton = new Button();
            RectanglesListBox = new ListBox();
            FilmsGroupBox = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            RatingTextBox = new TextBox();
            ReleaseYearTextBox = new TextBox();
            DurationTextBox = new TextBox();
            FindFilmButton = new Button();
            FilmsListBox = new ListBox();
            EnumGroupBox.SuspendLayout();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumGroupBox
            // 
            EnumGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EnumGroupBox.Controls.Add(label3);
            EnumGroupBox.Controls.Add(ValueTextBox);
            EnumGroupBox.Controls.Add(label2);
            EnumGroupBox.Controls.Add(ValuesListBox);
            EnumGroupBox.Controls.Add(label1);
            EnumGroupBox.Controls.Add(EnumsListBox);
            EnumGroupBox.Location = new Point(8, 0);
            EnumGroupBox.Name = "EnumGroupBox";
            EnumGroupBox.Size = new Size(803, 318);
            EnumGroupBox.TabIndex = 0;
            EnumGroupBox.TabStop = false;
            EnumGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 23);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Int value:";
            // 
            // ValueTextBox
            // 
            ValueTextBox.Location = new Point(434, 43);
            ValueTextBox.Name = "ValueTextBox";
            ValueTextBox.Size = new Size(125, 27);
            ValueTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 23);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose value:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(215, 43);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(192, 264);
            ValuesListBox.TabIndex = 2;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneManufacturers", "Weekday" });
            EnumsListBox.Location = new Point(6, 43);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(182, 264);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // MainTabControl
            // 
            MainTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainTabControl.Controls.Add(EnumsPage);
            MainTabControl.Controls.Add(ClassesPage);
            MainTabControl.Location = new Point(0, 1);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(823, 499);
            MainTabControl.TabIndex = 1;
            // 
            // EnumsPage
            // 
            EnumsPage.Controls.Add(SeasonGroupBox);
            EnumsPage.Controls.Add(WeekdayParsingGroupBox);
            EnumsPage.Controls.Add(EnumGroupBox);
            EnumsPage.Location = new Point(4, 29);
            EnumsPage.Name = "EnumsPage";
            EnumsPage.Padding = new Padding(3);
            EnumsPage.Size = new Size(815, 466);
            EnumsPage.TabIndex = 0;
            EnumsPage.Text = "Enums";
            EnumsPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SeasonGroupBox.Controls.Add(GoButton);
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonLabel);
            SeasonGroupBox.Location = new Point(432, 324);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(379, 137);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            GoButton.Location = new Point(185, 68);
            GoButton.Name = "GoButton";
            GoButton.Size = new Size(85, 29);
            GoButton.TabIndex = 2;
            GoButton.Text = "Go!";
            GoButton.UseVisualStyleBackColor = true;
            GoButton.Click += GoButton_Click;
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Summer", "Autumn", "Winter", "Spring" });
            SeasonComboBox.Location = new Point(23, 68);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(156, 28);
            SeasonComboBox.TabIndex = 1;
            // 
            // SeasonLabel
            // 
            SeasonLabel.AutoSize = true;
            SeasonLabel.Location = new Point(23, 33);
            SeasonLabel.Name = "SeasonLabel";
            SeasonLabel.Size = new Size(112, 20);
            SeasonLabel.TabIndex = 0;
            SeasonLabel.Text = "Choose Season:";
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
            ClassesPage.Size = new Size(815, 466);
            ClassesPage.TabIndex = 1;
            ClassesPage.Text = "Classes";
            ClassesPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
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
            RectanglesGroupBox.Size = new Size(410, 275);
            RectanglesGroupBox.TabIndex = 1;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 126);
            label7.Name = "label7";
            label7.Size = new Size(45, 20);
            label7.TabIndex = 7;
            label7.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 73);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 15);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Height";
            // 
            // ColorTextBox
            // 
            ColorTextBox.Location = new Point(199, 149);
            ColorTextBox.Name = "ColorTextBox";
            ColorTextBox.Size = new Size(125, 27);
            ColorTextBox.TabIndex = 4;
            ColorTextBox.TextChanged += ColorTextBox_TextChanged;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(199, 96);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(125, 27);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(199, 38);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(125, 27);
            HeightTextBox.TabIndex = 2;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // FindRectangleButton
            // 
            FindRectangleButton.Location = new Point(199, 240);
            FindRectangleButton.Name = "FindRectangleButton";
            FindRectangleButton.Size = new Size(125, 29);
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
            RectanglesListBox.Size = new Size(182, 244);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesBox_SelectedIndexChanged;
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
            FilmsGroupBox.Location = new Point(442, 14);
            FilmsGroupBox.Name = "FilmsGroupBox";
            FilmsGroupBox.Size = new Size(358, 275);
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
            RatingTextBox.Size = new Size(125, 27);
            RatingTextBox.TabIndex = 4;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // ReleaseYearTextBox
            // 
            ReleaseYearTextBox.Location = new Point(199, 96);
            ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            ReleaseYearTextBox.Size = new Size(125, 27);
            ReleaseYearTextBox.TabIndex = 3;
            ReleaseYearTextBox.TextChanged += ReleaseYearTextBox_TextChanged;
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(199, 38);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(125, 27);
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
            FilmsListBox.Location = new Point(6, 26);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(182, 244);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
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
            EnumGroupBox.ResumeLayout(false);
            EnumGroupBox.PerformLayout();
            MainTabControl.ResumeLayout(false);
            EnumsPage.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            ClassesPage.ResumeLayout(false);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox EnumGroupBox;
        private ListBox EnumsListBox;
        private Label label1;
        private Label label2;
        private ListBox ValuesListBox;
        private Label label3;
        private TextBox ValueTextBox;
        private TabControl MainTabControl;
        private TabPage EnumsPage;
        private GroupBox WeekdayParsingGroupBox;
        private Button ParseButton;
        private Label ParseOutputLabel;
        private TextBox ParseTextBox;
        private Label label4;
        private GroupBox SeasonGroupBox;
        private Label SeasonLabel;
        private Button GoButton;
        private ComboBox SeasonComboBox;
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
    }
}
