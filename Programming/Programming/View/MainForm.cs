using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Runtime.InteropServices.ComTypes;
using Programming.Model;
using Programming.Model.Enums;
using Programming.Model.Geometry;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрузка формы
        /// Инициализация листбоксов исходя из созданных приватных массивов
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Метод добавления одного объекта в листбокс
        /// </summary>
        /// <param name="listBox"> Экземпляр листбокса </param>
        /// <param name="item"> Сам объект </param>
        static private void AddItemToListBox(ListBox listBox, string item)
        {
            listBox.Items.Add(item);
        }
    }
}
