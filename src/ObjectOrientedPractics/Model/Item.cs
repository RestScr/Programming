using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс товара.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
    {
        private static int _createdItems = 0;

        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        public event EventHandler<EventArgs> NameChanged;
        public event EventHandler<EventArgs> CostChanged;
        public event EventHandler<EventArgs> InfoChanged;

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

                NameChanged?.Invoke(this, new EventArgs());
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

                InfoChanged?.Invoke(this, new EventArgs());
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
                CostChanged?.Invoke(this, new EventArgs());
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

        /// <summary>
        /// Клонировать объект.
        /// </summary>
        /// <returns> Клон объекта. </returns>
        public object Clone()
        {
            Item clone = new Item(Name, Info, Cost, ItemCategory);

            return clone;
        }

        /// <summary>
        /// Узнать, не равны ли объекты.
        /// </summary>
        /// <param name="item"> Объект товара. </param>
        /// <returns> true, если равны, false - иначе. </returns>
        public bool Equals(Item? item)
        {
            if (item == null)
            {
                return false;
            }

            return item.Name == Name && 
                item.Cost == Cost &&
                item.Info == Info &&
                item.ItemCategory == ItemCategory;
        }

        /// <summary>
        /// Сравнить предметы по стоимости.
        /// </summary>
        /// <param name="other"> Объект к сравнению. </param>
        /// <returns> -1 - если передаваемый предмет больше, 0 - равны, 1 - если передаваемый объект меньше. </returns>
        public int CompareTo(Item other)
        {
            if (Cost == other.Cost)
            {
                return 0;
            }

            if (other.Cost > Cost)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
