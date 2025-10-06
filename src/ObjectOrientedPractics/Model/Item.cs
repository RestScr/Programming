using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара.
    /// </summary>
    internal class Item
    {
        private static int _createdItems = 0;

        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Свойство, определяющее идентификатор объекта класса.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            private init
            {
                if (value < 1)
                {
                    throw new ArgumentException("Class object's Identificator must be a positive number");
                }

                _id = value;
            }
        }

        /// <summary>
        /// Свойство, определяющее имя товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Name");
                _name = value;
            }
        }

        /// <summary>
        /// Свойство, определяющее описание товара.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, "Info");
                _info = value;
            }
        }

        /// <summary>
        /// Свойство, определяющее цену товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertValueInRange(value, 0, 100000, "Cost");

                _cost = value;
            }
        }

        /// <summary>
        /// Категория товара
        /// </summary>
        public Category ItemCategory { get; set; }

        /// <summary>
        /// Конструктор товара.
        /// </summary>
        /// <param name="name"> Название товара. </param>
        /// <param name="info"> Описание товара. </param>
        /// <param name="cost"> Цена на товар. </param>
        /// <param name="itemCategory"> Категория товара </param>
        public Item(string name, string info, double cost, Category itemCategory)
        {
            Id = ++_createdItems;
            Name = name;
            Info = info;
            Cost = cost;
            ItemCategory = itemCategory;
        }
    }
}
