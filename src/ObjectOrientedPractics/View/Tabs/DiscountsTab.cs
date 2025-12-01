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
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class DiscountsTab : UserControl
    {
        private IDiscount Discounter { get; set; } = new PercentDiscount();
        public DiscountsTab()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            foreach (Item item in Store.Items)
            {
                totalPrice += item.Cost;
            }

            DiscountInfoLabel.Text = "Info: " + Discounter.Info;
            ProductsAmountLabel.Text = Convert.ToString(totalPrice);
            DiscountAmountLabel.Text = Convert.ToString(Discounter.Calculate(Store.Items));
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DiscountAmountLabel.Text = Convert.ToString(Discounter.Apply(Store.Items));
            DiscountInfoLabel.Text = "Info: " + Discounter.Info;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Discounter.Update(Store.Items);
            DiscountAmountLabel.Text = Convert.ToString(Discounter.Calculate(Store.Items));
            DiscountInfoLabel.Text = "Info: " + Discounter.Info;
        }
    }
}
