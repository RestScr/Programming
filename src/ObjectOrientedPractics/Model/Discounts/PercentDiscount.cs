using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Класс процентной скидки.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        private double _moneySpentOnCategory = 0;

        /// <summary>
        /// Свойство категории скидки.
        /// </summary>
        public Category DiscountCategory { get; set; } = Category.Disk;

        /// <summary>
        /// Количество потраченных денег на определенную категорию.
        /// </summary>
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

        /// <summary>
        /// Свойство текущей скидки в процентах.
        /// </summary>
        public int CurrentDiscount
        {
            get
            {
                return Math.Min((int) MoneySpentOnCategory / 1000, 10);
            }
        }

        /// <summary>
        /// Свойство информации о скидке.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Процентная - \"{Enum.GetName(DiscountCategory)}\" - {CurrentDiscount}%";
            }
        }

        /// <summary>
        /// Рассчет скидки.
        /// </summary>
        /// <param name="items"> Список товаров к покупке. </param>
        /// <returns> Величину потенциальной скидки. </returns>
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

        /// <summary>
        /// Применить скидку.
        /// </summary>
        /// <param name="items"> Список товаров, на основе которых считается скидка. </param>
        /// <returns> Величину скидки. </returns>
        public double Apply(List<Item> items)
        {
            double result = Calculate(items);
            MoneySpentOnCategory = 0;

            return result;
        }

        /// <summary>
        /// Обновление скидки.
        /// </summary>
        /// <param name="items"> Список товаров к покупке. </param>
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

        /// <summary>
        /// Стандартный конструктор оьъекта процентной скидки.
        /// </summary>
        public PercentDiscount() : base() { }

        /// <summary>
        /// Конструктор скидки с передаваемой категорией.
        /// </summary>
        /// <param name="category"> Категория товара. </param>
        public PercentDiscount(Category category) : base()
        {
            DiscountCategory = category;
        }

        /// <summary>
        /// Сравнение двух объектов по скидке в процентах. 
        /// </summary>
        /// <param name="percentDiscount"> Объект скидки. </param>
        /// <returns> -1, если передаваемый объект больше, 1 - иначе</returns>
        public int CompareTo(PercentDiscount percentDiscount)
        {
            if (CurrentDiscount == percentDiscount.CurrentDiscount)
            {
                return 0;
            }

            if (CurrentDiscount < percentDiscount.CurrentDiscount)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
