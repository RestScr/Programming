using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int _points = 0;
        public int Points { 
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Points property must be equal or higher than zero.");
                }

                _points = value;
            }
        }

        public string Info { 
            get
            {
                return "Накопительная - " + Points + " баллов";
            }
        }

        public double Calculate(List<Item> items)
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                totalPrice += item.Cost;
            }
            
            return (int)Math.Ceiling(Math.Min(Points, totalPrice * 0.3));
        }

        public double Apply(List<Item> items)
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                totalPrice += item.Cost;
            }

            double discount = Calculate(items);

            if (discount >= totalPrice * 0.3)
            {
                Points = Math.Max(Points - (int)totalPrice, 0);
            }
            else
            {
                Points = 0;
            }

            return discount;
        }

        public void Update(List<Item> items)
        {
            double totalPrice = 0;
            foreach (Item item in items)
            {
                totalPrice += item.Cost;
            }
            Points += (int)Math.Ceiling(totalPrice * 0.1);
        }

        /// <summary>
        /// Сравнить скидки по баллам.
        /// </summary>
        /// <param name="pointsDiscount"> Объект скидки для сравнения. </param>
        /// <returns> -1 - если передаваемый объект больше, 0 - равны и 1 - если меньше. </returns>
        public int CompareTo(PointsDiscount pointsDiscount)
        {
            if (Points == pointsDiscount.Points)
            {
                return 0;
            }

            if (Points > pointsDiscount.Points)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
