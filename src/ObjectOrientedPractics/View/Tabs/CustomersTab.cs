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
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс вкладки с покупателями.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        private Customer _selectedCustomer { get; set; } = null;

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
        private void DisableElements()
        {
            if (_selectedCustomer == null)
            {
                CustomerFullnameBox.Enabled = false;
                AddressField.Enable(false);
            }
            else
            {
                CustomerFullnameBox.Enabled = true;
                AddressField.Enable(true);
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
            foreach (Customer customer in Store.Customers)
            {
                CustomersList.Items.Add(customer.Fullname);
            }
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
    }
}
