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
using Programming.Model.Geometry;
using Programming.Model.Static;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void RectanglesCollisionControl_Load(object sender, EventArgs e)
        {

        }

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
        /// Add rectangle logic
        /// </summary>
        /// <param name="rectangle"> Rectangle object </param>
        private void AddRectangle(Model.Geometry.Rectangle rectangle)
        {
            _rectangles.Add(rectangle);
            AddItemToListBox(DrawnRectanglesBox, "Rectangle " + rectangle.Id);
            //AddItemToListBox(RectanglesListBox, "Rectangle " + rectangle.Id);
        }

        // Закрытый массив прямоугольников
        private const int _rectanglesAmount = 0;
        private List<Model.Geometry.Rectangle> _rectangles =
            new List<Model.Geometry.Rectangle>(_rectanglesAmount);
        private Panel _currentPanel = null; // переменная, хранящая ссылку на выбранный прямоугольник на канве

        // Закрытый массив нарисованных прямоугольников на канве
        List<Panel> _rectanglePanels = new List<Panel>();

        private Model.Geometry.Rectangle _currentRectangle = null; // переменная выбранного прямоугольника

        /// <summary>
        /// Метод определения, есть ли коллизия у заданного прямоугольника
        /// </summary>
        /// <returns> True, если есть коллизия хотя бы с одним из прямоугольников, False - иначе</returns>
        bool DoesCollideWithAny(Model.Geometry.Rectangle rectangle)
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (_rectangles[i].Id == rectangle.Id)
                {
                    continue;
                }
                if (CollisionManager.IsCollision(rectangle, _rectangles[i]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Логика поиска коллизий, логика перекрашивания прямоугольников в случае коллизий
        /// </summary>
        private void FindCollisions()
        {
            for (int i = 0; i < _rectangles.Count; i++)
            {
                if (DoesCollideWithAny(_rectangles[i]))
                {
                    _rectanglePanels[i].BackColor = Model.Static.AppColors.CollisionColor;
                }
                else
                {
                    _rectanglePanels[i].BackColor = Model.Static.AppColors.DrawnRectangleColor;
                }
            }
        }

        /// <summary>
        /// Добавить изображение прямоугольника на канву
        /// </summary>
        /// <param name="rectangle"> Объект прямоугольника </param>
        private void AddRectanglePanel(Model.Geometry.Rectangle rectangle)
        {
            _rectanglePanels.Add(new Panel());
            _rectanglePanels.Last().Width = (int)_currentRectangle.Width;
            _rectanglePanels.Last().Height = (int)_currentRectangle.Height;
            _rectanglePanels.Last().Location = new Point(
                (int)(_currentRectangle.Center.X - _currentRectangle.Width / 2),
                (int)(_currentRectangle.Center.Y - _currentRectangle.Height / 2)
            );
            _rectanglePanels.Last().BackColor = Model.Static.AppColors.DrawnRectangleColor;
            _rectanglePanels.Last().Visible = true;
            Canvas.Controls.Add(_rectanglePanels.Last());

        }

        private void IncreaseRectanglesButton_MouseHover(object sender, EventArgs e)
        {
            IncreaseRectanglesButton.Image = Properties.Resources.plus_hover;
        }

        private void IncreaseRectanglesButton_MouseLeave(object sender, EventArgs e)
        {
            IncreaseRectanglesButton.Image = Properties.Resources.plus;
        }

        private void DecreaseRectanglesButton_MouseHover(object sender, EventArgs e)
        {
            DecreaseRectanglesButton.Image = Properties.Resources.minus_hover;
        }

        private void DecreaseRectanglesButton_MouseLeave(object sender, EventArgs e)
        {
            DecreaseRectanglesButton.Image = Properties.Resources.minus;
        }

        private void IncreaseRectanglesButton_Click(object sender, EventArgs e)
        {
            AddRectangle(RectangleFactory.Randomize(Canvas));
            int index = _rectangles.Count() - 1;
            _currentRectangle = _rectangles[index];
            AddRectanglePanel(_rectangles[index]);
            FindCollisions();
            DrawnRectanglesBox.SelectedIndex = index;
        }

        private void DecreaseRectanglesButton_Click(object sender, EventArgs e)
        {
            int index = DrawnRectanglesBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            _rectangles.RemoveAt(index);
            DrawnRectanglesBox.Items.RemoveAt(index);
            _rectanglePanels.RemoveAt(index);
            Canvas.Controls.RemoveAt(index);
            index = Math.Min(index, _rectangles.Count - 1);
            if (index < 0)
            {
                return;
            }
            DrawnRectanglesBox.SelectedIndex = index;
            _currentRectangle = _rectangles[index];

            FindCollisions();
        }

        /// <summary>
        /// Метод, очищающий данные в текстовых 
        /// поля со значениями прямоугольника
        /// </summary>
        private void ClearRectangleInfo()
        {
            _currentRectangle = null;
            _currentPanel = null;

            DrawnIdBox.Text = "";
            DrawnXTextBox.Text = "";
            DrawnYTextBox.Text = "";
            DrawnWidthTextBox.Text = "";
            DrawnHeightTextBox.Text = "";
        }

        /// <summary>
        /// Метод, вписывающий данные в текстовые поля конкретного прямоугольника
        /// </summary>
        /// <param name="rectangle"> Прямоугольник, данные которого будут выписаны в текстовых полях</param>
        private void UpdateRectangleInfo(Model.Geometry.Rectangle rectangle)
        {
            DrawnIdBox.Text = Convert.ToString(rectangle.Id);
            DrawnXTextBox.Text = Convert.ToString(rectangle.Center.X);
            DrawnYTextBox.Text = Convert.ToString(rectangle.Center.Y);
            DrawnWidthTextBox.Text = Convert.ToString(rectangle.Width);
            DrawnHeightTextBox.Text = Convert.ToString(rectangle.Height);
        }

        private void DrawnRectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = DrawnRectanglesBox.SelectedIndex;
            if (index < 0)
            {
                ClearRectangleInfo();
                return;
            }

            _currentRectangle = _rectangles[index];
            _currentPanel = _rectanglePanels[index];

            UpdateRectangleInfo(_currentRectangle);
        }

        /// <summary>
        /// Метод, который обновляет выбранный прямоугольник на канве в зависимости от выбранного
        /// прямоугольника как сущности
        /// </summary>
        private void UpdateSelectedPanelOnCanvas()
        {
            _currentPanel.Width = (int)_currentRectangle.Width;
            _currentPanel.Height = (int)_currentRectangle.Height;
            _currentPanel.Location = new Point(
                (int)_currentRectangle.Center.X - _currentPanel.Width / 2,
                (int)_currentRectangle.Center.Y - _currentPanel.Height / 2
            );
            FindCollisions();
        }

        private void DrawnXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentPanel == null)
            {
                return;
            }

            try
            {
                DrawnXTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                double value = Convert.ToDouble(DrawnXTextBox.Text);
                _currentRectangle.Center.X = value;
            }
            catch (FormatException)
            {
                DrawnXTextBox.BackColor = Model.Static.AppColors.WrongValueColor ;
            }

            UpdateSelectedPanelOnCanvas();
        }

        private void DrawnYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                DrawnYTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                double value = Convert.ToDouble(DrawnYTextBox.Text);
                _currentRectangle.Center.Y = value;
            }
            catch (FormatException)
            {
                DrawnYTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }

            UpdateSelectedPanelOnCanvas();
        }

        private void DrawnWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                DrawnWidthTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                double value = Convert.ToDouble(DrawnWidthTextBox.Text);
                Validator.AssertOnPositiveValue(value);
                _currentRectangle.Width = value;
            }
            catch (FormatException)
            {
                DrawnWidthTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
            catch (ArgumentException)
            {
                DrawnWidthTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }

            UpdateSelectedPanelOnCanvas();
        }

        private void DrawnHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                DrawnHeightTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                double value = Convert.ToDouble(DrawnHeightTextBox.Text);
                Validator.AssertOnPositiveValue(value);
                _currentRectangle.Height = value;
            }
            catch (FormatException)
            {
                DrawnHeightTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }

            catch (ArgumentException)
            {
                DrawnHeightTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
            UpdateSelectedPanelOnCanvas();
        }

        /// <summary>
        /// Метод, реализующий случайную генерацию прямоугольников в массиве
        /// </summary>
        private void GenerateRectangles()
        {
            for (int i = 0; i < _rectanglesAmount; i++)
            {
                AddRectangle(
                    Model.Geometry.RectangleFactory.Randomize(Canvas)
                );
            }
        }
    }
}
