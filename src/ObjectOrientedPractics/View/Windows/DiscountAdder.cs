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
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Windows
{
    public partial class DiscountAdder : Form
    {
        public DiscountAdder()
        {
            InitializeComponent();
        }

        private void DiscountAdder_Load(object sender, EventArgs e)
        {
            foreach (string enumString in Enum.GetNames(typeof(Category)))
            {
                DiscountCategoryComboBox.Items.Add(enumString);
            }
            if (ReturnCategory() < 0)
            {
                OkButton.Enabled = false;
            }
            else
            {
                OkButton.Enabled = true;
            }
        }

        /// <summary>
        /// Метод, возвращающий выбранную категорию в комбобоксе.
        /// </summary>
        /// <returns> Категория. </returns>
        public Category ReturnCategory()
        {
            Category category = (Category)(DiscountCategoryComboBox.SelectedIndex);

            return category;
        }

        private void DiscountCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReturnCategory() < 0)
            {
                OkButton.Enabled = false;
            }
            else
            {
                OkButton.Enabled = true;
            }

        }
    }
}
