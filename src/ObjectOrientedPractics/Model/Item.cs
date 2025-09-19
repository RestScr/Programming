using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Item
    {
        private static int _createdItems = 0;

        private readonly int _id;
        private string _name;
        private string _info;
        private double _cost;

        /// <summary>
        /// Свойство, определяющее идентификатор объекта класса
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
                    throw new ArgumentException("Identificator must be positive");
                }

                _id = value;
            }
        }

        /// <summary>
        /// Свойство, определяющее имя товара
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length > 200)
                {
                    throw new ArgumentException("Name text length must be less than 200");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Свойство, определяющее описание товара
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                if (value.Length > 1000)
                {
                    throw new ArgumentException("Info text length must be less than 1000");
                }
            }
        }

        /// <summary>
        /// Свойство, определяющее цену товара
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value > 100000 || value < 0)
                {
                    throw new ArgumentException("Cost must be between 0 and 100000");
                }
            }
        }

        /// <summary>
        /// Конструктор товара
        /// </summary>
        /// <param name="name"> Название товара </param>
        /// <param name="info"> Описание товара </param>
        /// <param name="cost"> Цена на товар </param>
        public Item(string name, string info, double cost)
        {
            Id = ++_createdItems;
            Name = name;
            Info = info;
            Cost = cost;
        }
    }
}
