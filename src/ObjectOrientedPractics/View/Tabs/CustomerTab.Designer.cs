namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
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
            AddCustomerButton = new Button();
            RemoveCustomerButton = new Button();
            CustomersList = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            AddressRichText = new RichTextBox();
            CustomerFullnameBox = new TextBox();
            CustomerIDBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(AddCustomerButton);
            panel1.Controls.Add(RemoveCustomerButton);
            panel1.Controls.Add(CustomersList);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 483);
            panel1.TabIndex = 0;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Location = new Point(3, 413);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(102, 67);
            AddCustomerButton.TabIndex = 3;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Location = new Point(111, 413);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(94, 67);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            // 
            // CustomersList
            // 
            CustomersList.FormattingEnabled = true;
            CustomersList.Location = new Point(3, 23);
            CustomersList.Name = "CustomersList";
            CustomersList.Size = new Size(307, 384);
            CustomersList.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddressRichText);
            panel2.Controls.Add(CustomerFullnameBox);
            panel2.Controls.Add(CustomerIDBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(322, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(540, 242);
            panel2.TabIndex = 1;
            // 
            // AddressRichText
            // 
            AddressRichText.Location = new Point(91, 122);
            AddressRichText.Name = "AddressRichText";
            AddressRichText.Size = new Size(446, 117);
            AddressRichText.TabIndex = 7;
            AddressRichText.Text = "";
            // 
            // CustomerFullnameBox
            // 
            CustomerFullnameBox.Location = new Point(91, 81);
            CustomerFullnameBox.Name = "CustomerFullnameBox";
            CustomerFullnameBox.Size = new Size(446, 27);
            CustomerFullnameBox.TabIndex = 6;
            // 
            // CustomerIDBox
            // 
            CustomerIDBox.Enabled = false;
            CustomerIDBox.Location = new Point(91, 42);
            CustomerIDBox.Name = "CustomerIDBox";
            CustomerIDBox.Size = new Size(125, 27);
            CustomerIDBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 122);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 84);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 3;
            label4.Text = "Full Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 45);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 1;
            label2.Text = "Selected Customer";
            // 
            // panel3
            // 
            panel3.Location = new Point(322, 251);
            panel3.Name = "panel3";
            panel3.Size = new Size(540, 235);
            panel3.TabIndex = 2;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CustomerTab";
            Size = new Size(865, 489);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label label2;
        private ListBox CustomersList;
        private Button AddCustomerButton;
        private Button RemoveCustomerButton;
        private TextBox CustomerIDBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private RichTextBox AddressRichText;
        private TextBox CustomerFullnameBox;
    }
}
