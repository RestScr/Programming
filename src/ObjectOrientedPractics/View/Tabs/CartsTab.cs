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
    public partial class CartsTab : UserControl
    {
        private Item _selectedItem = null;
        private Customer _selectedCustomer = null;

        /// <summary>
        /// Свойство выбранного товара.
        /// </summary>
        private Item SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
            }
        }

        /// <summary>
        /// Свойство выбранного покупателя.
        /// </summary>
        private Customer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                _selectedCustomer = value;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void FillCart()
        {

        }

        private void ItemsCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = Store.Items[ItemsCartListBox.SelectedIndex];
        }

        private void CartsTab_VisibleChanged(object sender, EventArgs e)
        {
            if (SelectedCustomer != null)
            {
                CustomerComboBox.Text = SelectedCustomer.Id + " " + SelectedCustomer.Fullname;
            }
            ItemsCartListBox.Items.Clear();
            foreach (Item item in Store.Items)
            {

                if (!ItemsCartListBox.Items.Contains(item.Id + " " + item.Name))
                {
                    ItemsCartListBox.Items.Add(item.Id + " " + item.Name);
                }
            }
            CustomerComboBox.Items.Clear();
            foreach (Customer customer in Store.Customers)
            {
                if (!CustomerComboBox.Items.Contains(customer.Id + " " + customer.Fullname))
                {
                    CustomerComboBox.Items.Add(customer.Id + " " + customer.Fullname);
                }
            }
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedCustomer = Store.Customers[CustomerComboBox.SelectedIndex];
            FillCart();
        }
    }
}
