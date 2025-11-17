using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        /// <summary>
        /// Открытое свойство объекта адреса.
        /// </summary>
        public Address DeliveryAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод включения/отключения всех компонентов элемента.
        /// </summary>
        /// <param name="enabled"> true - включение / false - выключение. </param>
        public void Enable(bool enabled)
        {
            IndexBox.Enabled = enabled;
            CountryBox.Enabled = enabled;
            CityBox.Enabled = enabled;
            StreetBox.Enabled = enabled;
            BuildingBox.Enabled = enabled;
            ApartmentBox.Enabled = enabled;
        }

        /// <summary>
        /// Метод очистки полей.
        /// </summary>
        public void ClearBoxes()
        {
            IndexBox.Text = "";
            CountryBox.Text = "";
            CityBox.Text = "";
            StreetBox.Text = "";
            BuildingBox.Text = "";
            ApartmentBox.Text = "";
        }

        /// <summary>
        /// Заполнить все поля данными из объекта адреса.
        /// </summary>
        public void FillBoxes()
        {
            IndexBox.Text = DeliveryAddress.Index;
            CountryBox.Text = DeliveryAddress.Country;
            CityBox.Text = DeliveryAddress.City;
            StreetBox.Text = DeliveryAddress.Street;
            BuildingBox.Text = DeliveryAddress.Building;
            ApartmentBox.Text = DeliveryAddress.Apartment;
        }

        /// <summary>
        /// Заполнить все поля данными из объекта адреса.
        /// </summary>
        public void FillBoxes(Address address)
        {
            IndexBox.Text = address.Index;
            CountryBox.Text = address.Country;
            CityBox.Text = address.City;
            StreetBox.Text = address.Street;
            BuildingBox.Text = address.Building;
            ApartmentBox.Text = address.Apartment;
        }

        private void IndexBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexBox.BackColor = Color.White;
                DeliveryAddress.Index = IndexBox.Text;
            }
            catch (ArgumentException)
            {
                IndexBox.BackColor = Color.LightPink;
            }
        }

        private void CountryBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryBox.BackColor = Color.White;
                DeliveryAddress.Country = CountryBox.Text;
            }
            catch (ArgumentException)
            {
                CountryBox.BackColor = Color.LightPink;
            }
        }

        private void CityBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityBox.BackColor = Color.White;
                DeliveryAddress.City = CityBox.Text;
            }
            catch (ArgumentException)
            {
                CityBox.BackColor = Color.LightPink;
            }
        }

        private void StreetBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetBox.BackColor = Color.White;
                DeliveryAddress.Street = StreetBox.Text;
            }
            catch (ArgumentException)
            {
                StreetBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingBox.BackColor = Color.White;
                DeliveryAddress.Building = BuildingBox.Text;
            }
            catch (ArgumentException)
            {
                BuildingBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentBox.BackColor = Color.White;
                DeliveryAddress.Apartment = ApartmentBox.Text;
            }
            catch (ArgumentException)
            {
                ApartmentBox.BackColor = Color.LightPink;
            }
        }

        private void AddressControl_Load(object sender, EventArgs e)
        {

        }
    }
}
