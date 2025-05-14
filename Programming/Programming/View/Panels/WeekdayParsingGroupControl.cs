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
    /// парсинг перечисления дней недели.
    /// </summary>
    public partial class WeekdayParsingGroupControl : UserControl
    {
        /// <summary>
        /// Стандартный конструктор класса.
        /// </summary>
        public WeekdayParsingGroupControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Поведение кнопки парсинга перечисления дня недели.
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string enteredValue = ParseTextBox.Text;
            try
            {
                object foundValue = Enum.Parse(typeof(Weekday), enteredValue);
                ParseOutputLabel.Text = $"Это день недели ({enteredValue} = {(int)foundValue})";
            }
            catch (System.ArgumentException)
            {
                ParseOutputLabel.Text = "Нет такого дня недели";
            }
        }


    }
}
