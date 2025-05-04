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
    public partial class RectanglesControl : UserControl
    {
        private const int _rectanglesAmount = 10;
        private bool _initialized = false;
        private Model.Geometry.Rectangle _currentRectangle = null; // переменная выбранного прямоугольника
        private List<Model.Geometry.Rectangle> _rectangles =
            new List<Model.Geometry.Rectangle>();

        public RectanglesControl()
        {
            InitializeComponent();
        }

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
        /// Выделить выбранный прямоугольник в списке прямоугольников
        /// </summary>
        /// <param name="index"> Индекс выделенного прямоугольника </param>
        private void SetSelectedRectangle(int index)
        {
            RectanglesListBox.SelectedIndex = index;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth(_rectangles);
        }

        // <summary>
        // Закрытый метод, организующий поиск прямоугольника с максимальной шириной в массиве
        // </summary>
        // <param name="rectangles"> Массив прямоугольников </param>
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
                HeightTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Height = Convert.ToDouble(HeightTextBox.Text);
            }
            catch (FormatException)
            {
                // Случай, если введённое значение не прошло валидацию,
                // то фон текстбокса меняет свой цвет на красный
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                HeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                WidthTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

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
