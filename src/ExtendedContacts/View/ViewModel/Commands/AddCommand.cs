using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel.Commands
{
    /// <summary>
    /// Класс команды добавления.
    /// </summary>
    public class AddCommand : ICommand
    {
        /// <summary>
        /// Событие, уведомляющее об изменении состояния вызова команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Поле функции команды.
        /// </summary>
        private Action<object> _executionCommand;

        /// <summary>
        /// Свойство функции команды.
        /// </summary>
        public Action<object> ExecutionCommand
        {
            get => _executionCommand;
            set 
            { 
                _executionCommand = value; 
            }
        }

        /// <summary>
        /// Функция, уведомляющее можно ли вызвать команду.
        /// </summary>
        /// <param name="parameter"> Параметр функции. </param>
        /// <returns> Можно ли вызвать команду. </returns>
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        /// <summary>
        /// Вызвать функцию команды.
        /// </summary>
        /// <param name="parameter"> Параметр команды. </param>
        public void Execute(object? parameter)
        {
            ExecutionCommand(parameter);
        }

        /// <summary>
        /// Конструктор команды с аргументом функции.
        /// </summary>
        /// <param name="action"> Делегат. </param>
        public AddCommand(Action<object> action)
        {
            _executionCommand = action;
        }
    }
}
