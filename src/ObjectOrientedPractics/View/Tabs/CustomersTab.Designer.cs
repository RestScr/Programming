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
            AddressField = new ObjectOrientedPractics.View.Controls.AddressControl();
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
            panel1.Size = new Size(313, 490);
            panel1.TabIndex = 0;
            // 
            // CustomersList
            // 
            CustomersList.Dock = DockStyle.Left;
            CustomersList.FormattingEnabled = true;
            CustomersList.Location = new Point(0, 20);
            CustomersList.Name = "CustomersList";
            CustomersList.Size = new Size(307, 393);
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
            panel3.Location = new Point(0, 413);
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
            panel2.Controls.Add(AddressField);
            panel2.Controls.Add(CustomerField);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(313, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 490);
            panel2.TabIndex = 1;
            // 
            // AddressField
            // 
            AddressField.AutoSize = true;
            AddressField.DeliveryAddress = null;
            AddressField.Dock = DockStyle.Top;
            AddressField.Location = new Point(0, 161);
            AddressField.Name = "AddressField";
            AddressField.Size = new Size(600, 182);
            AddressField.TabIndex = 7;
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
            Size = new Size(916, 490);
            Load += CustomerTab_Load;
            VisibleChanged += CustomersTab_VisibleChanged;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private CheckBox PriorityCheckBox;
    }
}
