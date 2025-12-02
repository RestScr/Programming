namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            CustomersList = new ListBox();
            label1 = new Label();
            panel3 = new Panel();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            panel2 = new Panel();
            panel5 = new Panel();
            AddressField = new ObjectOrientedPractics.View.Controls.AddressControl();
            panel4 = new Panel();
            RemoveButton = new Button();
            AddDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            label5 = new Label();
            CustomerField = new Panel();
            PriorityCheckBox = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            CustomerFullnameBox = new TextBox();
            label4 = new Label();
            CustomerIDBox = new TextBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            CustomerField.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(CustomersList);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 563);
            panel1.TabIndex = 0;
            // 
            // CustomersList
            // 
            CustomersList.Dock = DockStyle.Left;
            CustomersList.FormattingEnabled = true;
            CustomersList.Location = new Point(0, 20);
            CustomersList.Name = "CustomersList";
            CustomersList.Size = new Size(307, 466);
            CustomersList.TabIndex = 1;
            CustomersList.SelectedIndexChanged += CustomersList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // panel3
            // 
            panel3.Controls.Add(RemoveCustomerButton);
            panel3.Controls.Add(AddCustomerButton);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 486);
            panel3.Name = "panel3";
            panel3.Size = new Size(313, 77);
            panel3.TabIndex = 8;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Location = new Point(111, 3);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(94, 67);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(3, 3);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(102, 67);
            AddCustomerButton.TabIndex = 3;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(CustomerField);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(313, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 563);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(AddressField);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 203);
            panel5.TabIndex = 10;
            // 
            // AddressField
            // 
            AddressField.AutoSize = true;
            AddressField.DeliveryAddress = null;
            AddressField.Dock = DockStyle.Fill;
            AddressField.Location = new Point(0, 0);
            AddressField.Dock = DockStyle.Top;
            AddressField.Location = new Point(0, 161);
            AddressField.Name = "AddressField";
            AddressField.Size = new Size(600, 203);
            AddressField.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.Controls.Add(RemoveButton);
            panel4.Controls.Add(AddDiscountButton);
            panel4.Controls.Add(DiscountsListBox);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 328);
            panel4.Name = "panel4";
            panel4.Size = new Size(600, 235);
            panel4.TabIndex = 9;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(432, 85);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(155, 53);
            RemoveButton.TabIndex = 3;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(432, 26);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(155, 53);
            AddDiscountButton.TabIndex = 2;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.Location = new Point(6, 26);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(420, 124);
            DiscountsListBox.TabIndex = 1;
            DiscountsListBox.SelectedIndexChanged += DiscountsListBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(3, 3);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 0;
            label5.Text = "Discounts";
            // 
            // CustomerField
            // 
            CustomerField.Controls.Add(PriorityCheckBox);
            CustomerField.Controls.Add(label2);
            CustomerField.Controls.Add(label3);
            CustomerField.Controls.Add(CustomerFullnameBox);
            CustomerField.Controls.Add(label4);
            CustomerField.Controls.Add(CustomerIDBox);
            CustomerField.Dock = DockStyle.Top;
            CustomerField.Location = new Point(0, 0);
            CustomerField.Name = "CustomerField";
            CustomerField.Size = new Size(600, 161);
            CustomerField.TabIndex = 8;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(91, 131);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(92, 24);
            PriorityCheckBox.TabIndex = 7;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Selected Customer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 54);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // CustomerFullnameBox
            // 
            CustomerFullnameBox.Location = new Point(91, 90);
            CustomerFullnameBox.MaxLength = 200;
            CustomerFullnameBox.Name = "CustomerFullnameBox";
            CustomerFullnameBox.Size = new Size(496, 27);
            CustomerFullnameBox.TabIndex = 6;
            CustomerFullnameBox.TextChanged += CustomerFullnameBox_TextChanged;
            CustomerFullnameBox.Leave += CustomerFullnameBox_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 93);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Full Name:";
            // 
            // CustomerIDBox
            // 
            CustomerIDBox.Enabled = false;
            CustomerIDBox.Location = new Point(91, 51);
            CustomerIDBox.Name = "CustomerIDBox";
            CustomerIDBox.Size = new Size(125, 27);
            CustomerIDBox.TabIndex = 5;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomersTab";
            Size = new Size(916, 563);
            Load += CustomerTab_Load;
            VisibleChanged += CustomersTab_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            CustomerField.ResumeLayout(false);
            CustomerField.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private ListBox CustomersList;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private TextBox CustomerIDBox;
        private Label label4;
        private Label label3;
        private TextBox CustomerFullnameBox;
        private Controls.AddressControl AddressField;
        private Panel panel3;
        private Panel CustomerField;
        private Panel panel5;
        private Panel panel4;
        private ListBox DiscountsListBox;
        private Label label5;
        private Button AddDiscountButton;
        private Button RemoveButton;
        private CheckBox PriorityCheckBox;
    }
}
