namespace Programming.View.Panels
{
    partial class WeekdayParsingGroupControl
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
            WeekdayParsingGroupBox = new GroupBox();
            ParseButton = new Button();
            ParseOutputLabel = new Label();
            ParseTextBox = new TextBox();
            label4 = new Label();
            WeekdayParsingGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            WeekdayParsingGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            WeekdayParsingGroupBox.Controls.Add(ParseButton);
            WeekdayParsingGroupBox.Controls.Add(ParseOutputLabel);
            WeekdayParsingGroupBox.Controls.Add(ParseTextBox);
            WeekdayParsingGroupBox.Controls.Add(label4);
            WeekdayParsingGroupBox.Location = new Point(3, 3);
            WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            WeekdayParsingGroupBox.Size = new Size(412, 131);
            WeekdayParsingGroupBox.TabIndex = 2;
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
            // WeekdayParsingGroupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WeekdayParsingGroupBox);
            Name = "WeekdayParsingGroupControl";
            Size = new Size(418, 137);
            WeekdayParsingGroupBox.ResumeLayout(false);
            WeekdayParsingGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox WeekdayParsingGroupBox;
        private Button ParseButton;
        private Label ParseOutputLabel;
        private TextBox ParseTextBox;
        private Label label4;
    }
}
