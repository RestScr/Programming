namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            panel8 = new Panel();
            OrdersData = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Created = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            panel7 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            OrdersItemsListBox = new ListBox();
            panel11 = new Panel();
            AmountLabel = new Label();
            label7 = new Label();
            panel9 = new Panel();
            label3 = new Label();
            panel5 = new Panel();
            DeliveryAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            panel4 = new Panel();
            PriorityPanel = new Panel();
            DeliveryTimeComboBox = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            OrderStatusComboBox = new ComboBox();
            CreationDateTextBox = new TextBox();
            IdTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            panel13 = new Panel();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersData).BeginInit();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            panel10.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            PriorityPanel.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 761);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(OrdersData);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 20);
            panel8.Name = "panel8";
            panel8.Size = new Size(554, 741);
            panel8.TabIndex = 1;
            // 
            // OrdersData
            // 
            OrdersData.AllowUserToAddRows = false;
            OrdersData.AllowUserToDeleteRows = false;
            OrdersData.AllowUserToResizeColumns = false;
            OrdersData.AllowUserToResizeRows = false;
            OrdersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersData.Columns.AddRange(new DataGridViewColumn[] { Id, Created, OrderStatus, CustomerName });
            OrdersData.Dock = DockStyle.Fill;
            OrdersData.Location = new Point(0, 0);
            OrdersData.Name = "OrdersData";
            OrdersData.ReadOnly = true;
            OrdersData.RowHeadersWidth = 51;
            OrdersData.Size = new Size(554, 741);
            OrdersData.StandardTab = true;
            OrdersData.TabIndex = 0;
            OrdersData.SelectionChanged += OrdersData_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // Created
            // 
            Created.HeaderText = "Created";
            Created.MinimumWidth = 6;
            Created.Name = "Created";
            Created.ReadOnly = true;
            Created.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 125;
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "Customer Full Name";
            CustomerName.MinimumWidth = 6;
            CustomerName.Name = "CustomerName";
            CustomerName.ReadOnly = true;
            CustomerName.Width = 125;
            // 
            // panel7
            // 
            panel7.Controls.Add(label1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(554, 20);
            panel7.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Orders";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(554, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 761);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(570, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(810, 761);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 396);
            panel6.Name = "panel6";
            panel6.Size = new Size(810, 365);
            panel6.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel12);
            panel10.Controls.Add(panel11);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 23);
            panel10.Name = "panel10";
            panel10.Size = new Size(810, 342);
            panel10.TabIndex = 1;
            // 
            // panel12
            // 
            panel12.Controls.Add(OrdersItemsListBox);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(810, 180);
            panel12.TabIndex = 1;
            // 
            // OrdersItemsListBox
            // 
            OrdersItemsListBox.Dock = DockStyle.Fill;
            OrdersItemsListBox.FormattingEnabled = true;
            OrdersItemsListBox.Location = new Point(0, 0);
            OrdersItemsListBox.Name = "OrdersItemsListBox";
            OrdersItemsListBox.Size = new Size(810, 180);
            OrdersItemsListBox.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.Controls.Add(AmountLabel);
            panel11.Controls.Add(label7);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 180);
            panel11.Name = "panel11";
            panel11.Size = new Size(810, 162);
            panel11.TabIndex = 0;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            AmountLabel.Location = new Point(714, 33);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(24, 32);
            AmountLabel.TabIndex = 1;
            AmountLabel.Text = "-";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(714, 13);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 0;
            label7.Text = "Amount:";
            // 
            // panel9
            // 
            panel9.Controls.Add(label3);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(810, 23);
            panel9.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 0;
            label3.Text = "Order Items";
            // 
            // panel5
            // 
            panel5.Controls.Add(DeliveryAddressControl);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(810, 204);
            panel5.TabIndex = 1;
            // 
            // DeliveryAddressControl
            // 
            DeliveryAddressControl.AutoSize = true;
            DeliveryAddressControl.DeliveryAddress = null;
            DeliveryAddressControl.Dock = DockStyle.Fill;
            DeliveryAddressControl.Location = new Point(0, 0);
            DeliveryAddressControl.Name = "DeliveryAddressControl";
            DeliveryAddressControl.Size = new Size(810, 204);
            DeliveryAddressControl.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel13);
            panel4.Controls.Add(PriorityPanel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(810, 192);
            panel4.TabIndex = 0;
            // 
            // PriorityPanel
            // 
            PriorityPanel.Controls.Add(DeliveryTimeComboBox);
            PriorityPanel.Controls.Add(label8);
            PriorityPanel.Controls.Add(label9);
            PriorityPanel.Dock = DockStyle.Right;
            PriorityPanel.Location = new Point(316, 0);
            PriorityPanel.Name = "PriorityPanel";
            PriorityPanel.Size = new Size(494, 192);
            PriorityPanel.TabIndex = 10;
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Items.AddRange(new object[] { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" });
            DeliveryTimeComboBox.Location = new Point(125, 38);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(125, 28);
            DeliveryTimeComboBox.TabIndex = 9;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(4, 4);
            label8.Name = "label8";
            label8.Size = new Size(120, 20);
            label8.TabIndex = 7;
            label8.Text = "Priority Options";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 41);
            label9.Name = "label9";
            label9.Size = new Size(103, 20);
            label9.TabIndex = 8;
            label9.Text = "Delivery Time:";
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(92, 114);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(125, 28);
            OrderStatusComboBox.TabIndex = 6;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // CreationDateTextBox
            // 
            CreationDateTextBox.Location = new Point(92, 71);
            CreationDateTextBox.Name = "CreationDateTextBox";
            CreationDateTextBox.ReadOnly = true;
            CreationDateTextBox.Size = new Size(125, 27);
            CreationDateTextBox.TabIndex = 5;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(92, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(125, 27);
            IdTextBox.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 122);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 3;
            label6.Text = "Status:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 78);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 2;
            label5.Text = "Created:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 37);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 1;
            label4.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 7);
            label2.Name = "label2";
            label2.Size = new Size(111, 20);
            label2.TabIndex = 0;
            label2.Text = "Selected Order";
            // 
            // panel13
            // 
            panel13.Controls.Add(label2);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(OrderStatusComboBox);
            panel13.Controls.Add(label5);
            panel13.Controls.Add(CreationDateTextBox);
            panel13.Controls.Add(label6);
            panel13.Controls.Add(IdTextBox);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(316, 192);
            panel13.TabIndex = 11;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OrdersTab";
            Size = new Size(1380, 761);
            Load += OrdersTab_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersData).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            PriorityPanel.ResumeLayout(false);
            PriorityPanel.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label label2;
        private Panel panel8;
        private DataGridView OrdersData;
        private Panel panel7;
        private Label label1;
        private Panel panel9;
        private Panel panel10;
        private Label label3;
        private Controls.AddressControl DeliveryAddressControl;
        private Label label4;
        private Label label6;
        private Label label5;
        private ComboBox OrderStatusComboBox;
        private TextBox CreationDateTextBox;
        private TextBox IdTextBox;
        private Panel panel12;
        private ListBox OrdersItemsListBox;
        private Panel panel11;
        private Label AmountLabel;
        private Label label7;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Created;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn CustomerName;
        private Label label9;
        private Label label8;
        private ComboBox DeliveryTimeComboBox;
        private Panel PriorityPanel;
        private Panel panel13;
    }
}
