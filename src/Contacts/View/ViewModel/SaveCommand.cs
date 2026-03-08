using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;

namespace View.ViewModel
{
    public class SaveCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action<object> _executionCommand;

        public Action<object> ExecutionCommand
        {
            get => _executionCommand;
            set 
            { 
                _executionCommand = value; 
            }
        }


        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public SaveCommand(Action<object> executionCommand)
        {
            _executionCommand = executionCommand;
        }

        public void Execute(object? parameter)
        {
            ExecutionCommand(parameter);
        }
    }
}
