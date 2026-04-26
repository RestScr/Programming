using CommunityToolkit.Mvvm.ComponentModel;

namespace Model;

/// <summary>
/// Класс контакта.
/// </summary>
public partial class Contact : ObservableObject, ICloneable, IEquatable<Contact>
{
    /// <summary>
    /// Статическое поле, хранящее количество созданных экземпляров.
    /// </summary>
    private static uint _created = 0;

	/// <summary>
	/// Поле идентификатора экземпляра.
	/// </summary>
	[ObservableProperty]
    private uint _id;

	/// <summary>
	/// Поле имени контакта.
	/// </summary>
	[ObservableProperty]
    private string _name;

	/// <summary>
	/// Поле номера телефона контакта.
	/// </summary>
	[ObservableProperty]
    private string _phoneNumber;

	/// <summary>
	/// Поле почты контакта.
	/// </summary>
	[ObservableProperty]
    private string _email;

    /// <summary>
    /// Статическое свойство, возвращающее количество созданных экземпляров класса.
    /// </summary>
    private static uint Created
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
    /// Конструктор контакта.
    /// </summary>
    /// <param name="name"> Имя контакта.</param>
    /// <param name="phoneNumber"> Телефон. </param>
    /// <param name="email"> Почта. </param>
    public Contact(string name="No Name", string phoneNumber="+7 (999) 999-99-99", string email="email@gmail.com")
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
		uint id, 
		string name = "No Name", 
		string phoneNumber = "+7 (999) 999-99-99", 
		string email = "email@gmail.com")
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
}
