using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PercentDiscount : IDiscount
    {
        private double _moneySpentOnCategory = 0;


        public Category DiscountCategory { get; set; } = Category.Disk;
        public double MoneySpentOnCategory
        {
            get
            {
                return _moneySpentOnCategory;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("MoneySpentOnCategory must be high or equal to zero.");
                }

                _moneySpentOnCategory = value;
            }
        }
        public int CurrentDiscount
        {
            get
            {
                return Math.Min((int) MoneySpentOnCategory / 1000, 10);
            }
        }

        public string Info
        {
            get
            {
                return $"Процентная - \"{Enum.GetName(DiscountCategory)}\" - {CurrentDiscount}%";
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                if (item.ItemCategory == DiscountCategory)
                {
                    totalPrice += item.Cost;
                }
            }

            return (int)(totalPrice / 100 * CurrentDiscount);
        }

        public double Apply(List<Item> items)
        {
            MoneySpentOnCategory = 0;

            return Calculate(items);
        }

        public void Update(List<Item> items)
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                if (item.ItemCategory == DiscountCategory)
                {
                    totalPrice += item.Cost;
                }
            }

            MoneySpentOnCategory += totalPrice; 
        }

        public PercentDiscount() : base() { }

        public PercentDiscount(Category category) : base()
        {
            DiscountCategory = category;
        }
    }
}
