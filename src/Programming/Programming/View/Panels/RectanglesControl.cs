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

namespace Programming.View.Panels
{
    /// <summary>
    /// Класс пользовательского элемента управления, отвечающего за группу редактирования прямоугольников.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Начальное количество прямоугольников.
        /// </summary>
        private const int _rectanglesAmount = 10;

        /// <summary>
        /// Определение, был ли элемент управления инициализирован при нажатии на него.
        /// </summary>
        private bool _initialized = false;

        /// <summary>
        /// переменная выбранного прямоугольника
        /// </summary>
        private Model.Geometry.Rectangle _currentRectangle = null; 

        /// <summary>
        /// Список прямоугольников.
        /// </summary>
        private List<Model.Geometry.Rectangle> _rectangles =
            new List<Model.Geometry.Rectangle>();

        /// <summary>
        /// Стандартный конструктор прямоугольников.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация элемента управления при нажатии.
        /// </summary>
        /// <param name="sender"> Объект отправителя.</param>
        /// <param name="e"> Аргументы события. </param>
        private void RectanglesGroupBox_Enter(object sender, EventArgs e)
        {
            if (_initialized)
            {
                return;
            }

            for (int i = 0; i < _rectanglesAmount; i++)
            {
                _rectangles.Add(Model.Geometry.RectangleFactory.Randomize());
                RectanglesListBox.Items.Add(_rectangles[i]);
            }
            _initialized = true;
        }

        /// <summary>
        /// Выбор прямоугольника в листбоксе.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _currentRectangle = _rectangles[index];
            SetSelectedRectangle(index);

            HeightTextBox.Text = Convert.ToString(_currentRectangle.Height);
            WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            ColorTextBox.Text = Convert.ToString(_currentRectangle.Color);
            CenterXTextBox.Text = Convert.ToString(_currentRectangle.Center.X);
            CenterYTextBox.Text = Convert.ToString(_currentRectangle.Center.Y);

            IdTextBox.Text = Convert.ToString(_currentRectangle.Id);
        }

        /// <summary>
        /// Выделить выбранный прямоугольник в списке прямоугольников.
        /// </summary>
        /// <param name="index"> Индекс выделенного прямоугольника. </param>
        private void SetSelectedRectangle(int index)
        {
            RectanglesListBox.SelectedIndex = index;
        }

        /// <summary>
        /// Логика кнопки поиска прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth(_rectangles);
        }

        /// <summary>
        /// Закрытый метод, организующий поиск прямоугольника с максимальной шириной в массиве
        /// </summary>
        /// <param name="rectangles"> Массив прямоугольников </param>
        private void FindRectangleWithMaxWidth(List<Model.Geometry.Rectangle> rectangles)
        {
            int maxWidthRectangleIndex = 0;

            for (int i = 0; i < rectangles.Count(); i++)
            {
                if (rectangles[maxWidthRectangleIndex].Width < rectangles[i].Width)
                {
                    maxWidthRectangleIndex = i;
                }
            }

            RectanglesListBox.SelectedIndex = maxWidthRectangleIndex;
        }

        /// <summary>
        /// Метод, отвечающий за корректный ввод ширины прямоугольника в текстбоксе.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если прямоугольник не выбран, то обработка прекращается
            if (_currentRectangle == null)
            {
                return;
            }

            // Логика присваивания введённого значения
            try
            {
                HeightTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                _currentRectangle.Height = Convert.ToDouble(HeightTextBox.Text);
            }
            catch (FormatException)
            {
                // Случай, если введённое значение не прошло валидацию,
                // то фон текстбокса меняет свой цвет на красный
                HeightTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
            catch (ArgumentException)
            {
                HeightTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
        }

        /// <summary>
        /// Метод, отвечающий за корректный ввод ширины прямоугольника в текстбоксе.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                WidthTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
            catch (ArgumentException)
            {
                WidthTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
        }

        /// <summary>
        /// Метод, отвечающий за корректный ввод цвета прямоугольника.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            _currentRectangle.Color = ColorTextBox.Text;
        }
    }
}
