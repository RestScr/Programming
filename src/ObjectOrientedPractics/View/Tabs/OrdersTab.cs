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
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Свойство списка заказов.
        /// </summary>
        private List<Order> Orders { get; set; } = new List<Order>();

        public OrdersTab()
        {
            InitializeComponent();
        }

        public void UpdateOrders()
        {
            Debug.WriteLine("hui");
            foreach (Customer customer in Store.Customers)
            {
                
                foreach (Order order in customer.Orders)
                {
                    OrdersData.Rows.Add(order.Id, order.OrderTime, order.Status, customer.Fullname);
                }
            }
            foreach (string enumeration in Enum.GetNames(typeof(OrderStatus)))
            {
                OrderStatusComboBox.Items.Add(enumeration);
            }
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            UpdateOrders();
        }

        private void OrdersData_SelectionChanged(object sender, EventArgs e)
        {
            int index = OrdersData.SelectedCells[0].RowIndex;
            Order order = Orders[index];
            IdTextBox.Text = Convert.ToString(order.Id);
            CreationDateTextBox.Text = Convert.ToString(order.OrderTime);
            OrderStatusComboBox.SelectedIndex = Convert.ToInt32(order.Status + 1);
            DeliveryAddressControl.FillBoxes(order.OrderAddress);

            OrdersItemsListBox.Items.Clear();
            foreach (Item item in order.Items)
            {
                OrdersItemsListBox.Items.Add(item.Id + " " + item.Name);
            }
            AmountLabel.Text = Convert.ToString(order.Amount);
        }
    }
}
