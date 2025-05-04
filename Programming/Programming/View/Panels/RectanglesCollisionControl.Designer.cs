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
            label14 = new Label();
            DrawnRectanglesBox = new ListBox();
            Canvas = new Panel();
            CollisionRectanglesGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).BeginInit();
            CollisionRectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // DecreaseRectanglesButton
            // 
            DecreaseRectanglesButton.Image = Properties.Resources.minus;
            DecreaseRectanglesButton.Location = new Point(194, 204);
            DecreaseRectanglesButton.Name = "DecreaseRectanglesButton";
            DecreaseRectanglesButton.Size = new Size(47, 35);
            DecreaseRectanglesButton.TabIndex = 31;
            DecreaseRectanglesButton.TabStop = false;
            DecreaseRectanglesButton.Click += DecreaseRectanglesButton_Click;
            DecreaseRectanglesButton.MouseLeave += DecreaseRectanglesButton_MouseLeave;
            DecreaseRectanglesButton.MouseHover += DecreaseRectanglesButton_MouseHover;
            // 
            // IncreaseRectanglesButton
            // 
            IncreaseRectanglesButton.Image = (Image)resources.GetObject("IncreaseRectanglesButton.Image");
            IncreaseRectanglesButton.Location = new Point(15, 204);
            IncreaseRectanglesButton.Name = "IncreaseRectanglesButton";
            IncreaseRectanglesButton.Size = new Size(47, 35);
            IncreaseRectanglesButton.TabIndex = 30;
            IncreaseRectanglesButton.TabStop = false;
            IncreaseRectanglesButton.Click += IncreaseRectanglesButton_Click;
            IncreaseRectanglesButton.MouseLeave += IncreaseRectanglesButton_MouseLeave;
            IncreaseRectanglesButton.MouseHover += IncreaseRectanglesButton_MouseHover;
            // 
            // DrawnHeightTextBox
            // 
            DrawnHeightTextBox.Location = new Point(73, 419);
            DrawnHeightTextBox.Name = "DrawnHeightTextBox";
            DrawnHeightTextBox.Size = new Size(125, 27);
            DrawnHeightTextBox.TabIndex = 29;
            DrawnHeightTextBox.TextChanged += DrawnHeightTextBox_TextChanged;
            // 
            // DrawnWidthTextBox
            // 
            DrawnWidthTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DrawnWidthTextBox.Location = new Point(73, 382);
            DrawnWidthTextBox.Name = "DrawnWidthTextBox";
            DrawnWidthTextBox.Size = new Size(135, 27);
            DrawnWidthTextBox.TabIndex = 28;
            DrawnWidthTextBox.TextChanged += DrawnWidthTextBox_TextChanged;
            // 
            // DrawnYTextBox
            // 
            DrawnYTextBox.Location = new Point(73, 347);
            DrawnYTextBox.Name = "DrawnYTextBox";
            DrawnYTextBox.Size = new Size(125, 27);
            DrawnYTextBox.TabIndex = 27;
            DrawnYTextBox.TextChanged += DrawnYTextBox_TextChanged;
            // 
            // DrawnIdBox
            // 
            DrawnIdBox.Location = new Point(73, 281);
            DrawnIdBox.Name = "DrawnIdBox";
            DrawnIdBox.ReadOnly = true;
            DrawnIdBox.Size = new Size(125, 27);
            DrawnIdBox.TabIndex = 26;
            // 
            // DrawnXTextBox
            // 
            DrawnXTextBox.Location = new Point(73, 314);
            DrawnXTextBox.Name = "DrawnXTextBox";
            DrawnXTextBox.Size = new Size(125, 27);
            DrawnXTextBox.TabIndex = 25;
            DrawnXTextBox.TextChanged += DrawnXTextBox_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(14, 422);
            label20.Name = "label20";
            label20.Size = new Size(57, 20);
            label20.TabIndex = 24;
            label20.Text = "Height:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 389);
            label19.Name = "label19";
            label19.Size = new Size(52, 20);
            label19.TabIndex = 23;
            label19.Text = "Width:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(15, 352);
            label18.Name = "label18";
            label18.Size = new Size(20, 20);
            label18.TabIndex = 22;
            label18.Text = "Y:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(15, 317);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 21;
            label17.Text = "X:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 284);
            label16.Name = "label16";
            label16.Size = new Size(25, 20);
            label16.TabIndex = 20;
            label16.Text = "Id:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(14, 258);
            label14.Name = "label14";
            label14.Size = new Size(139, 20);
            label14.TabIndex = 18;
            label14.Text = "Selected Rectangle:";
            // 
            // DrawnRectanglesBox
            // 
            DrawnRectanglesBox.FormattingEnabled = true;
            DrawnRectanglesBox.Location = new Point(15, 26);
            DrawnRectanglesBox.Name = "DrawnRectanglesBox";
            DrawnRectanglesBox.Size = new Size(226, 164);
            DrawnRectanglesBox.TabIndex = 17;
            DrawnRectanglesBox.SelectedIndexChanged += DrawnRectanglesBox_SelectedIndexChanged;
            // 
            // Canvas
            // 
            Canvas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Canvas.BorderStyle = BorderStyle.FixedSingle;
            Canvas.Location = new Point(260, 26);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(522, 420);
            Canvas.TabIndex = 16;
            // 
            // CollisionRectanglesGroupBox
            // 
            CollisionRectanglesGroupBox.Controls.Add(DrawnRectanglesBox);
            CollisionRectanglesGroupBox.Controls.Add(Canvas);
            CollisionRectanglesGroupBox.Controls.Add(DrawnHeightTextBox);
            CollisionRectanglesGroupBox.Controls.Add(DecreaseRectanglesButton);
            CollisionRectanglesGroupBox.Controls.Add(label20);
            CollisionRectanglesGroupBox.Controls.Add(DrawnWidthTextBox);
            CollisionRectanglesGroupBox.Controls.Add(IncreaseRectanglesButton);
            CollisionRectanglesGroupBox.Controls.Add(DrawnYTextBox);
            CollisionRectanglesGroupBox.Controls.Add(label19);
            CollisionRectanglesGroupBox.Controls.Add(label14);
            CollisionRectanglesGroupBox.Controls.Add(DrawnXTextBox);
            CollisionRectanglesGroupBox.Controls.Add(DrawnIdBox);
            CollisionRectanglesGroupBox.Controls.Add(label18);
            CollisionRectanglesGroupBox.Controls.Add(label16);
            CollisionRectanglesGroupBox.Controls.Add(label17);
            CollisionRectanglesGroupBox.Dock = DockStyle.Fill;
            CollisionRectanglesGroupBox.Location = new Point(0, 0);
            CollisionRectanglesGroupBox.Name = "CollisionRectanglesGroupBox";
            CollisionRectanglesGroupBox.Size = new Size(811, 470);
            CollisionRectanglesGroupBox.TabIndex = 32;
            CollisionRectanglesGroupBox.TabStop = false;
            CollisionRectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(CollisionRectanglesGroupBox);
            Name = "RectanglesCollisionControl";
            Size = new Size(811, 470);
            Load += RectanglesCollisionControl_Load;
            ((System.ComponentModel.ISupportInitialize)DecreaseRectanglesButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)IncreaseRectanglesButton).EndInit();
            CollisionRectanglesGroupBox.ResumeLayout(false);
            CollisionRectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
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
        private Label label14;
        private ListBox DrawnRectanglesBox;
        private Panel Canvas;
        private GroupBox CollisionRectanglesGroupBox;
    }
}
