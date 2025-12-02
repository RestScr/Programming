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
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

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
            OrdersData.Rows.Clear();
            Orders.Clear();
            foreach (Customer customer in Store.Customers)
            {

                foreach (Order order in customer.Orders)
                {
                    Debug.WriteLine(order.Total);
                    Debug.WriteLine(order.Amount);
                    Debug.WriteLine(order.DiscountAmount);
                    OrdersData.Rows.Add(order.Id, order.OrderTime, order.Status, customer.Fullname, order.Total);
                    Orders.Add(order);
                }
            }
            if (DeliveryAddressControl.DeliveryAddress != null)
            {
                DeliveryAddressControl.FillBoxes();
            }
            OrderStatusComboBox.Items.Clear();
            foreach (string enumeration in Enum.GetNames(typeof(OrderStatus)))
            {
                OrderStatusComboBox.Items.Add(enumeration);
            }
        }

        private void OrdersTab_Load(object sender, EventArgs e)
        {
            UpdateOrders();
            DeliveryAddressControl.SetReadOnly(true);
        }

        private void OrdersData_SelectionChanged(object sender, EventArgs e)
        {
            if (Orders.Count == 0 || OrdersData.SelectedCells.Count == 0)
            {
                return;
            }
            int index = OrdersData.SelectedCells[0].RowIndex;
            Order order = Orders[index];

            IdTextBox.Text = Convert.ToString(order.Id);
            CreationDateTextBox.Text = Convert.ToString(order.OrderTime);
            OrderStatusComboBox.SelectedIndex = Convert.ToInt32(order.Status);
            DeliveryAddressControl.FillBoxes(order.OrderAddress);

            OrdersItemsListBox.Items.Clear();
            foreach (Item item in order.Items)
            {
                OrdersItemsListBox.Items.Add(item.Id + " " + item.Name);
            }
            AmountLabel.Text = Convert.ToString(order.Amount);
        }

        private void OrderStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Orders.Count == 0 || OrdersData.SelectedCells.Count == 0)
            {
                return;
            }
            int index = OrdersData.SelectedCells[0].RowIndex;
            Order order = Orders[index];
            order.Status = (OrderStatus)(OrderStatusComboBox.SelectedIndex);
            OrdersData.Rows[index].Cells["OrderStatus"].Value = order.Status;
        }
    }
}
