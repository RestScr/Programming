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
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс личного пользовательского интерфейса.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private Item _selectedItem { get; set; } = null;

        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция включения/отключения элементов в зависимости от выбранного элемента.
        /// </summary>
        public void DisableElements()
        {
            if (ItemsList.SelectedIndex < 0 || !ItemsList.GetSelected(ItemsList.SelectedIndex))
            {
                _selectedItem = null;
            }
            if (_selectedItem == null)
            {
                CostBox.Enabled = false;
                NameRichText.Enabled = false;
                DescriptionRichText.Enabled = false;
                CategoryComboBox.Enabled = false;
                ClearBoxes();
            }
            else
            {
                CostBox.Enabled = true;
                NameRichText.Enabled = true;
                DescriptionRichText.Enabled = true;
                CategoryComboBox.Enabled = true;
            }
        }

        /// <summary>
        /// Функция добавления товара.
        /// </summary>
        /// <param name="item"> Товар. </param>
        private void AddItem(Item item)
        {
            Store.Items.Add(item);
            ItemsList.Items.Add(Convert.ToString(item.Id) + " " + item.Name);
            SortByOption();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Функция удаления товара.
        /// </summary>
        /// <param name="item"> Товар в списке для удаления. </param>
        private void RemoveItem(Item item)
        {
            Store.Items.Remove(item);
            int selectedIndex = ItemsList.SelectedIndex - 1;
            if (item == null)
            {
                return;
            }
            ItemsList.Items.Remove(Convert.ToString(item.Id) + " " + item.Name);
            if (ItemsList.Items.Count > 0 && selectedIndex >= 0)
            {
                ItemsList.SelectedIndex = selectedIndex;
                _selectedItem = Store.Items[selectedIndex];
            }
            else
            {
                _selectedItem = null;
            }
            DisableElements();

            ItemsChanged?.Invoke(this, EventArgs.Empty);
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
            CategoryComboBox.Text = "";
        }

        /// <summary>
        /// Логика кнопки добавления товаров.
        /// </summary>
        /// <param name="sender"> Отправитель события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItem(ItemFactory.GenerateItem());
            FillItemsListBoxThroughSearch();
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
            _selectedItem = Search()[selectedIndex];
            IDBox.Text = Convert.ToString(_selectedItem.Id);
            CostBox.Text = Convert.ToString(_selectedItem.Cost);
            NameRichText.Text = _selectedItem.Name;
            DescriptionRichText.Text = _selectedItem.Info;
            CategoryComboBox.SelectedIndex = (int)_selectedItem.ItemCategory;
            DisableElements();
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
                if (_selectedItem != null)
                {
                    double enteredValue = Convert.ToDouble(CostBox.Text);
                    ValueValidator.AssertValueInRange(enteredValue, 0, 100000, "Cost");
                    _selectedItem.Cost = enteredValue;

                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_selectedItem != null)
                {
                    _selectedItem.Name = NameRichText.Text;
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                }
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
                if (_selectedItem != null)
                {
                    _selectedItem.Info = DescriptionRichText.Text;
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (ArgumentException)
            {
                DescriptionRichText.BackColor = Color.LightPink;
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            DisableElements();
            foreach (string category in Enum.GetNames(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }
            OrderByComboBox.SelectedIndex = 0;
        }

        private void NameRichText_Leave(object sender, EventArgs e)
        {
            try
            {
                ItemsList.Items[Store.Items.IndexOf(_selectedItem)] = Convert.ToString(_selectedItem.Id) + " " + _selectedItem.Name;
                SortByOption();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                FillItemsListBoxThroughSearch();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem.ItemCategory = (Category)CategoryComboBox.SelectedIndex;
        }

        private void ItemsTab_VisibleChanged(object sender, EventArgs e)
        {
            ItemsList.Items.Clear();
            foreach (Item item in Store.Items)
            {
                if (!ItemsList.Items.Contains(item.Id + " " + item.Name))
                {
                    ItemsList.Items.Add(item.Id + " " + item.Name);
                }
            }
        }

        /// <summary>
        /// Критерий фильтра предметов по названию.
        /// </summary>
        /// <param name="item"> Объект товара. </param>
        /// <returns> true или false. </returns>
        private bool FilterBySearch(Item item)
        {
            return item.Name.Contains(SearchTextBox.Text);
        }

        /// <summary>
        /// Заполнить листбокс предметов по данному списку.
        /// </summary>
        /// <param name="items"> Список предметов. </param>
        private void FillItemsListBox(List<Item> items)
        {
            ItemsList.Items.Clear();

            foreach (Item item in items)
            {
                ItemsList.Items.Add(item.Id + " " + item.Name);
            }
        }

        /// <summary>
        /// Функция фильтрации списка предметов из магазина по названию из поисковой строки.
        /// </summary>
        /// <returns> Список предметов по фильтру. </returns>
        private List<Item> Search()
        {
            return DataTools.Filter(Store.Items, FilterBySearch);
        }

        /// <summary>
        /// Функция заполнения списка предметов из магазина по поисковой строке.
        /// </summary>
        private void FillItemsListBoxThroughSearch()
        {
            FillItemsListBox(Search());
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FillItemsListBoxThroughSearch();
        }

        /// <summary>
        /// Сортировка списка товаров согласно выбранной опции сортировки товаров.
        /// </summary>
        private void SortByOption()
        {
            if (OrderByComboBox.SelectedIndex < 0)
            {
                return;
            }

            if (OrderByComboBox.SelectedIndex == 0)
            {
                DataTools.Sort(Store.Items, DataTools.ByNameSort);
            }

            if (OrderByComboBox.SelectedIndex == 1)
            {
                DataTools.Sort(Store.Items, DataTools.AscendByCostSort);
            }

            if (OrderByComboBox.SelectedIndex == 2)
            {
                DataTools.Sort(Store.Items, DataTools.DecreaseByCostSort);
            }

            FillItemsListBox(Search());
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortByOption();
        }
    }
}
