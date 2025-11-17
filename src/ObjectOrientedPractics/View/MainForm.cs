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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (TabControl.TabIndex == 2)
            {
                CartPanel.RefreshData();
            }
            if (TabControl.TabIndex == 3)
            {
                OrdersPanel.UpdateOrders();
            }
        }
    }
}
