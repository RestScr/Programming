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
    /// Класс заметки.
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Статическое поле, хранящее количество созданных экземпляров.
        /// </summary>
        private static int _createdNotes = 0;
        /// <summary>
        /// Поле заголовка.
        /// </summary>
        private string _title;

        /// <summary>
        /// Личный идентификатор объекта
        /// </summary>
        public int Id { get; init; }
        
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
        /// Конструктор класса заметки.
        /// </summary>
        /// <param name="title"> Заголовок. </param>
        /// <param name="text"> Текст заметки. </param>
        /// <param name="category"> Категория. </param>
        /// <param name="creationTime"> Время создания. </param>
        public Note(string title, string text, NoteCategory category, DateTime creationTime)
        {
            Id = ++_createdNotes;
            Title = title;
            Text = text;
            Category = category;
            CreationTime = creationTime;
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

        /// <summary>
        /// Метод сериализации заметки для записи в текстовый файл
        /// </summary>
        /// <returns> Данные в строковом виде </returns>
        public string Serialize()
        {
            string output = "";
            output += Convert.ToString(Id) + '\n' + Title + '\n' + CreationTime.ToString() + '\n' + Convert.ToString((int)Category) + ((char)2) + Text + ((char)3);

            return output;
        }

        /// <summary>
        /// Метод для десериализации данных из текста
        /// </summary>
        /// <param name="text"> Текст для парсинга </param>
        /// <returns> Возврат данных </returns>
        public static List<Note> Deserialize(string text)
        {
            List<Note> output = new List<Note>();
            string[] data = text.Split((char)3);
            foreach (string item in data)
            {
                string[] metadataAndText = item.Split((char)2);
                string[] metadata = metadataAndText[0].Split('\n');
                if (metadata[0] == "")
                {
                    break;
                }
                int id = Convert.ToInt32(metadata[0]);
                string title = metadata[1];

                // Парсинг времени создания
                string[] creationTimeData = metadata[2].Split(' ');
                string[] creationDateInString = creationTimeData[0].Split('.');
                string[] creationTimeInString = creationTimeData[1].Split(':');
                DateTime creationTime = new DateTime(
                    Convert.ToInt32(creationDateInString[2]), 
                    Convert.ToInt32(creationDateInString[1]),
                    Convert.ToInt32(creationDateInString[0]),
                    Convert.ToInt32(creationTimeInString[0]),
                    Convert.ToInt32(creationTimeInString[1]),
                    Convert.ToInt32(creationTimeInString[2])
                );

                NoteCategory category = (NoteCategory)(Convert.ToInt32(metadata[3]));
                string description = metadataAndText[1];

                output.Add(new Note(title, description, category, creationTime));
            }
            return output;
        }
    }
}
