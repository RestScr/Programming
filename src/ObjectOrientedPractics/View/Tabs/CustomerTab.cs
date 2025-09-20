using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        private List<Customer> _customers { get; } = new();

        private Customer _selectedCustomer { get; set; } = null;

        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для включения/отключения элементов интерфейса в зависимости от выбранного пользователя в листбоксе.
        /// </summary>
        private void DisableElements()
        {
            if (_selectedCustomer == null)
            {
                CustomerIDBox.Enabled = false;
                CustomerFullnameBox.Enabled = false;
                AddressRichText.Enabled = false;
            }
            else
            {
                CustomerIDBox.Enabled = true;
                CustomerFullnameBox.Enabled = true;
                AddressRichText.Enabled = true;
            }
        }

        private void AddCustomer(Custom)
        {

        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
