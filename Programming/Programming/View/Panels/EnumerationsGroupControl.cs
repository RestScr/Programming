using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс пользовательского элемента управления, отвечающего за
    /// перечисления.
    /// </summary>
    public partial class EnumerationsGroupControl : UserControl
    {
        /// <summary>
        /// Стандартный конструктор элемента управления.
        /// </summary>
        public EnumerationsGroupControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Статический массив, содержащий типы перечислений.
        /// </summary>
        private static System.Type[] EnumTypes = {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(SmartphoneManufacturers),
            typeof(Weekday)
        };

        /// <summary>
        /// Метод добавления одного объекта в листбокс
        /// </summary>
        /// <param name="listBox"> Экземпляр листбокса </param>
        /// <param name="item"> Сам объект </param>
        static private void AddItemToListBox(ListBox listBox, string item)
        {
            listBox.Items.Add(item);
        }

        /// <summary>
        /// Добавление новых элементов в ListBox
        /// с удалением предыдущих
        /// </summary>
        /// <param name="listBox"> Данный листбокс </param>
        /// <param name="itemNames"> Список имен элементов </param>
        static private void AddItemsToListBox(ListBox listBox, string[] itemNames)
        {
            listBox.Items.Clear();
            foreach (string name in itemNames)
            {
                AddItemToListBox(listBox, name);
            }
        }

        /// <summary>
        /// События, происходящие при выборе
        /// элемента в листбоксе перечислений.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            AddItemsToListBox(ValuesListBox, Enum.GetNames(EnumTypes[selectedIndex]));
        }

        /// <summary>
        /// Действия, происходящие при выборе
        /// элемента в листбоксе значений.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEnum = EnumsListBox.SelectedIndex;
            string selectedValue = ValuesListBox.SelectedItem.ToString();
            ValueTextBox.Text = Convert.ToString((int)Enum.Parse(EnumTypes[selectedEnum], selectedValue));
        }
    }
}
