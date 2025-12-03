using System.Diagnostics;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            ItemsControlTab.ItemsChanged += CartPanel.RefreshData;
            ItemsControlTab.ItemsChanged += OrdersPanel.RefreshData;
            CustomersControlTab.CustomersChanged += CartPanel.RefreshData;
            CustomersControlTab.CustomersChanged += OrdersPanel.RefreshData;
            CartPanel.OrderCreated += OrdersPanel.RefreshData;

            ItemsControlTab.DisableElements();
            CustomersControlTab.DisableElements();
        }
    }
}
