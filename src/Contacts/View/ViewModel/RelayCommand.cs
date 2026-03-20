using System.Windows.Input;

namespace View.ViewModel;

/// <summary>
/// Общий класс команд.
/// </summary>
public class RelayCommand : ICommand
{
    /// <summary>
    /// Событие изменения возможности выполнения.
    /// </summary>
    public event EventHandler? CanExecuteChanged;

    /// <summary>
    /// Поле, хранящее функцию выполнения команды.
    /// </summary>
    private Action<object> _executionCommand;

    /// <summary>
    /// Поле, хранящее возможность выполнения команды.
    /// </summary>
    private bool _isExecutable;

    /// <summary>
    /// Свойство функции выполнения команды.
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
    /// Свойство возможности выполнения команды.
    /// </summary>
    public bool IsExecutable
    {
        get => _isExecutable;
        set 
        { 
            _isExecutable = value;
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Конструктор команды.
    /// </summary>
    /// <param name="executionCommand"> Функция выполнения команды. </param>
    public RelayCommand(Action<object> executionCommand, bool isExecutable=true)
    {
        ExecutionCommand = executionCommand;
        IsExecutable = isExecutable;
    }

    /// <summary>
    /// Метод возвращения возможности выполнения команды.
    /// </summary>
    /// <param name="parameter"> Дополнительный параметр функции команды. </param>
    /// <returns></returns>
    public bool CanExecute(object? parameter)
    {
        return IsExecutable;
    }

    /// <summary>
    /// Метод выполнения функции команды.
    /// </summary>
    /// <param name="parameter"></param>
    public void Execute(object? parameter)
    {
        ExecutionCommand(parameter);
    }
}
