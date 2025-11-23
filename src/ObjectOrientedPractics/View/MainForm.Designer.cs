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
            TabControl = new TabControl();
            ItemsTab = new TabPage();
            ItemsControlTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomersTab = new TabPage();
            CustomersControlTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            CartsTab = new TabPage();
            CartPanel = new ObjectOrientedPractics.View.Tabs.CartsTab();
            OrdersTab = new TabPage();
            OrdersPanel = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            TabControl.SuspendLayout();
            ItemsTab.SuspendLayout();
            CustomersTab.SuspendLayout();
            CartsTab.SuspendLayout();
            OrdersTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTab);
            TabControl.Controls.Add(CustomersTab);
            TabControl.Controls.Add(CartsTab);
            TabControl.Controls.Add(OrdersTab);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1169, 708);
            TabControl.TabIndex = 0;
            TabControl.Selected += TabControl_Selected;
            // 
            // ItemsTab
            // 
            ItemsTab.Controls.Add(ItemsControlTab);
            ItemsTab.Location = new Point(4, 29);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new Padding(3);
            ItemsTab.Size = new Size(1073, 675);
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
            ItemsControlTab.Size = new Size(1067, 669);
            ItemsControlTab.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(CustomersControlTab);
            CustomersTab.Location = new Point(4, 29);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(1073, 675);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Customers";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // CustomersControlTab
            // 
            CustomersControlTab.Dock = DockStyle.Fill;
            CustomersControlTab.Location = new Point(3, 3);
            CustomersControlTab.Name = "CustomersControlTab";
            CustomersControlTab.Size = new Size(1067, 669);
            CustomersControlTab.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(CartPanel);
            CartsTab.Location = new Point(4, 29);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(1073, 675);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // CartPanel
            // 
            CartPanel.Dock = DockStyle.Fill;
            CartPanel.Location = new Point(0, 0);
            CartPanel.Name = "CartPanel";
            CartPanel.Size = new Size(1073, 675);
            CartPanel.TabIndex = 0;
            // 
            // OrdersTab
            // 
            OrdersTab.Controls.Add(OrdersPanel);
            OrdersTab.Location = new Point(4, 29);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(1161, 675);
            OrdersTab.TabIndex = 3;
            OrdersTab.Text = "Orders";
            OrdersTab.UseVisualStyleBackColor = true;
            // 
            // OrdersPanel
            // 
            OrdersPanel.Dock = DockStyle.Fill;
            OrdersPanel.Location = new Point(0, 0);
            OrdersPanel.Name = "OrdersPanel";
            OrdersPanel.Size = new Size(1161, 675);
            OrdersPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 708);
            Controls.Add(TabControl);
            Name = "MainForm";
            Text = "Project Oriented Practics";
            TabControl.ResumeLayout(false);
            ItemsTab.ResumeLayout(false);
            ItemsTab.PerformLayout();
            CustomersTab.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            OrdersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTab;
        private TabPage CustomersTab;
        private View.Tabs.ItemsTab ItemsControlTab;
        private View.Tabs.CustomersTab CustomersControlTab;
        private TabPage CartsTab;
        private View.Tabs.CartsTab CartPanel;
        private TabPage OrdersTab;
        private View.Tabs.OrdersTab OrdersPanel;
    }
}
