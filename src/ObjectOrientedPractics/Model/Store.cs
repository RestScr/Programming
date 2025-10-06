using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Store
    {
        List<Item> _items = new List<Item>();
        List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Свойство совокупности товаров.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
        }

        /// <summary>
        /// Свойство совокупности покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
        }

        /// <summary>
        /// Конструктор класса магазина по умолчанию.
        /// </summary>
        public Store() { }
    }
}
