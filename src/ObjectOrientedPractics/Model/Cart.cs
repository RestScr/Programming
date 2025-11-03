using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс корзины покупателя.
    /// </summary>
    internal class Cart
    {
        /// <summary>
        /// Список товаров покупателя.
        /// </summary>
        public List<Item> Items { get; init; } = new List<Item>();
        
        /// <summary>
        /// Свойство итоговой стоимости всех товаров в корзине.
        /// </summary>
        public double Amount
        {
            get
            {
                double cost = 0;
                foreach (Item item in Items)
                {
                    cost += item.Cost;
                }

                return cost;
            }
        }

    }
}
