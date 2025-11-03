namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            IDBox = new TextBox();
            CostBox = new TextBox();
            label5 = new Label();
            NameRichText = new RichTextBox();
            label6 = new Label();
            DescriptionRichText = new RichTextBox();
            panel1 = new Panel();
            CategoryComboBox = new ComboBox();
            label7 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsList
            // 
            ItemsList.Dock = DockStyle.Left;
            ItemsList.FormattingEnabled = true;
            ItemsList.Location = new Point(0, 20);
            ItemsList.Name = "ItemsList";
            ItemsList.Size = new Size(302, 353);
            ItemsList.TabIndex = 0;
            ItemsList.SelectedIndexChanged += ItemsList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Selected Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 56);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 94);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "Cost:";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(101, 49);
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(151, 27);
            IDBox.TabIndex = 5;
            // 
            // CostBox
            // 
            CostBox.Location = new Point(101, 91);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(151, 27);
            CostBox.TabIndex = 6;
            CostBox.TextChanged += CostBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 177);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Name:";
            // 
            // NameRichText
            // 
            NameRichText.Location = new Point(12, 209);
            NameRichText.MaxLength = 200;
            NameRichText.Name = "NameRichText";
            NameRichText.Size = new Size(558, 82);
            NameRichText.TabIndex = 8;
            NameRichText.Text = "";
            NameRichText.TextChanged += NameRichText_TextChanged;
            NameRichText.Leave += NameRichText_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 324);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 9;
            label6.Text = "Description:";
            // 
            // DescriptionRichText
            // 
            DescriptionRichText.Location = new Point(15, 347);
            DescriptionRichText.MaxLength = 1000;
            DescriptionRichText.Name = "DescriptionRichText";
            DescriptionRichText.Size = new Size(555, 94);
            DescriptionRichText.TabIndex = 10;
            DescriptionRichText.Text = "";
            DescriptionRichText.TextChanged += DescriptionRichText_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(CategoryComboBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DescriptionRichText);
            panel1.Controls.Add(IDBox);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(CostBox);
            panel1.Controls.Add(NameRichText);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(302, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 491);
            panel1.TabIndex = 13;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Enabled = false;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(101, 130);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(151, 28);
            CategoryComboBox.TabIndex = 12;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 138);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 11;
            label7.Text = "Category:";
            // 
            // panel2
            // 
            panel2.Controls.Add(ItemsList);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 491);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(AddItemButton);
            panel3.Controls.Add(RemoveItemButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 118);
            panel3.TabIndex = 13;
            // 
            // AddItemButton
            // 
            AddItemButton.Dock = DockStyle.Left;
            AddItemButton.Location = new Point(86, 0);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(88, 118);
            AddItemButton.TabIndex = 11;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Dock = DockStyle.Left;
            RemoveItemButton.Location = new Point(0, 0);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(86, 118);
            RemoveItemButton.TabIndex = 12;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ItemsTab";
            Size = new Size(916, 491);
            Load += ItemsTab_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ItemsList;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox IDBox;
        private TextBox CostBox;
        private Label label5;
        private RichTextBox NameRichText;
        private Label label6;
        private RichTextBox DescriptionRichText;
        private Panel panel1;
        private Panel panel2;
        private ComboBox CategoryComboBox;
        private Label label7;
        private Panel panel3;
        private Button AddItemButton;
        private Button RemoveItemButton;
    }
}
