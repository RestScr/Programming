using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace View.Model;

/// <summary>
/// Класс контакта.
/// </summary>
public class Contact : ICloneable, IEquatable<Contact>, INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Функция, вызывающее событие изменения свойства.
    /// </summary>
    /// <param name="propertyName"></param>
    /// <returns> Всегда true. </returns>
    public bool OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        return true;
    }

    /// <summary>
    /// Статическое поле, хранящее количество созданных экземпляров.
    /// </summary>
    private static int _created = 0;

    /// <summary>
    /// Поле идентификатора экземпляра.
    /// </summary>
    private int _id;

    /// <summary>
    /// Поле имени контакта.
    /// </summary>
    private string _name;

    /// <summary>
    /// Поле номера телефона контакта.
    /// </summary>
    private string _phoneNumber;

    /// <summary>
    /// Поле почты контакта.
    /// </summary>
    private string _email;

    /// <summary>
    /// Поле редактируемого имени.
    /// </summary>
    private string _temporaryNameField;

    /// <summary>
    /// Поле редактируемого номера телефона.
    /// </summary>
    private string _temporaryPhoneNumberField;

    /// <summary>
    /// Поле редактируемой электронной почты.
    /// </summary>
    private string _temporaryEmailField;

    /// <summary>
    /// Статическое свойство, возвращающее количество созданных экземпляров класса.
    /// </summary>
    private static int Created
	{
		get => _created;
		set
		{
                if (value - _created != 1)
                {
				throw new ArgumentException($"{nameof(Created)} must be higher than new value precisely by 1");
                }

                _created = value;
		}
	}

	/// <summary>
	/// Свойство идентификатора экземпляра класса.
	/// </summary>
	public int Id
	{
		get => _id;
		init 
		{
			if (value < 0)
			{
				throw new ArgumentException($"{nameof(Id)} must be higher than zero.");
			}

                Set(ref _id, value, nameof(Id));
            }
	}

	/// <summary>
	/// Свойство имени контакта.
	/// </summary>
	public string Name
	{
		get => _name;
		set 
		{
                Set(ref _name, value, nameof(Name));
            }
	}

	/// <summary>
	/// Свойство номера телефона контакта.
	/// </summary>
	public string PhoneNumber
	{
		get => _phoneNumber;
		set 
		{ 
                Set(ref _phoneNumber, value, nameof(PhoneNumber));
            }
	}

    /// <summary>
    /// Свойство почты контакта.
    /// </summary>
    public string Email
	{
		get => _email;
		set 
		{
			Set(ref _email, value, nameof(Email)); 
		}
	}

	/// <summary>
	/// Свойство редактируемого имени.
	/// </summary>
	public string TemporaryNameField
	{
		get => _temporaryNameField;
		set 
		{
			Set(ref _temporaryNameField, value, nameof(TemporaryNameField));
		}
	}

	/// <summary>
	/// Свойство редактируемого номера телефона.
	/// </summary>
	public string TemporaryPhoneNumberField
	{
		get => _temporaryPhoneNumberField;
		set 
		{ 
			Set(ref _temporaryPhoneNumberField, value, nameof(TemporaryPhoneNumberField));
		}
	}
	
	/// <summary>
	/// Свойство редактируемой электронной почты.
	/// </summary>
	public string TemporaryEmailField
	{
		get => _temporaryEmailField;
		set 
		{
			Set(ref _temporaryEmailField, value, nameof(TemporaryEmailField));
		}
	}

	public Contact(string name="No Name", string phoneNumber="", string email="")
	{
		Name = name;
		PhoneNumber = phoneNumber;
		Email = email;
		Id = Created++;

		TemporaryNameField = name;
		TemporaryPhoneNumberField = phoneNumber;
		TemporaryEmailField = email;
	}

	/// <summary>
	/// Закрытый конструктор для клонирования контакта.
	/// </summary>
	/// <param name="id"> Идентификатор клона. </param>
	/// <param name="name"> Название контакта. </param>
	/// <param name="phoneNumber"> Номер телефона контакта. </param>
	/// <param name="email"> Почта контакта. </param>
	/// <param name="temporaryNameField"> Значение редактируемого поля имени. </param>
	/// <param name="temporaryPhoneNumberField"> Значение редактируемого поля номера телефона. </param>
	/// <param name="temporaryEmailField"> Значение редактируемого поля почты. </param>
	private Contact(
		int id, 
		string name = "No Name", 
		string phoneNumber = "", 
		string email = "",
		string temporaryNameField = "No Name",
		string temporaryPhoneNumberField = "",
		string temporaryEmailField = "")
	{
		Name = name;
		PhoneNumber = phoneNumber;
		Email = email;
		Id = id;

		TemporaryNameField = temporaryNameField;
		TemporaryPhoneNumberField = temporaryPhoneNumberField;
		TemporaryEmailField = temporaryEmailField;
    }

    /// <summary>
    /// Метод клонирования контактов.
    /// </summary>
    /// <returns> Клон контакта. </returns>
    public object Clone()
    {
        return new Contact(
		Id, 
		Name, 
		PhoneNumber, 
		Email,
		TemporaryNameField,
		TemporaryPhoneNumberField,
		TemporaryEmailField);
    }

	/// <summary>
	/// Метод эквивалентного сравнения интерфейса по идентификатору.
	/// </summary>
	/// <param name="other"> Объект для сравнения. </param>
	/// <returns> true, если объеты равны, false - иначе. </returns>
    public bool Equals(Contact? other)
    {
	return other.Id == Id;
    }

    /// <summary>
    /// Функция задания нового уникального значения полю с уведомлением.
    /// </summary>
    /// <typeparam name="Type"> Тип поля. </typeparam>
    /// <param name="fieldToSet"> Ссылка на поле, которому нужно задать значение. </param>
    /// <param name="setValue"> Значение для задания. </param>
    /// <param name="propertyName"> Имя свойства, в котором задается значение. </param>
    /// <returns> Является ли значение новым для поля. (true - да, false - нет). </returns>
    private bool Set<Type>(ref Type fieldToSet, Type setValue, [CallerMemberName] string propertyName = null)
    {
        if (Equals(fieldToSet, setValue))
        {
            return false;
        }
        else
        {
            fieldToSet = setValue;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

	/// <summary>
	/// Метод для фиксации отредактированных значений полей.
	/// </summary>
	public void Commit()
	{
		Name = TemporaryNameField;
		PhoneNumber = TemporaryPhoneNumberField;
		Email = TemporaryEmailField;
	}

	/// <summary>
	/// Отменить изменение свойств.
	/// </summary>
	public void RollBack()
	{
		TemporaryNameField = Name;
            TemporaryPhoneNumberField = PhoneNumber;
            TemporaryEmailField = Email;
	}
}
