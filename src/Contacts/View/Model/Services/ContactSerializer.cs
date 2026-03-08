using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace View.Model.Services
{
    public class ContactSerializer
    {
		static private string _path = "Документы\\Contacts\\contacts.json";

		public static string Path
		{
			get => _path;
			set 
			{ 
				_path = value;
			}
		}

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
