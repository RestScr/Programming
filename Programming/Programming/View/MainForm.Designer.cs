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
            groupBox1 = new GroupBox();
            label3 = new Label();
            IntBox = new TextBox();
            label2 = new Label();
            ValuesListBox = new ListBox();
            label1 = new Label();
            EnumsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(IntBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1001, 307);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(509, 27);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 5;
            label3.Text = "Int value:";
            // 
            // IntBox
            // 
            IntBox.Location = new Point(509, 50);
            IntBox.Name = "IntBox";
            IntBox.Size = new Size(125, 27);
            IntBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 27);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 3;
            label2.Text = "Choose value";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.Location = new Point(275, 50);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(192, 224);
            ValuesListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 1;
            label1.Text = "Choose enumeration:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.Items.AddRange(new object[] { "Color", "EducationForm", "Genre", "Season", "SmartphoneManufacturers", "Weekday" });
            EnumsListBox.Location = new Point(24, 50);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(192, 224);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 546);
            Controls.Add(groupBox1);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox EnumsListBox;
        private Label label1;
        private Label label2;
        private ListBox ValuesListBox;
        private Label label3;
        private TextBox IntBox;
    }
}
