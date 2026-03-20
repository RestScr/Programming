using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
	/// <summary>
	/// Класс сериализатора.
	/// </summary>
    public class ContactSerializer
    {

		// ------------ Поля и свойства -------------

		/// <summary>
		/// Статическое поле пути сохранения.
		/// </summary>
		static private string _path = "Документы\\Contacts\\contacts.json";

		/// <summary>
		/// Статическое свойство пути сохранения.
		/// </summary>
		public static string Path
		{
			get => _path;
			set 
			{ 
				_path = value;
			}
		}

		// ------------------- Конструкторы ------------------

		// ---------------- Методы ----------------------

		/// <summary>
		/// Метод выгрузки контакта.
		/// </summary>
		/// <returns> Выгруженный контакт из файла. </returns>
		public Contact Load()
		{
            FileInfo fileInfo = new FileInfo(Path);

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
                File.Create(Path);
            }
			string content = File.ReadAllText(Path);

            return JsonConvert.DeserializeObject<Contact>(content);
		}

		/// <summary>
		/// Метод сохранения контакта в файл.
		/// </summary>
		/// <param name="contact"> Контакт для сохранения. </param>
		public void Save(Contact contact)
		{
			FileInfo fileInfo = new FileInfo(Path);

			if (!File.Exists(Path))
			{
				Directory.CreateDirectory(fileInfo.DirectoryName);
				File.Create(Path);
			}
			string content = JsonConvert.SerializeObject(contact);
			File.WriteAllText(Path, content);
		}

	}
}
