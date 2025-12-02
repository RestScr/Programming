using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
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

        private double _discountAmount = 0;

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
        /// Свойство размера примененной скидки.
        /// </summary>
        public double DiscountAmount 
        { 
            get
            {
                return _discountAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("DiscountAmount property must be higher or equal to zero.");
                }

                _discountAmount = value;
            }
        }

        /// <summary>
        /// Рассчет стоимости всех товаров с учетом скидок.
        /// </summary>
        public double Total 
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        public OrderStatus Status { get; set; } = OrderStatus.New;

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
        /// Конструктор заказа.
        /// </summary>
        /// <param name="address"> Адрес доставки заказа. </param>
        /// <param name="cart"> Корзина покупателя. </param>
        public Order(Address address, Cart cart)
        {
            Id = ++Created;
            OrderAddress = address;
            foreach (Item item in cart.Items)
            {
                Items.Add(item);
            }
        }

        /// <summary>
        /// Конструктор заказа.
        /// </summary>
        /// <param name="address"> Адрес доставки заказа. </param>
        /// <param name="cart"> Корзина покупателя. </param>
        /// <param name="totalOrderDiscount"> Размер примененной скидки. </param>
        public Order(Address address, Cart cart, double totalOrderDiscount)
        {
            Id = ++Created;
            OrderAddress = address;
            foreach (Item item in cart.Items)
            {
                Items.Add(item);
            }
            DiscountAmount = totalOrderDiscount;
        }

        /// <summary>
        /// Конструктор заказа.
        /// </summary>
        /// <param name="address"> Адрес доставки заказа. </param>
        /// <param name="cart"> Корзина покупателя. </param>
        /// <param name="status"> Статус заказа. </param>
        public Order(Address address, Cart cart, OrderStatus status)
        {
            Id = Created++;
            OrderAddress = address;
            foreach (Item item in cart.Items)
            {
                Items.Add(item);
            }
            Status = status;
        }
    }
}
