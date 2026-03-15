using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;

namespace View.ViewModel.Commands
{
    /// <summary>
    /// Класс команды.
    /// </summary>
    public class Command : ICommand
    {
        /// <summary>
        /// Событие, уведомляющее об изменении состояния вызова команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Полек функции команды.
        /// </summary>
        private Action<object> _executionCommand;

        /// <summary>
        /// Свойство функции команды.
        /// </summary>
        public Action<object> ExecutionCommand
        {
            get { return _executionCommand; }
            set { _executionCommand = value; }
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
        public Command(Action<object> action)
        {
            ExecutionCommand = action;
        }
    }
}
