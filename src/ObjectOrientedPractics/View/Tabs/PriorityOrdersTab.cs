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
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder SelectedOrder { get; set; } = new PriorityOrder();

        public PriorityOrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполнить поля данными из поля приоритетного заказа.
        /// </summary>
        public void FillData()
        {
            IDTextBox.Text = Convert.ToString(SelectedOrder.Id);
            CreationTextBox.Text = Convert.ToString(SelectedOrder.OrderTime);
            DeliveryAddress.FillBoxes(SelectedOrder.OrderAddress);
            foreach (Item item in SelectedOrder.Items)
            {
                ItemsListBox.Items.Add(item.Id + " " + item.Name);
            }
            CostLabel.Text = Convert.ToString(SelectedOrder.Amount);
        }

        /// <summary>
        /// Заполнить поля по данному объекта приоритетного заказа.
        /// </summary>
        /// <param name="order"> Объект приоритетного заказа. </param>
        public void FillData(PriorityOrder order)
        {
            IDTextBox.Text = Convert.ToString(order.Id);
            CreationTextBox.Text = Convert.ToString(order.OrderTime);
            DeliveryAddress.FillBoxes(order.OrderAddress);
            foreach (Item item in order.Items)
            {
                ItemsListBox.Items.Add(item.Id + " " + item.Name);
            }
            CostLabel.Text = Convert.ToString(order.Amount);

        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedOrder.Status = (OrderStatus)(StatusComboBox.SelectedIndex);
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            SelectedOrder.Items.Add(Store.Items[(new Random()).Next(Store.Items.Count - 1)]);
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            SelectedOrder.Items.RemoveAt(selectedIndex);
            ItemsListBox.Items.RemoveAt(selectedIndex);
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            SelectedOrder = new PriorityOrder();
            FillData(SelectedOrder);
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {
            DeliveryAddress.Enable(false);
        }
    }
}
