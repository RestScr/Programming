namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
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
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).BeginInit();
            SuspendLayout();
            // 
            // DecreaseRectanglesButton
            // 
            DecreaseRectanglesButton.Image = Properties.Resources.minus;
            DecreaseRectanglesButton.Location = new Point(136, 224);
            DecreaseRectanglesButton.Name = "DecreaseRectanglesButton";
            DecreaseRectanglesButton.Size = new Size(47, 35);
            DecreaseRectanglesButton.TabIndex = 31;
            DecreaseRectanglesButton.TabStop = false;
            // 
            // IncreaseRectanglesButton
            // 
            IncreaseRectanglesButton.Image = (Image)resources.GetObject("IncreaseRectanglesButton.Image");
            IncreaseRectanglesButton.Location = new Point(44, 224);
            IncreaseRectanglesButton.Name = "IncreaseRectanglesButton";
            IncreaseRectanglesButton.Size = new Size(47, 35);
            IncreaseRectanglesButton.TabIndex = 30;
            IncreaseRectanglesButton.TabStop = false;
            // 
            // DrawnHeightTextBox
            // 
            DrawnHeightTextBox.Location = new Point(107, 438);
            DrawnHeightTextBox.Name = "DrawnHeightTextBox";
            DrawnHeightTextBox.Size = new Size(125, 27);
            DrawnHeightTextBox.TabIndex = 29;
            // 
            // DrawnWidthTextBox
            // 
            DrawnWidthTextBox.Location = new Point(107, 404);
            DrawnWidthTextBox.Name = "DrawnWidthTextBox";
            DrawnWidthTextBox.Size = new Size(125, 27);
            DrawnWidthTextBox.TabIndex = 28;
            // 
            // DrawnYTextBox
            // 
            DrawnYTextBox.Location = new Point(107, 368);
            DrawnYTextBox.Name = "DrawnYTextBox";
            DrawnYTextBox.Size = new Size(125, 27);
            DrawnYTextBox.TabIndex = 27;
            // 
            // DrawnIdBox
            // 
            DrawnIdBox.Location = new Point(107, 298);
            DrawnIdBox.Name = "DrawnIdBox";
            DrawnIdBox.ReadOnly = true;
            DrawnIdBox.Size = new Size(125, 27);
            DrawnIdBox.TabIndex = 26;
            // 
            // DrawnXTextBox
            // 
            DrawnXTextBox.Location = new Point(107, 332);
            DrawnXTextBox.Name = "DrawnXTextBox";
            DrawnXTextBox.Size = new Size(125, 27);
            DrawnXTextBox.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(44, 438);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 24;
            label20.Text = "Height:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(44, 404);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 23;
            label19.Text = "Width:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(76, 371);
            label18.Name = "label18";
            label18.Size = new Size(20, 20);
            label18.TabIndex = 22;
            label18.Text = "Y:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(75, 339);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 21;
            label17.Text = "X:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(71, 305);
            label16.Name = "label16";
            label16.Size = new Size(25, 20);
            label16.TabIndex = 20;
            label16.Text = "Id:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(44, 31);
            label15.Name = "label15";
            label15.Size = new Size(84, 20);
            label15.TabIndex = 19;
            label15.Text = "Rectangles:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(44, 275);
            label14.Name = "label14";
            label14.Size = new Size(139, 20);
            label14.TabIndex = 18;
            label14.Text = "Selected Rectangle:";
            // 
            // DrawnRectanglesBox
            // 
            DrawnRectanglesBox.FormattingEnabled = true;
            DrawnRectanglesBox.Location = new Point(44, 54);
            DrawnRectanglesBox.Name = "DrawnRectanglesBox";
            DrawnRectanglesBox.Size = new Size(252, 164);
            DrawnRectanglesBox.TabIndex = 17;
            // 
            // Canvas
            // 
            Canvas.AutoSize = true;
            Canvas.BorderStyle = BorderStyle.FixedSingle;
            Canvas.Location = new Point(313, 24);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(556, 466);
            Canvas.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DecreaseRectanglesButton);
            Controls.Add(IncreaseRectanglesButton);
            Controls.Add(DrawnHeightTextBox);
            Controls.Add(DrawnWidthTextBox);
            Controls.Add(DrawnYTextBox);
            Controls.Add(DrawnIdBox);
            Controls.Add(DrawnXTextBox);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(DrawnRectanglesBox);
            Controls.Add(Canvas);
            Name = "RectanglesCollisionControl";
            Size = new Size(898, 515);
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox DecreaseRectanglesButton;
        private PictureBox IncreaseRectanglesButton;
        private TextBox DrawnHeightTextBox;
        private TextBox DrawnWidthTextBox;
        private TextBox DrawnYTextBox;
        private TextBox DrawnIdBox;
        private TextBox DrawnXTextBox;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private ListBox DrawnRectanglesBox;
        private Panel Canvas;
    }
}
