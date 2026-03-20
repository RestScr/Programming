using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services;

/// <summary>
/// Класс JSON сериализатора и работы с файлами
/// </summary>
public class ContactListSerializer
{
    /// <summary>
    /// Поле, хранящее путь к файлу сохранения.
    /// </summary>
    private string _path = "/Мои Документы/Contacts.json";

    /// <summary>
    /// Свойство пути файла сохранения.
    /// </summary>
    public string Path
    {
        get => _path;
    }

    /// <summary>
    /// Метод выгрузки списка контактов из файла.
    /// </summary>
    /// <returns></returns>
    public ObservableCollection<Contact> Load()
    {
        FileInfo fileInfo = new FileInfo(Path);
        if (!fileInfo.Directory.Exists)
        {
            Directory.CreateDirectory(fileInfo.Directory.FullName);
        }

        if (!File.Exists(Path))
        {
            File.Create(Path);
        }

        string content = File.ReadAllText(Path);

        ObservableCollection<Contact> loadedContacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(content);

        if (loadedContacts == null)
        {
            return new ObservableCollection<Contact>();
        }

        return loadedContacts;
    }

    /// <summary>
    /// Метод сохранения списка контактов.
    /// </summary>
    /// <param name="contactList"> Список контактов. </param>
    public void Save(ObservableCollection<Contact> contactList)
    {
        string content = JsonConvert.SerializeObject(contactList);
        File.WriteAllText(Path, content);
    }
}
