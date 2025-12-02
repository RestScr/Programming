using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс скидки. 
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Свойство выдачи информации по скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчет скидки покупателя.
        /// </summary>
        /// <param name="items"> Список товаров к покупке. </param>
        /// <returns> Рассчитанную скидку. </returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Метод применения скидки.
        /// </summary>
        /// <param name="items"> Список товаров к покупке. </param>
        /// <returns></returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Метод обновления информации о скидке.
        /// </summary>
        /// <param name="items"> Список товаров к покупке. </param>
        void Update(List<Item> items);
    }
}
