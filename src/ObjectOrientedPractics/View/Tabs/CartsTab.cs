using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        /// <summary>
        /// Поле выбранного предмета в списке.
        /// </summary>
        private Item _selectedItem = null;

        /// <summary>
        /// Поле выбранного покупателя в списке покупателей.
        /// </summary>
        private Customer _selectedCustomer = null;

        /// <summary>
        /// Поле выбранного предмета в корзине покупателя.
        /// </summary>
        private Item _selectedCartItem = null;

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

        /// <summary>
        /// Свойство выбранного товара в корзине покупателя.
        /// </summary>
        private Item SelectedCartItem
        {
            get
            {
                return _selectedCartItem;
            }
            set
            {
                _selectedCartItem = value;
            }
        }

        /// <summary>
        /// Конструктор вкладки с товарами и покупателями.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Частная функция заполнения списка товаров корзины выбранного покупателя.
        /// </summary>
        private void FillCart()
        {
            CartListBox.Items.Clear();
            if (SelectedCustomer == null)
            {
                AmountLabel.Text = "-";
                return;
            }
            foreach (Item item in SelectedCustomer.CustomerCart.Items)
            {
                CartListBox.Items.Add(item.Id + " " + item.Name);
            }
            AmountLabel.Text = Convert.ToString(SelectedCustomer.CustomerCart.Amount);
        }

        private void ItemsCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = Store.Items[ItemsCartListBox.SelectedIndex];
        }

        /// <summary>
        /// Частная функция очистки корзины выбранного покупателя.
        /// </summary>
        private void ClearCart()
        {
            CartListBox.Items.Clear();
            if (SelectedCustomer == null)
            {
                return;
            }
            SelectedCustomer.CustomerCart.Items.Clear();
            FillCart();
        }

        public void RefreshData()
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
            if (!CustomerComboBox.Items.Contains(CustomerComboBox.Text))
            {
                SelectedCustomer = null;
                CustomerComboBox.Text = "";
            }
        }

        private void CartsTab_VisibleChanged(object sender, EventArgs e)
        {
            RefreshData();
            FillCart();
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex < 0)
            {
                return;
            }
            _selectedCustomer = Store.Customers[CustomerComboBox.SelectedIndex];
            FillCart();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (SelectedItem == null || SelectedCustomer == null)
            {
                return;
            }
            SelectedCustomer.CustomerCart.Items.Add(SelectedItem);
            FillCart();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int previousIndex = CartListBox.SelectedIndex;
            if (SelectedCartItem == null)
            {
                return;
            }
            SelectedCustomer.CustomerCart.Items.Remove(SelectedCartItem);
            if (CartListBox.Items.Count > 0)
            {
                CartListBox.SelectedIndex = previousIndex;
            }
            else
            {
                SelectedCartItem = null;
            }
            FillCart();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            ClearCart();
        }

        private void CartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedCustomer == null)
            {
                return;
            }

            SelectedCartItem = SelectedCustomer.CustomerCart.Items[CartListBox.SelectedIndex];
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (SelectedCustomer == null)
            {
                return;
            }
            SelectedCustomer.Orders.Add(new Order(SelectedCustomer.Address, SelectedCustomer.CustomerCart));
            ClearCart();
            MessageBox.Show("Заказ успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
