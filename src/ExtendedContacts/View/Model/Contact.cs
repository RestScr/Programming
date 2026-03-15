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
		/// <summary>
		/// Поле имени контакта.
		/// </summary>
		private string _name = "No Name";

		/// <summary>
		/// Свойство имени контакта.
		/// </summary>
		public string Name
		{
			get => _name;
			set 
			{ 
				_name = value;
			}
		}

		/// <summary>
		/// Поле номера телефона контакта.
		/// </summary>
		private string _phoneNumber = "";

		/// <summary>
		/// Свойство номера телефона контакта.
		/// </summary>
		public string PhoneNumber
		{
			get => _phoneNumber;
			set 
			{ 
				_phoneNumber = value; 
			}
		}

		/// <summary>
		/// Поле почты контакта.
		/// </summary>
		private string _email = "";

		/// <summary>
		/// Свойство почты контакта.
		/// </summary>
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
