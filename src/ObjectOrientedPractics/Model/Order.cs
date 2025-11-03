using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс заказа.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Поле класса, отвечающее за общее количество созданных экземпляров.
        /// </summary>
        private static int _created = 0;

        /// <summary>
        /// Свойство созданных экземпляров класса.
        /// </summary>
        private static int Created
        {
            get
            {
                return _created;
            }
            set
            {
                if (value - _created != 1)
                {
                    throw new ArgumentException("Created property must be always higher by 1 when set");
                }

                _created = value;
            }
        }

        /// <summary>
        /// Идентификатор класса.
        /// </summary>
        public int Id { get; init; }

        /// <summary>
        /// Список заказанных товаров.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Итоговая сумма заказа.
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

        /// <summary>
        /// Свойство даты создания заказа.
        /// </summary>
        public DateTime OrderTime { get; init; } = DateTime.Now;

        /// <summary>
        /// Свойство адреса доставки товара.
        /// </summary>
        public Address OrderAddress { get; set; }

        /// <summary>
        /// Стандартный конструктор класса заказа.
        /// </summary>
        public Order(Address address, Cart cart)
        {
            Id = Created++;
            OrderAddress = address;
            foreach (Item item in cart.Items)
            {
                Items.Add(item);
            }
        }
    }
}
