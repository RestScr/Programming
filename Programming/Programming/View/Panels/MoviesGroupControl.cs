using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Panels
{
    public partial class MoviesGroupControl : UserControl
    {
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
        private Model.Film _currentFilm = null; // переменная выбранного фильма
        private bool _initialized = false;

        public MoviesGroupControl()
        {
            InitializeComponent();
        }

        private void FilmsGroupBox_Enter(object sender, EventArgs e)
        {
            if (_initialized)
            {
                return;
            }

            foreach (Model.Film film in _films)
            {
                FilmsListBox.Items.Add(film.Name + ", " + film.Genre);
            }
            _initialized = true;
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
                ReleaseYearTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                _currentFilm.DurationInMinutes = Convert.ToInt32(DurationTextBox.Text);
            }
            catch (Exception)
            {
                DurationTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
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
                ReleaseYearTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                _currentFilm.ReleaseYear = Convert.ToInt32(ReleaseYearTextBox.Text);
            }
            catch (ArgumentException)
            {
                // Если заданное значение не прошло валидацию
                ReleaseYearTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
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
                RatingTextBox.BackColor = Model.Static.AppColors.BasicTextBoxColor;
                _currentFilm.Rating = Convert.ToDouble(RatingTextBox.Text);
            }
            catch (Exception)
            {
                RatingTextBox.BackColor = Model.Static.AppColors.WrongValueColor;
            }
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FindFilmWithMaxRating(_films);
        }
    }
}
