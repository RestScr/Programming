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
    /// Класс личного пользовательского интерфейса.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private Item _selectedItem { get; set; } = null;

        private List<Item> _items { get; } = new();

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция добавления товара.
        /// </summary>
        /// <param name="item"> Товар. </param>
        private void AddItem(Item item)
        {
            _items.Add(item);
            ItemsList.Items.Add(Convert.ToString(item.Id) + " " + item.Name);
        }

        /// <summary>
        /// Функция удаления товара.
        /// </summary>
        /// <param name="item"> Товар в списке для удаления. </param>
        private void RemoveItem(Item item)
        {
            _items.Remove(item);
            int selectedIndex = ItemsList.SelectedIndex - 1;
            ItemsList.Items.Remove(Convert.ToString(item.Id) + " " + item.Name);
            if (ItemsList.Items.Count > 0 && selectedIndex >= 0)
            {
                ItemsList.SelectedIndex = selectedIndex;
                _selectedItem = _items[selectedIndex];
            }
            else
            {
                _selectedItem = null;
            }
        }

        /// <summary>
        /// Функция очистки полей.
        /// </summary>
        private void ClearBoxes()
        {
            IDBox.Text = "";
            CostBox.Text = "";
            NameRichText.Text = "";
            DescriptionRichText.Text = "";
        }

        /// <summary>
        /// Логика кнопки добавления товаров.
        /// </summary>
        /// <param name="sender"> Отправитель события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItem(ItemFactory.GenerateItem());
        }

        /// <summary>
        /// Логика кнопки удаления товаров.
        /// </summary>
        /// <param name="sender"> Отправитель события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            RemoveItem(_selectedItem);
        }

        /// <summary>
        /// Логика выбора товара из списка.
        /// </summary>
        /// <param name="sender"> Отправитель события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void ItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsList.SelectedIndex;
            if (selectedIndex < 0)
            {
                return;
            }
            _selectedItem = _items[selectedIndex];
            IDBox.Text = Convert.ToString(_selectedItem.Id);
            CostBox.Text = Convert.ToString(_selectedItem.Cost);
            NameRichText.Text = _selectedItem.Name;
            DescriptionRichText.Text = _selectedItem.Info;
        }

        /// <summary>
        /// Обработчик ввода цены товара.
        /// </summary>
        /// <param name="sender"> Объект вызывателя события </param>
        /// <param name="e"> Аргументы события. </param>
        private void CostBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostBox.BackColor = Color.White;
                double enteredValue = Convert.ToDouble(CostBox.Text);
                ValueValidator.AssertValueInRange(enteredValue, 0, 100000, "Cost");
                _selectedItem.Cost = enteredValue;
            }
            catch (FormatException)
            {
                CostBox.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                CostBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик ввода названия товара. 
        /// </summary>
        /// <param name="sender"> Объект вызывателя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void NameRichText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameRichText.BackColor = Color.White;
                _selectedItem.Name = NameRichText.Text;
            }
            catch (ArgumentException)
            {
                NameRichText.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обработчик ввода описания товара.
        /// </summary>
        /// <param name="sender"> Объект вызываетля события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void DescriptionRichText_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DescriptionRichText.BackColor = Color.White;
                _selectedItem.Info = DescriptionRichText.Text;
            }
            catch (ArgumentException)
            {
                DescriptionRichText.BackColor = Color.LightPink;
            }
        }
    }
}
