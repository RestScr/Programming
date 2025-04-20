using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;

namespace Programming
{
    public partial class MainForm : Form
    {
        // Статический массив, содержащий типы перечислений
        private static System.Type[] EnumTypes = {
            typeof(Model.Enums.Color),
            typeof(EducationForm),
            typeof(Genre),
            typeof(Season),
            typeof(SmartphoneManufacturers),
            typeof(Weekday)
        };

        // Закрытый массив прямоугольников
        private const int _rectanglesAmount = 0;
        private List<Model.Geometry.Rectangle> _rectangles =
            new List<Model.Geometry.Rectangle>(_rectanglesAmount);

        // Закрытый массив нарисованных прямоугольников на канве
        List<Panel> _rectanglePanels = new List<Panel>();

        // Закрытый массив фильмов
        private Model.Film[] _films =
        {
            new Model.Film("Hero Of Worlds", new Random().Next(1, 120), new Random().Next(1990, 2025), "Action", new Random().NextDouble() * 10),
            new Model.Film("Orion", new Random().Next(1, 120), new Random().Next(1990, 2025), "Romance", new Random().NextDouble() * 10),
            new Model.Film("Gingerman", new Random().Next(1, 120), new Random().Next(1990, 2025), "Thriller", new Random().NextDouble() * 10),
            new Model.Film("Soulboat", new Random().Next(1, 120), new Random().Next(1990, 2025), "Philosophy", new Random().NextDouble() * 10),
            new Model.Film("Wings of Wild", new Random().Next(1, 120), new Random().Next(1990, 2025), "Fantasy", new Random().NextDouble() * 10),
            new Model.Film("Recreation", new Random().Next(1, 120), new Random().Next(1990, 2025), "Art House", new Random().NextDouble() * 10)
        };

        private Model.Geometry.Rectangle _currentRectangle = null; // переменная выбранного прямоугольника
        private Panel _currentPanel = null; // переменная, хранящая ссылку на выбранный прямоугольник на канве
        private Model.Film _currentFilm = null; // переменная выбранного фильма

        

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

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// Инициализация листбоксов исходя из созданных приватных массивов
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            GenerateRectangles();

            foreach (Model.Film film in _films)
            {
                FilmsListBox.Items.Add(film.Name + ", " + film.Genre);
            }
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

        // <summary>
        // События, происходящие при выборе
        // элемента в листбоксе перечислений
        // </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            AddItemsToListBox(ValuesListBox, Enum.GetNames(EnumTypes[selectedIndex]));
        }

