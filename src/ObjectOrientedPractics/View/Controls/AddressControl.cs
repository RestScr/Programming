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
                DeliveryAddress.Index = BuildingBox.Text;
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
                DeliveryAddress.Index = ApartmentBox.Text;
            }
            catch (ArgumentException)
            {
                ApartmentBox.BackColor = Color.LightPink;
            }
        }
    }
}
