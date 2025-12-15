using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SubProject.Model;


namespace SubProject.View.Windows
{
    public partial class ContactForm : Form
    {
        public event EventHandler<EventArgs> FieldChanged;

        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция заполнения текстовых полей данными из статического класса Contact.
        /// </summary>
        /// <param name="sender"> Объект, пославший событие. </param>
        /// <param name="e"> Аргументы события. </param>
        public void FillFields(object? sender, EventArgs e)
        {
            NameBox.Text = Contact.FullName;

            PhoneBox.Text = Contact.Phone;

            AddressBox.Text = Contact.Address;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            Contact.FullName = NameBox.Text;

            FieldChanged?.Invoke(this, EventArgs.Empty);
        }

        private void PhoneBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Phone = PhoneBox.Text;

            FieldChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddressBox_TextChanged(object sender, EventArgs e)
        {
            Contact.Address = AddressBox.Text;

            FieldChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