        // <summary>
        // Действия, происходящие при выборе
        // элемента в листбоксе значений
        // </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEnum = EnumsListBox.SelectedIndex;
            string selectedValue = ValuesListBox.SelectedItem.ToString();
            ValueTextBox.Text = Convert.ToString((int)Enum.Parse(EnumTypes[selectedEnum], selectedValue));
        }

        // <summary>
        // Поведение кнопки парсинга перечисления дня недели
        // </summary>
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

        // <summary>
        // События при выборе лета
        // </summary>
        private void Summer()
        {
            MessageBox.Show("УРАААААА СОЛНЦЕ!!!", "Ура Солнце!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // <summary>
        // События при выборе осени
        // </summary>
        private void Autumn()
        {
            this.BackColor = System.Drawing.Color.DarkOrange;
        }

        // <summary>
        // События при выборе зимы
        // </summary>
        private void Winter()
        {
            this.BackColor = System.Drawing.Color.DarkGray;

            System.Drawing.Drawing2D.GraphicsPath window = new System.Drawing.Drawing2D.GraphicsPath();
            window.AddEllipse(0, 0, this.Width, this.Height);
            this.Region = new Region(window);

            MessageBox.Show("бррр, холодно", "брррр!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // <summary>
        // События при выборе весны
        // </summary>
        private void Spring()
        {
            this.BackColor = System.Drawing.Color.LightGreen;
        }

        private void SetSelectedRectangle(int index)
        {
            DrawnRectanglesBox.SelectedIndex = index;
            RectanglesListBox.SelectedIndex = index;
        }

        // <summary>
        // Кнопка, отвечающая за выполнение событий в зависимости от
        // выбранного сезона
        // </summary>
        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:
                    Summer();
                    break;
                case 1:
                    Autumn();
                    break;
                case 2:
                    Winter();
                    break;
                case 3:
                    Spring();
                    break;
            }
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectanglesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[index];
            _currentRectangle = _rectangles[index];
            SetSelectedRectangle(index);

            HeightTextBox.Text = Convert.ToString(_currentRectangle.Height);
            WidthTextBox.Text = Convert.ToString(_currentRectangle.Width);
            ColorTextBox.Text = Convert.ToString(_currentRectangle.Color);
            CenterXTextBox.Text = Convert.ToString(_currentRectangle.Center.X);
            CenterYTextBox.Text = Convert.ToString(_currentRectangle.Center.Y);

            IdTextBox.Text = Convert.ToString(_currentRectangle.Id);
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

        // <summary>
        // Закрытый метод, который ищет фильм с максимальным рейтингом
        // </summary>
        // <param name="films"> Массив фильмов </param>
        private void FindFilmWithMaxRating(Model.Film[] films)
        {
            int maxRatingFilmIndex = 0;

            for (int i = 0; i < films.Length; i++)
            {
                if (films[i].Rating > films[maxRatingFilmIndex].Rating)
                {
                    maxRatingFilmIndex = i;
                }
            }

            FilmsListBox.SelectedIndex = maxRatingFilmIndex;
        }

        // <summary>
        // Логика листбокса с фильмами при нажатии на элемент в списке
        // </summary>
        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.SelectedIndex;
            if (index == -1)
            {
                _currentFilm = null;
                return;
            }

            _currentFilm = _films[index]; // запись ссылки выбранного элемента в общую приватную переменную
            RatingTextBox.Text = Convert.ToString(_currentFilm.Rating);
            ReleaseYearTextBox.Text = Convert.ToString(_currentFilm.ReleaseYear);
            DurationTextBox.Text = Convert.ToString(_currentFilm.DurationInMinutes);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null)
            {
                return;
            }

            try
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.DurationInMinutes = Convert.ToInt32(DurationTextBox.Text);
            }
            catch (Exception)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если фильм не выбран
            if (_currentFilm == null)
            {
                return;
            }

            // Далее реализуется логика присваивания значения из текстбокса
            // в свойство года выпуска выбранного фильма
            try
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
            }
            catch (ArgumentException)
            {
                // Если заданное значение не прошло валидацию
                ReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentFilm == null)
            {
                return;
            }

            try
            {
                RatingTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.Rating = Convert.ToDouble(RatingTextBox.Text);
            }
            catch (Exception)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FindFilmWithMaxRating(_films);
        }

        /// <summary>
        /// Add rectangle logic
        /// </summary>
        /// <param name="rectangle"> Rectangle object </param>
        private void AddRectangle(Model.Geometry.Rectangle rectangle)
        {
            _rectangles.Add(rectangle);
            AddItemToListBox(DrawnRectanglesBox, "Rectangle " + rectangle.Id);
            AddItemToListBox(RectanglesListBox, "Rectangle " + rectangle.Id);
        }
        
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
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                }
                else
                {
                    _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
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
            _rectanglePanels.Last().BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
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
            RectanglesListBox.Items.RemoveAt(index);
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

            SetSelectedRectangle(index);

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
                DrawnXTextBox.BackColor = System.Drawing.Color.White;
                double value = Convert.ToDouble(DrawnXTextBox.Text);
                _currentRectangle.Center.X = value;
            }
            catch (FormatException)
            {
                DrawnXTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnYTextBox.BackColor = System.Drawing.Color.White;
                double value = Convert.ToDouble(DrawnYTextBox.Text);
                _currentRectangle.Center.Y = value;
            }
            catch (FormatException)
            {
                DrawnYTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnWidthTextBox.BackColor = System.Drawing.Color.White;
                double value = Convert.ToDouble(DrawnWidthTextBox.Text);
                Validator.AssertOnPositiveValue(value);
                _currentRectangle.Width = value;
            }
            catch (FormatException)
            {
                DrawnWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (ArgumentException)
            {
                DrawnWidthTextBox.BackColor = System.Drawing.Color.LightPink;
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
                DrawnHeightTextBox.BackColor = System.Drawing.Color.White;
                double value = Convert.ToDouble(DrawnHeightTextBox.Text);
                Validator.AssertOnPositiveValue(value);
                _currentRectangle.Height = value;
            }
            catch (FormatException)
            {
                DrawnHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }

            catch (ArgumentException)
            {
                DrawnHeightTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            UpdateSelectedPanelOnCanvas();
        }
    }
}
