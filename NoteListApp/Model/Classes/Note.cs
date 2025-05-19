using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoteListApp.Model.Enums;

namespace NoteListApp.Model.Classes
{
    /// <summary>
    /// Класс заметки
    /// </summary>
    internal class Note
    {
        /// <summary>
        /// Статическое поле, хранящее количество созданных экземпляров.
        /// </summary>
        private static int _createdNotes = 0;

        /// <summary>
        /// Личный идентификатор объекта
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Поле заголовка.
        /// </summary>
        private string _title;
        
        /// <summary>
        /// Свойство, работающее с полем заголовка. Длина заголовка не превышает 100 символов.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (!Validator.AssertOnCharacterLength(value, 
                    Constants.MaxTitleCharactersLength,
                    Constants.MinTitleCharactersLength))
                {
                    throw new ArgumentException(
                        $"Error: Title must be between {Constants.MinTitleCharactersLength} and {Constants.MaxTitleCharactersLength}");
                }

                _title = value;
            }
        }

        /// <summary>
        /// Текст заметки.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        public DateTime CreationTime { get; init; }

        /// <summary>
        /// Категория заметки (Дом/Работа/Спорт/Финансы).
        /// </summary>
        public NoteCategory Category { get; set; }

        /// <summary>
        /// Конструктор класса заметки.
        /// </summary>
        /// <param name="title"> Заголовок. </param>
        /// <param name="text"> Текст заметки. </param>
        /// <param name="category"> Категория. </param>
        public Note(string title, string text, NoteCategory category)
        {
            Id = ++_createdNotes;
            Title = title;
            Text = text;
            Category = category;
            CreationTime = DateTime.Now;
        }

        /// <summary>
        /// Стандартный конструктор заметки.
        /// </summary>
        public Note()
        {
            Id = ++_createdNotes;
            Title = "Note" + Id;
            Text = "Sample Text";
            Category = NoteCategory.Home;
            CreationTime = DateTime.Now;
        }
    }
}
