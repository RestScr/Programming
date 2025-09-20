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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс вкладки с покупателями.
    /// </summary>
    public partial class CustomerTab : UserControl
    {
        private List<Customer> _customers { get; } = new();

        private Customer _selectedCustomer { get; set; } = null;

        /// <summary>
        /// Конструктор вкладки с покупателями.
        /// </summary>
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
                CustomerFullnameBox.Enabled = false;
                AddressRichText.Enabled = false;
            }
            else
            {
                CustomerFullnameBox.Enabled = true;
                AddressRichText.Enabled = true;
            }
        }

        /// <summary>
        /// Метод правильного добавления покупателей в список.
        /// </summary>
        /// <param name="customer"> Покупатель для добавления. </param>
        private void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
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
            _customers.RemoveAt(selectedIndex);
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
            AddressRichText.Text = _selectedCustomer.Address;
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
                AddressRichText.Text = "";
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
            _selectedCustomer = _customers[selectedIndex];
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

        private void AddressRichText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_selectedCustomer == null)
                {
                    return;
                }
                _selectedCustomer.Address = AddressRichText.Text;
            }
            catch (ArgumentException)
            {
                AddressRichText.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик ввода имени покупателя при выходе из окошка ввода.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void CustomerFullnameBox_Leave(object sender, EventArgs e)
        {
            CustomersList.Items[_customers.IndexOf(_selectedCustomer)] = _selectedCustomer.Id + " " + _selectedCustomer.Fullname;
        }
    }
}
