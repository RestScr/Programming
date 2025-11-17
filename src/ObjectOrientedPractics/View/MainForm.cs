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
            if (TabControl.SelectedIndex == 2)
            {
                CartPanel.RefreshData();
            }
            if (TabControl.SelectedIndex == 3)
            {
                OrdersPanel.UpdateOrders();
            }
            ItemsControlTab.DisableElements();
            CustomersControlTab.DisableElements();
        }
    }
}
