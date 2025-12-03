using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс адреса.
    /// </summary>
    public class Address : ICloneable
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        /// <summary>
        /// Свойство 6-значного индекса адреса доставки.
        /// </summary>
        public string Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertStringOnNumber(value, "Index");
                ValueValidator.AssertStringOnStrictLengthEquality(value, 6, "Index");

                _index = value;
            }
        }

        /// <summary>
        /// Свойство страны адреса доставки.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Свойство города адреса доставки.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");

                _city = value;
            }
        }

        /// <summary>
        /// Свойство улицы адреса доставки.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");

                _street = value;
            }
        }

        /// <summary>
        /// Свойство дома адреса доставки.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");

                _building = value;
            }
        }

        /// <summary>
        /// Свойство номера квартиры адреса доставки.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");

                _apartment = value;
            }
        }

        /// <summary>
        /// Конструктор объекта адреса.
        /// </summary>
        /// <param name="index"> Индекс, 6-значное число. </param>
        /// <param name="country"> Страна. </param>
        /// <param name="city"> Город. </param>
        /// <param name="street"> Улица. </param>
        /// <param name="building"> Номер дома. </param>
        /// <param name="apartment"> Номер квартиры. </param>
        public Address(string index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Конструктор адреса по умолчанию.
        /// </summary>
        public Address()
        {
            Index = "000000";
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        public object Clone()
        {
            Address address = new Address(Index, Country, City, Street, Building, Apartment);

            return address;
        }
    }
}
