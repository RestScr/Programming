namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            panel6 = new Panel();
            ItemsCartListBox = new ListBox();
            panel5 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            AddToCartButton = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            CartListBox = new ListBox();
            panel9 = new Panel();
            panel13 = new Panel();
            panel16 = new Panel();
            panel15 = new Panel();
            DiscountAmountLabel = new Label();
            label6 = new Label();
            panel14 = new Panel();
            label5 = new Label();
            DiscountCheckedListBox = new CheckedListBox();
            panel11 = new Panel();
            panel19 = new Panel();
            panel18 = new Panel();
            TotalAmountLabel = new Label();
            label7 = new Label();
            panel17 = new Panel();
            panel12 = new Panel();
            panel22 = new Panel();
            panel21 = new Panel();
            label4 = new Label();
            ClearCartButton = new Button();
            AmountLabel = new Label();
            RemoveItemButton = new Button();
            panel20 = new Panel();
            CreateOrderButton = new Button();
            panel8 = new Panel();
            CustomerComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel11.SuspendLayout();
            panel18.SuspendLayout();
            panel12.SuspendLayout();
            panel21.SuspendLayout();
            panel20.SuspendLayout();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 572);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(ItemsCartListBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 473);
            panel6.TabIndex = 2;
            // 
            // ItemsCartListBox
            // 
            ItemsCartListBox.Dock = DockStyle.Fill;
            ItemsCartListBox.FormattingEnabled = true;
            ItemsCartListBox.Location = new Point(0, 0);
            ItemsCartListBox.Name = "ItemsCartListBox";
            ItemsCartListBox.Size = new Size(250, 473);
            ItemsCartListBox.TabIndex = 0;
            ItemsCartListBox.SelectedIndexChanged += ItemsCartListBox_SelectedIndexChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 33);
            panel5.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel4
            // 
            panel4.Controls.Add(AddToCartButton);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 506);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 66);
            panel4.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(3, 6);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(132, 57);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 572);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(panel7);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(277, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(497, 572);
            panel3.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(CartListBox);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 123);
            panel10.Name = "panel10";
            panel10.Size = new Size(497, 121);
            panel10.TabIndex = 3;
            // 
            // CartListBox
            // 
            CartListBox.Dock = DockStyle.Fill;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(0, 0);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(497, 121);
            CartListBox.TabIndex = 0;
            CartListBox.SelectedIndexChanged += CartListBox_SelectedIndexChanged;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(panel11);
            panel9.Controls.Add(panel12);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 244);
            panel9.Name = "panel9";
            panel9.Size = new Size(497, 328);
            panel9.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel16);
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel14);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 113);
            panel13.Name = "panel13";
            panel13.Size = new Size(497, 132);
            panel13.TabIndex = 8;
            // 
            // panel16
            // 
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(325, 0);
            panel16.Name = "panel16";
            panel16.Size = new Size(19, 132);
            panel16.TabIndex = 2;
            // 
            // panel15
            // 
            panel15.Controls.Add(DiscountAmountLabel);
            panel15.Controls.Add(label6);
            panel15.Dock = DockStyle.Right;
            panel15.Location = new Point(344, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(153, 132);
            panel15.TabIndex = 1;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DiscountAmountLabel.Location = new Point(73, 27);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(23, 31);
            DiscountAmountLabel.TabIndex = 5;
            DiscountAmountLabel.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(7, 4);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 0;
            label6.Text = "Discount Amount:";
            // 
            // panel14
            // 
            panel14.Controls.Add(label5);
            panel14.Controls.Add(DiscountCheckedListBox);
            panel14.Dock = DockStyle.Left;
            panel14.Location = new Point(0, 0);
            panel14.Name = "panel14";
            panel14.Size = new Size(325, 132);
            panel14.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(0, 3);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 1;
            label5.Text = "Discounts:";
            // 
            // DiscountCheckedListBox
            // 
            DiscountCheckedListBox.BackColor = SystemColors.Menu;
            DiscountCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountCheckedListBox.FormattingEnabled = true;
            DiscountCheckedListBox.Location = new Point(3, 22);
            DiscountCheckedListBox.Name = "DiscountCheckedListBox";
            DiscountCheckedListBox.Size = new Size(316, 110);
            DiscountCheckedListBox.TabIndex = 0;
            DiscountCheckedListBox.SelectedIndexChanged += DiscountCheckedListBox_SelectedIndexChanged;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel19);
            panel11.Controls.Add(panel18);
            panel11.Controls.Add(panel17);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(0, 245);
            panel11.Name = "panel11";
            panel11.Size = new Size(497, 83);
            panel11.TabIndex = 7;
            // 
            // panel19
            // 
            panel19.Dock = DockStyle.Fill;
            panel19.Location = new Point(325, 0);
            panel19.Name = "panel19";
            panel19.Size = new Size(19, 83);
            panel19.TabIndex = 9;
            // 
            // panel18
            // 
            panel18.Controls.Add(TotalAmountLabel);
            panel18.Controls.Add(label7);
            panel18.Dock = DockStyle.Right;
            panel18.Location = new Point(344, 0);
            panel18.Name = "panel18";
            panel18.Size = new Size(153, 83);
            panel18.TabIndex = 8;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalAmountLabel.Location = new Point(73, 37);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(23, 31);
            TotalAmountLabel.TabIndex = 6;
            TotalAmountLabel.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(87, 17);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 0;
            label7.Text = "TOTAL:";
            // 
            // panel17
            // 
            panel17.Dock = DockStyle.Left;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Size = new Size(325, 83);
            panel17.TabIndex = 7;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel22);
            panel12.Controls.Add(panel21);
            panel12.Controls.Add(panel20);
            panel12.Dock = DockStyle.Top;
            panel12.Location = new Point(0, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(497, 113);
            panel12.TabIndex = 6;
            // 
            // panel22
            // 
            panel22.Dock = DockStyle.Fill;
            panel22.Location = new Point(197, 0);
            panel22.Name = "panel22";
            panel22.Size = new Size(20, 113);
            panel22.TabIndex = 2;
            // 
            // panel21
            // 
            panel21.Controls.Add(label4);
            panel21.Controls.Add(ClearCartButton);
            panel21.Controls.Add(AmountLabel);
            panel21.Controls.Add(RemoveItemButton);
            panel21.Dock = DockStyle.Right;
            panel21.Location = new Point(217, 0);
            panel21.Name = "panel21";
            panel21.Size = new Size(280, 113);
            panel21.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(199, 8);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 1;
            label4.Text = "Amount:";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(142, 61);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(128, 46);
            ClearCartButton.TabIndex = 4;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(200, 28);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(23, 31);
            AmountLabel.TabIndex = 2;
            AmountLabel.Text = "-";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(10, 61);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(117, 45);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // panel20
            // 
            panel20.Controls.Add(CreateOrderButton);
            panel20.Dock = DockStyle.Left;
            panel20.Location = new Point(0, 0);
            panel20.Name = "panel20";
            panel20.Size = new Size(197, 113);
            panel20.TabIndex = 0;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(6, 59);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(121, 48);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(CustomerComboBox);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 35);
            panel8.Name = "panel8";
            panel8.Size = new Size(497, 88);
            panel8.TabIndex = 1;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(94, 3);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(394, 28);
            CustomerComboBox.TabIndex = 2;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 65);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "Cart:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(0, 6);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "Customer:";
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(497, 35);
            panel7.TabIndex = 0;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(774, 572);
            VisibleChanged += CartsTab_VisibleChanged;
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel11.ResumeLayout(false);
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel12.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            panel20.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private ListBox ItemsCartListBox;
        private Label label1;
        private Button AddToCartButton;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Label label2;
        private Panel panel7;
        private Label label3;
        private ComboBox CustomerComboBox;
        private ListBox CartListBox;
        private Label AmountLabel;
        private Label label4;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Panel panel12;
        private Panel panel11;
        private Button CreateOrderButton;
        private Panel panel13;
        private Label label5;
        private CheckedListBox DiscountCheckedListBox;
        private Panel panel14;
        private Panel panel16;
        private Panel panel15;
        private Label DiscountAmountLabel;
        private Label label6;
        private Label TotalAmountLabel;
        private Label label7;
        private Panel panel19;
        private Panel panel18;
        private Panel panel17;
        private Panel panel22;
        private Panel panel21;
        private Panel panel20;
    }
}
