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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        private Item _selectedItem = null;

        private Item SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
            }
        }

        public CartsTab()
        {
            InitializeComponent();
        }

        private void FillCart()
        {

        }

        private void ItemsCartListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = Store.Items[ItemsCartListBox.SelectedIndex];

        }

        private void CartsTab_Load(object sender, EventArgs e)
        {
            foreach (Item item in Store.Items)
            {
                ItemsCartListBox.Items.Add(item.Name);
            }
        }
    }
}
