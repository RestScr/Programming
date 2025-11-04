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
            components = new System.ComponentModel.Container();
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
            panel12 = new Panel();
            RemoveItemButton = new Button();
            ClearCartButton = new Button();
            label4 = new Label();
            label5 = new Label();
            panel11 = new Panel();
            CreateOrderButton = new Button();
            panel8 = new Panel();
            CustomerComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            panel7 = new Panel();
            storeBindingSource = new BindingSource(components);
            itemsBindingSource = new BindingSource(components);
            customersBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
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
            panel1.Size = new Size(250, 461);
            panel1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(ItemsCartListBox);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 33);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 362);
            panel6.TabIndex = 2;
            // 
            // ItemsCartListBox
            // 
            ItemsCartListBox.DataSource = itemsBindingSource;
            ItemsCartListBox.Dock = DockStyle.Fill;
            ItemsCartListBox.FormattingEnabled = true;
            ItemsCartListBox.Location = new Point(0, 0);
            ItemsCartListBox.Name = "ItemsCartListBox";
            ItemsCartListBox.Size = new Size(250, 362);
            ItemsCartListBox.TabIndex = 0;
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
            panel4.Location = new Point(0, 395);
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
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(27, 461);
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
            panel3.Size = new Size(494, 461);
            panel3.TabIndex = 2;
            // 
            // panel10
            // 
            panel10.Controls.Add(CartListBox);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(0, 105);
            panel10.Name = "panel10";
            panel10.Size = new Size(494, 177);
            panel10.TabIndex = 3;
            // 
            // CartListBox
            // 
            CartListBox.Dock = DockStyle.Fill;
            CartListBox.FormattingEnabled = true;
            CartListBox.Location = new Point(0, 0);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(494, 177);
            CartListBox.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel12);
            panel9.Controls.Add(panel11);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 282);
            panel9.Name = "panel9";
            panel9.Size = new Size(494, 179);
            panel9.TabIndex = 2;
            // 
            // panel12
            // 
            panel12.Controls.Add(RemoveItemButton);
            panel12.Controls.Add(ClearCartButton);
            panel12.Controls.Add(label4);
            panel12.Controls.Add(label5);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(244, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(250, 179);
            panel12.TabIndex = 6;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Location = new Point(3, 68);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(117, 45);
            RemoveItemButton.TabIndex = 3;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(118, 68);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(128, 46);
            ClearCartButton.TabIndex = 4;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(175, 11);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 1;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(175, 31);
            label5.Name = "label5";
            label5.Size = new Size(72, 31);
            label5.TabIndex = 2;
            label5.Text = "14,88";
            // 
            // panel11
            // 
            panel11.Controls.Add(CreateOrderButton);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(160, 179);
            panel11.TabIndex = 5;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(6, 68);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(121, 48);
            CreateOrderButton.TabIndex = 0;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(CustomerComboBox);
            panel8.Controls.Add(label3);
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 35);
            panel8.Name = "panel8";
            panel8.Size = new Size(494, 70);
            panel8.TabIndex = 1;
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.DataSource = customersBindingSource;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(94, 3);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(394, 28);
            CustomerComboBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 37);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "Cart:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 6);
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
            panel7.Size = new Size(494, 35);
            panel7.TabIndex = 0;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Model.Store);
            // 
            // itemsBindingSource
            // 
            itemsBindingSource.DataMember = "Items";
            itemsBindingSource.DataSource = storeBindingSource;
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataMember = "Customers";
            customersBindingSource.DataSource = storeBindingSource;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CartsTab";
            Size = new Size(771, 461);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
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
        private Button CreateOrderButton;
        private Label label5;
        private Label label4;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private Panel panel12;
        private Panel panel11;
        private BindingSource itemsBindingSource;
        private BindingSource storeBindingSource;
        private BindingSource customersBindingSource;
    }
}
