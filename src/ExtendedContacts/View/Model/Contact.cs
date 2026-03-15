using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
	/// <summary>
	/// Класс контакта.
	/// </summary>
    public class Contact
    {

		private string _name = "";

		public string Name
		{
			get => _name;
			set 
			{ 
				_name = value;
			}
		}

		private string _phoneNumber = "";

		public string PhoneNumber
		{
			get => _phoneNumber;
			set 
			{ 
				_phoneNumber = value; 
			}
		}

		private string _email = "";

		public string Email
		{
			get => _email;
			set 
			{ 
				_email = value; 
			}
		}
	}
}
