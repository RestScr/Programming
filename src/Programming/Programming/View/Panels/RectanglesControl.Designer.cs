namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            RectanglesGroupBox.SuspendLayout();
            RectangleCenterGroupBox.SuspendLayout();
            SuspendLayout();
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
            RectanglesGroupBox.Location = new Point(3, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(380, 447);
            RectanglesGroupBox.TabIndex = 2;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            RectanglesGroupBox.Enter += RectanglesGroupBox_Enter;
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
            label6.Location = new Point(199, 66);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 6;
            label6.Text = "Width";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 116);
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
            WidthTextBox.Location = new Point(199, 86);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(159, 27);
            WidthTextBox.TabIndex = 3;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Location = new Point(199, 139);
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
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RectanglesGroupBox);
            Name = "RectanglesControl";
            Size = new Size(385, 450);
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            RectangleCenterGroupBox.ResumeLayout(false);
            RectangleCenterGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private TextBox IdTextBox;
        private Label label13;
        private GroupBox RectangleCenterGroupBox;
        private TextBox CenterYTextBox;
        private TextBox CenterXTextBox;
        private Label label12;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox ColorTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private Button FindRectangleButton;
        private ListBox RectanglesListBox;
    }
}
