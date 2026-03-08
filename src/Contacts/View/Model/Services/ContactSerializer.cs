using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public class ContactSerializer
    {
		private string _path = "Документы\\Contacts\\contacts.json";

		public string Path
		{
			get => _path;
			set 
			{ 
				_path = value;
			}
		}

	}
}
