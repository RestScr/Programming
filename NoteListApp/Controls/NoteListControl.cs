using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteListApp.Model.Classes;
using NoteListApp.Model.Enums;

namespace NoteListApp.Controls
{
    /// <summary>
    /// Пользовательский элемент управления, отвечающий за функционал
    /// программы с заметками.
    /// </summary>
    public partial class NoteListControl : UserControl
    {
        private Note _selectedNote = null;
        private List<Note> notes = new List<Note>();

        /// <summary>
        /// Стандартный конструктор элемента управления.
        /// </summary>
        public NoteListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, выполняющийся при изменении выбранного элемента в списке заметок.
        /// </summary>
        /// <param name="sender"> Обхект отправителя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = NotesListBox.SelectedIndex;
            _selectedNote = notes[index];

            TitleTextBox.Text = _selectedNote.Title;
            NoteTextBox.Text = _selectedNote.Text;
            CreationTextBox.Text = _selectedNote.CreationTime.ToString();
            CategoryComboBox.SelectedIndex = (int)_selectedNote.Category;
        }

        /// <summary>
        /// Метод, срабатывающий при нажатии кнопки добавления новых заметок.
        /// </summary>
        /// <param name="sender"> Обхект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            NotesListBox.Items.Insert(0, new Note());
        }

        /// <summary>
        /// Метод обрабатывающий введённое значение, задающее заголовок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            TitleTextBox.BackColor = Constants.DefaultTextBoxColor;
        }

        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки редактирования заметки.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _selectedNote.Title = TitleTextBox.Text;
                _selectedNote.Text = NoteTextBox.Text;
                _selectedNote.Category = (NoteCategory)(Convert.ToInt32(CategoryComboBox.Text));
            }
            catch (ArgumentException)
            {
                TitleTextBox.BackColor = Constants.WrongColor;
            }
        }
    }
}

