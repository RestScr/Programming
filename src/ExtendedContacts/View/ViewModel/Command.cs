using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
        // ----------------------- События ---------------------------

        /// <summary>
        /// Событие, уведомляющее об изменении состояния вызова команды.
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        // -------------------- Поля и свойства ----------------------

        /// <summary>
        /// Полек функции команды.
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
        /// Поле, хранящее возможность выполнения команды.
        /// </summary>
        private bool _isExecutable = true;

        /// <summary>
        /// Свойство, хранящее свойство возможности выполнения команды.
        /// </summary>
        public bool IsExecutable
        {
            get => _isExecutable;
            set 
            {
                if (!Equals(value, _isExecutable))
                {
                    _isExecutable = value;
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Инвертированное свойство возможности выполнения команды.
        /// </summary>
        public bool ReversedIsExecutable
        {
            get => !IsExecutable;
        }

        // ----------------------------- Конструкторы ---------------------------------

        /// <summary>
        /// Конструктор команды с аргументом функции.
        /// </summary>
        /// <param name="action"> Делегат. </param>
        public Command(Action<object> action, bool isExecutable = true)
        {
            ExecutionCommand = action;
            IsExecutable = isExecutable;
        }

        // ------------------ Методы -----------------------

        /// <summary>
        /// Функция, уведомляющее можно ли вызвать команду.
        /// </summary>
        /// <param name="parameter"> Параметр функции. </param>
        /// <returns> Можно ли вызвать команду. </returns>
        public bool CanExecute(object? parameter)
        {
            return IsExecutable;
        }

        /// <summary>
        /// Вызвать функцию команды.
        /// </summary>
        /// <param name="parameter"> Параметр команды. </param>
        public void Execute(object? parameter)
        {
            ExecutionCommand(parameter);
        }
    }
}
