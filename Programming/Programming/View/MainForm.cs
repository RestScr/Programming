using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        // Статический массив, содержащий типы перечислений
        private static System.Type[] EnumTypes = {
            typeof(Model.Color),
            typeof(Model.EducationForm),
            typeof(Model.Genre),
            typeof(Model.Season),
            typeof(Model.SmartphoneManufacturers),
            typeof(Model.Weekday)
        };

        // Закрытый массив прямоугольников
        private Model.Rectangle[] _rectangles = {
            new Model.Rectangle(new Random().NextDouble() * 3, new Random().NextDouble() * 10, "Red"),
            new Model.Rectangle(new Random().NextDouble() * 6, new Random().NextDouble() * 10, "Green"),
            new Model.Rectangle(new Random().NextDouble() * 4, new Random().NextDouble() * 12, "Blue"),
            new Model.Rectangle(new Random().NextDouble() * 7, new Random().NextDouble() * 10, "Yellow"),
            new Model.Rectangle(new Random().NextDouble() * 5, new Random().NextDouble() * 10, "Orange"),
        };

        private Model.Film[] _films =
        {
            new Model.Film("Hero Of Worlds", new Random().Next(1, 120), new Random().Next(1990, 2025), "Action", new Random().NextDouble() * 10),
            new Model.Film("Orion", new Random().Next(1, 120), new Random().Next(1990, 2025), "Romance", new Random().NextDouble() * 10),
            new Model.Film("Gingerman", new Random().Next(1, 120), new Random().Next(1990, 2025), "Thriller", new Random().NextDouble() * 10),
            new Model.Film("Soulboat", new Random().Next(1, 120), new Random().Next(1990, 2025), "Philosophy", new Random().NextDouble() * 10),
            new Model.Film("Wings of Wild", new Random().Next(1, 120), new Random().Next(1990, 2025), "Fantasy", new Random().NextDouble() * 10),
            new Model.Film("Recreation", new Random().Next(1, 120), new Random().Next(1990, 2025), "Art House", new Random().NextDouble() * 10)
        };

        private Model.Rectangle _currentRectangle = null; // переменная выбранного прямоугольника
        private Model.Film _currentFilm = null; // переменная выбранного фильма

        public MainForm()
        {
            InitializeComponent();
        }

        // <summary>
        // Загрузка формы
        // </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Model.Rectangle rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add("Rectangle " + i++);
            }

            foreach (Model.Film film in _films)
            {
                FilmsListBox.Items.Add(film.Name + ", " + film.Genre);
            }
        }

        // <summary>
        // Добавление новых элементов в ListBox
        // с удалением предыдущих
        // </summary>
        // <param name="listBox"> Данный листбокс </param>
        // <param name="itemNames"> Список имен элементов </param>
        static private void SetItemsToListBox(ListBox listBox, string[] itemNames)
        {
            listBox.Items.Clear();
            foreach (string name in itemNames)
            {
                listBox.Items.Add(name);
            }
        }

        // <summary>
        // События, происходящие при выборе
        // элемента в листбоксе перечислений
        // </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            SetItemsToListBox(ValuesListBox, Enum.GetNames(EnumTypes[selectedIndex]));
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
            HeightTextBox.Text = Convert.ToString(_rectangles[index].Height);
            WidthTextBox.Text = Convert.ToString(_rectangles[index].Width);
            ColorTextBox.Text = Convert.ToString(_rectangles[index].Color);
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }

            try
            {
                HeightTextBox.BackColor = System.Drawing.Color.White;
                _currentRectangle.Height = Convert.ToDouble(HeightTextBox.Text);
            }
            catch (FormatException)
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
        private void FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            int maxWidthRectangleIndex = 0;

            for (int i = 0; i < rectangles.Length; i++)
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

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = FilmsListBox.SelectedIndex;
            if (index == -1)
            {
                _currentFilm = null;
                return;
            }

            _currentFilm = _films[index];
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
            if (_currentFilm == null)
            {
                return;
            }

            try
            {
                ReleaseYearTextBox.BackColor = System.Drawing.Color.White;
                _currentFilm.ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
            }
            catch (Exception)
            {
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
    }
}
