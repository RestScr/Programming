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
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.View.Windows;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс вкладки с покупателями.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private Customer _selectedCustomer { get; set; } = null;
        private IDiscount SelectedDiscount { get; set; } = null;

        /// <summary>
        /// Конструктор вкладки с покупателями.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для включения/отключения элементов интерфейса в зависимости от выбранного пользователя в листбоксе.
        /// </summary>
        public void DisableElements()
        {
            if (CustomersList.SelectedIndex < 0)
            {
                _selectedCustomer = null;
            }
            if (_selectedCustomer == null)
            {
                CustomerFullnameBox.Enabled = false;
                AddressField.Enable(false);
                PriorityCheckBox.Enabled = false;
            }
            else
            {
                CustomerFullnameBox.Enabled = true;
                AddressField.Enable(true);
                PriorityCheckBox.Enabled = true;
            }
        }

        /// <summary>
        /// Метод правильного добавления покупателей в список.
        /// </summary>
        /// <param name="customer"> Покупатель для добавления. </param>
        private void AddCustomer(Customer customer)
        {
            Store.Customers.Add(customer);
            CustomersList.Items.Add(Convert.ToString(customer.Id) + " " + customer.Fullname);
        }

        /// <summary>
        /// Метод правильного удаления покупателя из списка.
        /// </summary>
        private void RemoveSelectedCustomer()
        {
            int selectedIndex = CustomersList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            Store.Customers.RemoveAt(selectedIndex);
            CustomersList.Items.RemoveAt(selectedIndex--);
            if (selectedIndex >= 0)
            {
                CustomersList.SelectedIndex = selectedIndex;
            }
            else
            {
                _selectedCustomer = null;
                ClearBoxes();
            }
        }

        /// <summary>
        /// Метод для заполнения всех текстовых полей данными выбранного покупателя.
        /// </summary>
        private void FillBoxes()
        {
            if (_selectedCustomer == null)
            {
                return;
            }

            CustomerIDBox.Text = Convert.ToString(_selectedCustomer.Id);
            CustomerFullnameBox.Text = _selectedCustomer.Fullname;
            AddressField.DeliveryAddress = _selectedCustomer.Address;
            AddressField.FillBoxes();
            PriorityCheckBox.Checked = _selectedCustomer.IsPriority;
        }

        /// <summary>
        /// Функция очистки полей.
        /// </summary>
        private void ClearBoxes()
        {
            if (_selectedCustomer == null)
            {
                CustomerIDBox.Text = "";
                CustomerFullnameBox.Text = "";
                AddressField.ClearBoxes();
            }
        }

        /// <summary>
        /// Логика добавления покупателей в список.
        /// </summary>
        /// <param name="sender"> Объект отправителя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer(CustomerFactory.GenerateCustomer());
        }

        /// <summary>
        /// Логика удаления покупателей.
        /// </summary>
        /// <param name="sender"> Объект отправителя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedCustomer();
        }

        /// <summary>
        /// Загрузка вкладки с покупателями.
        /// </summary>
        /// <param name="sender"> Отправитель события. </param>
        /// <param name="e"> Аругменты события. </param>
        private void CustomerTab_Load(object sender, EventArgs e)
        {
            DisableElements();
        }

        /// <summary>
        /// Обработчик выбора покупателя в списке.s
        /// </summary>
        /// <param name="sender"> Объект отправителя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void CustomersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            // Заполняем поле адреса прошлого выбранного покупателя
            if (_selectedCustomer != null)
            {
                _selectedCustomer.Address = AddressField.DeliveryAddress;
            }
            _selectedCustomer = Store.Customers[selectedIndex];
            FillDiscountsListBox(_selectedCustomer);
            FillBoxes();
            DisableElements();
        }

        private void CustomerFullnameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedCustomer == null)
                {
                    return;
                }
                CustomerFullnameBox.BackColor = Color.White;
                _selectedCustomer.Fullname = CustomerFullnameBox.Text;
            }
            catch (ArgumentException)
            {
                CustomerFullnameBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик ввода имени покупателя при выходе из окошка ввода.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void CustomerFullnameBox_Leave(object sender, EventArgs e)
        {
            CustomersList.Items[Store.Customers.IndexOf(_selectedCustomer)] = _selectedCustomer.Id + " " + _selectedCustomer.Fullname;
        }

        private void CustomersTab_VisibleChanged(object sender, EventArgs e)
        {
            CustomersList.Items.Clear();
            foreach (Customer customer in Store.Customers)
            {
                if (!CustomersList.Items.Contains(customer.Id + " " + customer.Fullname))
                {
                    CustomersList.Items.Add(customer.Id + " " + customer.Fullname);
                }
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }
            _selectedCustomer.IsPriority = PriorityCheckBox.Checked;
        }

        /// <summary>
        /// Закрытый вспомогательный метод заполнения списка скидок скидками из мписка покупателя.
        /// </summary>
        /// <param name="customer"> Объект покупателя. </param>
        private void FillDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();
            foreach (IDiscount discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        private void DiscountsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }

            int index = DiscountsListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            SelectedDiscount = _selectedCustomer.Discounts[index];
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }

            DiscountAdder modalWindow = new DiscountAdder();
            DialogResult result = modalWindow.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                _selectedCustomer.Discounts.Add(new PercentDiscount(modalWindow.ReturnCategory()));
                FillDiscountsListBox(_selectedCustomer);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer == null)
            {
                return;
            }

            int selectedIndex = DiscountsListBox.SelectedIndex;
            if (_selectedCustomer.Discounts[selectedIndex].GetType() == typeof(PointsDiscount))
            {
                return;
            }

            _selectedCustomer.Discounts.RemoveAt(selectedIndex);
            DiscountsListBox.Items.RemoveAt(selectedIndex);
            SelectedDiscount = null;
        }
    }
}
