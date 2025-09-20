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
            AddItemButton = new Button();
            RemoveItemButton = new Button();
            SuspendLayout();
            // 
            // ItemsList
            // 
            ItemsList.FormattingEnabled = true;
            ItemsList.Location = new Point(21, 44);
            ItemsList.Name = "ItemsList";
            ItemsList.Size = new Size(235, 344);
            ItemsList.TabIndex = 0;
            ItemsList.SelectedIndexChanged += ItemsList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(267, 21);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Selected Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(267, 59);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 97);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 4;
            label4.Text = "Cost:";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(331, 56);
            IDBox.Name = "IDBox";
            IDBox.ReadOnly = true;
            IDBox.Size = new Size(125, 27);
            IDBox.TabIndex = 5;
            // 
            // CostBox
            // 
            CostBox.Location = new Point(331, 94);
            CostBox.Name = "CostBox";
            CostBox.Size = new Size(125, 27);
            CostBox.TabIndex = 6;
            CostBox.TextChanged += CostBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(267, 145);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Name:";
            // 
            // NameRichText
            // 
            NameRichText.Location = new Point(270, 177);
            NameRichText.Name = "NameRichText";
            NameRichText.Size = new Size(555, 102);
            NameRichText.TabIndex = 8;
            NameRichText.Text = "";
            NameRichText.TextChanged += NameRichText_TextChanged;
            NameRichText.Leave += NameRichText_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 291);
            label6.Name = "label6";
            label6.Size = new Size(88, 20);
            label6.TabIndex = 9;
            label6.Text = "Description:";
            // 
            // DescriptionRichText
            // 
            DescriptionRichText.Location = new Point(270, 323);
            DescriptionRichText.Name = "DescriptionRichText";
            DescriptionRichText.Size = new Size(555, 125);
            DescriptionRichText.TabIndex = 10;
            DescriptionRichText.Text = "";
            DescriptionRichText.TextChanged += DescriptionRichText_TextChanged;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(21, 394);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(91, 54);
            AddItemButton.TabIndex = 11;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(118, 394);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(91, 54);
            RemoveItemButton.TabIndex = 12;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(DescriptionRichText);
            Controls.Add(label6);
            Controls.Add(NameRichText);
            Controls.Add(label5);
            Controls.Add(CostBox);
            Controls.Add(IDBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ItemsList);
            Name = "ItemsTab";
            Size = new Size(843, 470);
            Load += ItemsTab_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Button AddItemButton;
        private Button RemoveItemButton;
    }
}
