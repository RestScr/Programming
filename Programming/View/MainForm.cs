namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            EnumsBox = new GroupBox();
            EnumerationBox = new ListBox();
            label1 = new Label();
            ValueBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            IntValueBox = new TextBox();
            groupBox1 = new GroupBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            EnumsBox.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(945, 602);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(EnumsBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(937, 569);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(826, 383);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // EnumsBox
            // 
            EnumsBox.Controls.Add(IntValueBox);
            EnumsBox.Controls.Add(label3);
            EnumsBox.Controls.Add(label2);
            EnumsBox.Controls.Add(ValueBox);
            EnumsBox.Controls.Add(label1);
            EnumsBox.Controls.Add(EnumerationBox);
            EnumsBox.Location = new Point(6, 6);
            EnumsBox.Name = "EnumsBox";
            EnumsBox.Size = new Size(925, 358);
            EnumsBox.TabIndex = 0;
            EnumsBox.TabStop = false;
            EnumsBox.Text = "Enums";
            // 
            // EnumerationBox
            // 
            EnumerationBox.FormattingEnabled = true;
            EnumerationBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "SmartphoneManufacturers", "Season", "Weekday" });
            EnumerationBox.Location = new Point(15, 66);
            EnumerationBox.Name = "EnumerationBox";
            EnumerationBox.Size = new Size(259, 264);
            EnumerationBox.TabIndex = 0;
            EnumerationBox.SelectedIndexChanged += EnumerationBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 35);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose enumeration:";
            // 
            // ValueBox
            // 
            ValueBox.FormattingEnabled = true;
            ValueBox.Location = new Point(308, 66);
            ValueBox.Name = "ValueBox";
            ValueBox.Size = new Size(259, 264);
            ValueBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 35);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 35);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 4;
            label3.Text = "Int value:";
            // 
            // IntValueBox
            // 
            IntValueBox.Location = new Point(586, 66);
            IntValueBox.Name = "IntValueBox";
            IntValueBox.Size = new Size(204, 27);
            IntValueBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(6, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 181);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Weekday Parsing";
            // 
            // MainForm
            // 
            ClientSize = new Size(969, 626);
            Controls.Add(tabControl1);
            Name = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            EnumsBox.ResumeLayout(false);
            EnumsBox.PerformLayout();
            ResumeLayout(false);
        }

        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox EnumsBox;
        private Label label2;
        private ListBox ValueBox;
        private Label label1;
        private ListBox EnumerationBox;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox IntValueBox;
        private TabPage tabPage2;

        private void EnumerationBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
