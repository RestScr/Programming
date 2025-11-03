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
    internal class Order
    {
        /// <summary>
        /// Поле класса, отвечающее за общее количество созданных экземпляров.
        /// </summary>
        private static readonly int _created = 0;

        /// <summary>
        /// Свойство созданных экземпляров класса.
        /// </summary>
        private static int Created
        {
            get
            {
                return _created;
            }
        }

        /// <summary>
        /// Идентификатор класса.
        /// </summary>
        public int Id { get; init; }
    }
}
