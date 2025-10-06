using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс фабрики товаров.
    /// </summary>
    internal static class ItemFactory
    {
        public static Item GenerateItem()
        {
            return new Item("Item", "Description", 10050, Category.Disk);
        }
    }
}
