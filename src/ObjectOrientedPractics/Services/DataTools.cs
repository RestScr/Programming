using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Сервисный класс фильтрации товаров.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Свойство цены фильтра.
        /// </summary>
        private static int ComparableValue { get; set; } = 5000;

        /// <summary>
        /// Свойство категории фильтрации.
        /// </summary>
        private static Category ComparableCategory { get; set; } = Category.Disk;

        /// <summary>
        /// Делегат критерия фильтра.
        /// </summary>
        /// <param name="item"> Объект товара, к которому применяется критерий. </param>
        /// <returns> true или false </returns>
        public delegate bool FilterCriteria(Item item);

        /// <summary>
        /// Фильтрация по цене выше заданной.
        /// </summary>
        /// <param name="item"> Объект товара. </param>
        /// <returns> true или false. </returns>
        public static bool FilterByCost(Item item)
        {
            return item.Cost > ComparableValue;
        }

        /// <summary>
        /// Фильтрация по категории.
        /// </summary>
        /// <param name="item"> Объект товара. </param>
        /// <returns> true или false. </returns>
        public static bool FilterByCategory(Item item)
        {
            return item.ItemCategory == ComparableCategory;
        }

        /// <summary>
        /// Метод фильтрации.
        /// </summary>
        /// <param name="items"> Список товаров. </param>
        /// <param name="criteria"> Критерий фильтрации. </param>
        /// <returns> Отфильтрованный список. </returns>
        public static List<Item> Filter(List<Item> items, FilterCriteria criteria)
        {
            List<Item> output = new List<Item>();

            foreach (Item item in items)
            {
                if (criteria(item))
                {
                    output.Add(item);
                }
            }

            return output;
        }


    }
}
