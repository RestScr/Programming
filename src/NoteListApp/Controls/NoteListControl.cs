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
        /// <summary>
        /// Выбранная запись
        /// </summary>
        private Note _selectedNote = null;
        /// <summary>
        /// Поле списка записей
        /// </summary>
        private List<Note> _notes = new List<Note>();

        /// <summary>
        /// Свойство, задающее список записей
        /// </summary>
        public List<Note> Notes
        {
            get
            {
                List<Note> output = new List<Note>();
                foreach (Note note in _notes)
                {
                    output.Add(note);
                }
                return output;
            }
            private set
            {
                _notes = value;
            }
        }

        /// <summary>
        /// Стандартный конструктор элемента управления.
        /// </summary>
        public NoteListControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод, выгружающий данные из файла при открытии приложения
        /// </summary>
        public void LoadDataFromFile()
        {
            
            FileInfo fileInfo = new FileInfo(Constants.DataFilePath);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }
            
            string loadText = File.ReadAllText(fileInfo.FullName);
            if (loadText == "")
            {
                return;
            }
            List<Note> loadData = Note.Deserialize(loadText);

            foreach (Note note in loadData)
            {
                _notes.Add(note);
                NotesListBox.Items.Add(note.Title);
            }
        }

        /// <summary>
        /// Метод, сохраняющий данные списка при закрытии
        /// </summary>
        public void SaveDataToFile()
        {
            FileInfo fileInfo = new FileInfo(Constants.DataFilePath);
            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            string saveData = "";
            foreach (Note note in Notes)
            {
                saveData += note.Serialize();
            }
            File.WriteAllText(fileInfo.FullName, saveData);
        }

        /// <summary>
        /// Метод, выполняющийся при изменении выбранного элемента в списке заметок.
        /// </summary>
        /// <param name="sender"> Обхект отправителя события. </param>
        /// <param name="e"> Аргументы события. </param>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = NotesListBox.SelectedIndex;
            if (index < 0)
            {
                TitleTextBox.Text = "";
                NoteTextBox.Text = "";
                CreationTextBox.Text = "";
                CategoryComboBox.Text = "";
                CategoryComboBox.Enabled = false;
                TitleTextBox.Enabled = false;
                NoteTextBox.Enabled = false;
                return;
            }
            _selectedNote = _notes[index];

            TitleTextBox.Text = _selectedNote.Title;
            NoteTextBox.Text = _selectedNote.Text;
            CreationTextBox.Text = _selectedNote.CreationTime.ToString();
            CategoryComboBox.SelectedIndex = (int)_selectedNote.Category;
            CategoryComboBox.Enabled = true;
            TitleTextBox.Enabled = true;
            NoteTextBox.Enabled = true;
        }

        /// <summary>
        /// Метод, срабатывающий при нажатии кнопки добавления новых заметок.
        /// </summary>
        /// <param name="sender"> Обхект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void CreateNoteButton_Click(object sender, EventArgs e)
        {
            _notes.Insert(0, new Note());
            NotesListBox.Items.Insert(0, _notes[0].Title);
        }

        /// <summary>
        /// Метод обрабатывающий введённое значение, задающее заголовок.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (Validator.AssertOnCharacterLength(TitleTextBox.Text, Constants.MaxTitleCharactersLength, Constants.MinTitleCharactersLength))
            {
                TitleTextBox.BackColor = Constants.DefaultTextBoxColor;
            }
        }

        /// <summary>
        /// Метод, вызывающийся при нажатии кнопки редактирования заметки.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            if (_selectedNote == null)
            {
                return;
            }
            try
            {
                _selectedNote.Title = TitleTextBox.Text;
                _selectedNote.Text = NoteTextBox.Text;
                _selectedNote.Category = (NoteCategory)(CategoryComboBox.SelectedIndex);
                int index = _notes.IndexOf(_selectedNote);
                NotesListBox.Items[index] = _selectedNote.Title;
            }
            catch (ArgumentException)
            {
                TitleTextBox.BackColor = Constants.WrongColor;
                MessageBox.Show("Note Title must contain from 1 up to 100 letters", "Incorrect Value",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Логика кнопки удаления записей.
        /// </summary>
        /// <param name="sender"> Объект отправителя. </param>
        /// <param name="e"> Аргументы события. </param>
        private void RemoveNoteButton_Click(object sender, EventArgs e)
        {
            int index = NotesListBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }

            _notes.RemoveAt(index);
            NotesListBox.Items.RemoveAt(index);
            _selectedNote = null;

            NotesListBox.SelectedIndex = --index;
        }
    }
}

