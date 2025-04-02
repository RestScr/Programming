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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            tabPage1 = new TabPage();
            DecreaseRectanglesButton = new PictureBox();
            IncreaseRectanglesButton = new PictureBox();
            DrawnHeightTextBox = new TextBox();
            DrawnWidthTextBox = new TextBox();
            DrawnYTextBox = new TextBox();
            DrawnIdBox = new TextBox();
            DrawnXTextBox = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            DrawnRectanglesBox = new ListBox();
            Canvas = new Panel();
            EnumGroupBox.SuspendLayout();
            MainTabControl.SuspendLayout();
            EnumsPage.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            WeekdayParsingGroupBox.SuspendLayout();
            ClassesPage.SuspendLayout();
            FilmsGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            RectangleCenterGroupBox.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).BeginInit();
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
            MainTabControl.Controls.Add(tabPage1);
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
            // tabPage1
            // 
            tabPage1.Controls.Add(DecreaseRectanglesButton);
            tabPage1.Controls.Add(IncreaseRectanglesButton);
            tabPage1.Controls.Add(DrawnHeightTextBox);
            tabPage1.Controls.Add(DrawnWidthTextBox);
            tabPage1.Controls.Add(DrawnYTextBox);
            tabPage1.Controls.Add(DrawnIdBox);
            tabPage1.Controls.Add(DrawnXTextBox);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(DrawnRectanglesBox);
            tabPage1.Controls.Add(Canvas);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(815, 466);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Rectangles";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DecreaseRectanglesButton
            // 
            DecreaseRectanglesButton.Image = (Image)resources.GetObject("DecreaseRectanglesButton.Image");
            DecreaseRectanglesButton.Location = new Point(100, 200);
            DecreaseRectanglesButton.Name = "DecreaseRectanglesButton";
            DecreaseRectanglesButton.Size = new Size(47, 35);
            DecreaseRectanglesButton.TabIndex = 15;
            DecreaseRectanglesButton.TabStop = false;
            DecreaseRectanglesButton.Click += DecreaseRectanglesButton_Click;
            // 
            // IncreaseRectanglesButton
            // 
            IncreaseRectanglesButton.Image = (Image)resources.GetObject("IncreaseRectanglesButton.Image");
            IncreaseRectanglesButton.Location = new Point(8, 200);
            IncreaseRectanglesButton.Name = "IncreaseRectanglesButton";
            IncreaseRectanglesButton.Size = new Size(47, 35);
            IncreaseRectanglesButton.TabIndex = 14;
            IncreaseRectanglesButton.TabStop = false;
            IncreaseRectanglesButton.Click += IncreaseRectanglesButton_Click;
            // 
            // DrawnHeightTextBox
            // 
            DrawnHeightTextBox.Location = new Point(71, 414);
            DrawnHeightTextBox.Name = "DrawnHeightTextBox";
            DrawnHeightTextBox.Size = new Size(125, 27);
            DrawnHeightTextBox.TabIndex = 13;
            // 
            // DrawnWidthTextBox
            // 
            DrawnWidthTextBox.Location = new Point(71, 380);
            DrawnWidthTextBox.Name = "DrawnWidthTextBox";
            DrawnWidthTextBox.Size = new Size(125, 27);
            DrawnWidthTextBox.TabIndex = 12;
            // 
            // DrawnYTextBox
            // 
            DrawnYTextBox.Location = new Point(71, 344);
            DrawnYTextBox.Name = "DrawnYTextBox";
            DrawnYTextBox.Size = new Size(125, 27);
            DrawnYTextBox.TabIndex = 11;
            // 
            // DrawnIdBox
            // 
            DrawnIdBox.Location = new Point(71, 274);
            DrawnIdBox.Name = "DrawnIdBox";
            DrawnIdBox.Size = new Size(125, 27);
            DrawnIdBox.TabIndex = 10;
            // 
            // DrawnXTextBox
            // 
            DrawnXTextBox.Location = new Point(71, 308);
            DrawnXTextBox.Name = "DrawnXTextBox";
            DrawnXTextBox.Size = new Size(125, 27);
            DrawnXTextBox.TabIndex = 9;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(8, 414);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 8;
            label20.Text = "Height:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(8, 380);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 7;
            label19.Text = "Width:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(40, 347);
            label18.Name = "label18";
            label18.Size = new Size(20, 20);
            label18.TabIndex = 6;
            label18.Text = "Y:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(39, 315);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 5;
            label17.Text = "X:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(35, 281);
            label16.Name = "label16";
            label16.Size = new Size(25, 20);
            label16.TabIndex = 4;
            label16.Text = "Id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(8, 7);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 3;
            label15.Text = "Rectangles:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 251);
            label14.Name = "label14";
            label14.Size = new Size(139, 20);
            label14.TabIndex = 2;
            label14.Text = "Selected Rectangle:";
            // 
            // DrawnRectanglesBox
            // 
            DrawnRectanglesBox.FormattingEnabled = true;
            DrawnRectanglesBox.Location = new Point(8, 30);
            DrawnRectanglesBox.Name = "DrawnRectanglesBox";
            DrawnRectanglesBox.Size = new Size(252, 164);
            DrawnRectanglesBox.TabIndex = 1;
            DrawnRectanglesBox.SelectedIndexChanged += DrawnRectanglesBox_SelectedIndexChanged;
            // 
            // Canvas
            // 
            Canvas.Location = new Point(274, 3);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(538, 467);
            Canvas.TabIndex = 0;
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
            FilmsGroupBox.ResumeLayout(false);
            FilmsGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectangleCenterGroupBox.ResumeLayout(false);
            RectangleCenterGroupBox.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).EndInit();
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
        private GroupBox RectangleCenterGroupBox;
        private Label label11;
        private TextBox CenterYTextBox;
        private TextBox CenterXTextBox;
        private Label label12;
        private Label label13;
        private TextBox IdTextBox;
        private TabPage tabPage1;
        private Panel Canvas;
        private ListBox DrawnRectanglesBox;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label16;
        private Label label20;
        private Label label19;
        private Label label18;
        private TextBox DrawnHeightTextBox;
        private TextBox DrawnWidthTextBox;
        private TextBox DrawnYTextBox;
        private TextBox DrawnIdBox;
        private TextBox DrawnXTextBox;
        private PictureBox DecreaseRectanglesButton;
        private PictureBox IncreaseRectanglesButton;
    }
}
