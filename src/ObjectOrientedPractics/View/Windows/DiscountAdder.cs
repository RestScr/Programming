using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Windows
{
    public partial class DiscountAdder : Form
    {
        public DiscountAdder()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiscountCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DiscountAdder_Load(object sender, EventArgs e)
        {
            foreach (string enumString in Enum.GetNames(typeof(Category)))
            {
                DiscountCategoryComboBox.Items.Add(enumString);
            }
        }
    }
}
