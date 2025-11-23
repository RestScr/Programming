namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            panel7 = new Panel();
            DeliveryTimeBox = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            panel6 = new Panel();
            StatusComboBox = new ComboBox();
            CreationTextBox = new TextBox();
            IDTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            ItemsListBox = new ListBox();
            label1 = new Label();
            panel4 = new Panel();
            DeliveryAddress = new ObjectOrientedPractics.View.Controls.AddressControl();
            panel3 = new Panel();
            panel9 = new Panel();
            ClearOrderButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            panel8 = new Panel();
            panel10 = new Panel();
            label2 = new Label();
            CostLabel = new Label();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel10.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(817, 120);
            panel1.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(DeliveryTimeBox);
            panel7.Controls.Add(label8);
            panel7.Controls.Add(label4);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(331, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(486, 120);
            panel7.TabIndex = 1;
            // 
            // DeliveryTimeBox
            // 
            DeliveryTimeBox.FormattingEnabled = true;
            DeliveryTimeBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeBox.Location = new Point(109, 24);
            DeliveryTimeBox.Name = "DeliveryTimeBox";
            DeliveryTimeBox.Size = new Size(151, 28);
            DeliveryTimeBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 27);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 7;
            label8.Text = "Delivery Time:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 0;
            label4.Text = "Priority Options";
            // 
            // panel6
            // 
            panel6.Controls.Add(StatusComboBox);
            panel6.Controls.Add(CreationTextBox);
            panel6.Controls.Add(IDTextBox);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(label3);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(331, 120);
            panel6.TabIndex = 0;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "New", "Processing", "Assembly", "Sent", "Delivered", "Returned", "Abandoned" });
            StatusComboBox.Location = new Point(97, 90);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(125, 28);
            StatusComboBox.TabIndex = 6;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // CreationTextBox
            // 
            CreationTextBox.Location = new Point(97, 57);
            CreationTextBox.Name = "CreationTextBox";
            CreationTextBox.ReadOnly = true;
            CreationTextBox.Size = new Size(125, 27);
            CreationTextBox.TabIndex = 5;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(97, 24);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(125, 27);
            IDTextBox.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 94);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 3;
            label7.Text = "Status:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 62);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 2;
            label6.Text = "Created:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 31);
            label5.Name = "label5";
            label5.Size = new Size(27, 20);
            label5.TabIndex = 1;
            label5.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 0;
            label3.Text = "Selected Order";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(817, 536);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(ItemsListBox);
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 197);
            panel5.Name = "panel5";
            panel5.Size = new Size(817, 339);
            panel5.TabIndex = 1;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(0, 20);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(817, 319);
            ItemsListBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Order Items";
            // 
            // panel4
            // 
            panel4.Controls.Add(DeliveryAddress);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(817, 197);
            panel4.TabIndex = 0;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.AutoSize = true;
            DeliveryAddress.DeliveryAddress = null;
            DeliveryAddress.Dock = DockStyle.Fill;
            DeliveryAddress.Location = new Point(0, 0);
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.Size = new Size(817, 197);
            DeliveryAddress.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 496);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 160);
            panel3.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(ClearOrderButton);
            panel9.Controls.Add(RemoveItemButton);
            panel9.Controls.Add(AddItemButton);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(0, 95);
            panel9.Name = "panel9";
            panel9.Size = new Size(817, 65);
            panel9.TabIndex = 1;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Dock = DockStyle.Right;
            ClearOrderButton.Location = new Point(683, 0);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(134, 65);
            ClearOrderButton.TabIndex = 2;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(156, 0);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(156, 65);
            RemoveItemButton.TabIndex = 1;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(3, 0);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(147, 65);
            AddItemButton.TabIndex = 0;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(panel10);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(817, 95);
            panel8.TabIndex = 0;
            // 
            // panel10
            // 
            panel10.Controls.Add(label2);
            panel10.Controls.Add(CostLabel);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(666, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(151, 95);
            panel10.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 0;
            label2.Text = "Amount:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CostLabel.Location = new Point(46, 31);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(28, 38);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "-";
            CostLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "PriorityOrdersTab";
            Size = new Size(817, 656);
            Load += PriorityOrdersTab_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel5;
        private ListBox ItemsListBox;
        private Label label1;
        private Panel panel4;
        private Controls.AddressControl DeliveryAddress;
        private Panel panel9;
        private Panel panel8;
        private Button ClearOrderButton;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Label CostLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CreationTextBox;
        private TextBox IDTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private ComboBox StatusComboBox;
        private ComboBox DeliveryTimeBox;
        private Label label8;
        private Panel panel10;
    }
}
