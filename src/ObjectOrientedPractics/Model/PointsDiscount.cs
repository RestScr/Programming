using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount : IDiscount
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

        public String Info { 
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

            if (Calculate(items) >= totalPrice * 0.3)
            {
                Points -= (int)totalPrice;
            }
            else
            {
                Points = 0;
            }

            return Calculate(items);
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
    }
}
