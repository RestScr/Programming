namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            panel1 = new Panel();
            UpdateButton = new Button();
            CalculateButton = new Button();
            ApplyButton = new Button();
            DiscountInfoLabel = new Label();
            panel2 = new Panel();
            DiscountAmountLabel = new Label();
            ProductsAmountLabel = new Label();
            label1 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(UpdateButton);
            panel1.Controls.Add(CalculateButton);
            panel1.Controls.Add(ApplyButton);
            panel1.Controls.Add(DiscountInfoLabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 158);
            panel1.TabIndex = 0;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(260, 37);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(115, 58);
            UpdateButton.TabIndex = 3;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(18, 37);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(115, 58);
            CalculateButton.TabIndex = 2;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(139, 37);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(115, 58);
            ApplyButton.TabIndex = 1;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // DiscountInfoLabel
            // 
            DiscountInfoLabel.AutoSize = true;
            DiscountInfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountInfoLabel.Location = new Point(18, 14);
            DiscountInfoLabel.Name = "DiscountInfoLabel";
            DiscountInfoLabel.Size = new Size(46, 20);
            DiscountInfoLabel.TabIndex = 0;
            DiscountInfoLabel.Text = "Info: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(DiscountAmountLabel);
            panel2.Controls.Add(ProductsAmountLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(442, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 158);
            panel2.TabIndex = 1;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(84, 104);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(23, 31);
            DiscountAmountLabel.TabIndex = 3;
            DiscountAmountLabel.Text = "-";
            DiscountAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductsAmountLabel
            // 
            ProductsAmountLabel.AutoSize = true;
            ProductsAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ProductsAmountLabel.ImageAlign = ContentAlignment.MiddleRight;
            ProductsAmountLabel.Location = new Point(84, 34);
            ProductsAmountLabel.Name = "ProductsAmountLabel";
            ProductsAmountLabel.Size = new Size(23, 31);
            ProductsAmountLabel.TabIndex = 2;
            ProductsAmountLabel.Text = "-";
            ProductsAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(27, 84);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Discount Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(27, 14);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 0;
            label3.Text = "Products Amount";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(418, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(24, 158);
            panel3.TabIndex = 2;
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DiscountsTab";
            Size = new Size(611, 158);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label DiscountInfoLabel;
        private Panel panel2;
        private Panel panel3;
        private Button ApplyButton;
        private Button UpdateButton;
        private Button CalculateButton;
        private Label ProductsAmountLabel;
        private Label label1;
        private Label label3;
        private Label DiscountAmountLabel;
    }
}
