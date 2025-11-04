namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            ItemsTab = new TabPage();
            ItemsControlTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersTab = new TabPage();
            CustomersControlTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            CartsTab = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Tabs.CartsTab();
            tabControl1.SuspendLayout();
            ItemsTab.SuspendLayout();
            CustomersTab.SuspendLayout();
            CartsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTab);
            tabControl1.Controls.Add(CustomersTab);
            tabControl1.Controls.Add(CartsTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(934, 481);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTab
            // 
            ItemsTab.Controls.Add(ItemsControlTab);
            ItemsTab.Location = new Point(4, 29);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new Padding(3);
            ItemsTab.Size = new Size(926, 448);
            ItemsTab.TabIndex = 0;
            ItemsTab.Text = "Items";
            ItemsTab.UseVisualStyleBackColor = true;
            // 
            // ItemsControlTab
            // 
            ItemsControlTab.AutoSize = true;
            ItemsControlTab.Dock = DockStyle.Fill;
            ItemsControlTab.Location = new Point(3, 3);
            ItemsControlTab.Name = "ItemsControlTab";
            ItemsControlTab.Size = new Size(920, 442);
            ItemsControlTab.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(CustomersControlTab);
            CustomersTab.Location = new Point(4, 29);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(926, 448);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // CustomersControlTab
            // 
            CustomersControlTab.Dock = DockStyle.Fill;
            CustomersControlTab.Location = new Point(3, 3);
            CustomersControlTab.Name = "CustomersControlTab";
            CustomersControlTab.Size = new Size(920, 442);
            CustomersControlTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(cartsTab1);
            CartsTab.Location = new Point(4, 29);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(926, 448);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(926, 448);
            cartsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 481);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Project Oriented Practics";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            ItemsTab.ResumeLayout(false);
            ItemsTab.PerformLayout();
            CustomersTab.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTab;
        private TabPage CustomersTab;
        private View.Tabs.ItemsTab ItemsControlTab;
        private View.Tabs.CustomersTab CustomersControlTab;
        private TabPage CartsTab;
        private View.Tabs.CartsTab cartsTab1;
    }
}
