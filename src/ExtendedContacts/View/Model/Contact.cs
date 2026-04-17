using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;


namespace View.Model;

/// <summary>
/// Класс контакта.
/// </summary>
public class Contact : ICloneable, IEquatable<Contact>, INotifyPropertyChanged, IDataErrorInfo
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
    /// <inheritdoc/>
    /// </summary>
    public string Error => throw new NotImplementedException();

    /// <summary>
    /// <inheritdoc/>
    /// </summary>
    /// <param name="columnName"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public string this[string columnName]
    {
        get
        {
            string error = string.Empty;
            switch (columnName)
            {
                case "Name":
                    if (Name.Length > 100)
                    {
                        error = "Имя должно состоять из менее, чем 100 символов.";
                    }
                    break;
                    /*
                case "PhoneNumber":
                    if (PhoneNumber.Length > 100)
                    {
                        error = "Телефон должен состоять из менее, чем 100 символов.";
                    }
                    if (Regex.IsMatch(PhoneNumber, @"\+7\(\s\d{3}\)\s\d{3}-\s\d{2}-\d{2}"))
                    {
                        error = "Телефон должен соответствовать шаблону +7 (xxx) xxx-xx-xx";
                    }
                    break;
                case "Email":
                    if (Email.Length > 100)
                    {
                        error = "Почта должна состоять из менее, чем 100 символов.";
                    }
                    if (Regex.IsMatch(Email, "^\\S+@\\S+\\.\\S+$"))
                    {
                        error = "Почта должна удовлетворять шаблону emailname@email.com";
                    }
                    break;
                    */
            }

            return error;
        }
    }

    public Contact(string name="No Name", string phoneNumber="", string email="")
	{
		Name = name;
		PhoneNumber = phoneNumber;
		Email = email;
		Id = Created++;
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
		string email = "")
	{
		Name = name;
		PhoneNumber = phoneNumber;
		Email = email;
		Id = id;
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
		Email);
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
}
