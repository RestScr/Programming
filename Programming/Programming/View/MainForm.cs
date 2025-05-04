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
        private Model.Film _currentFilm = null; // переменная выбранного фильма

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
    }
}
