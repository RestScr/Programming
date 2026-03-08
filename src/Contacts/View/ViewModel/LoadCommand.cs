using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
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

        public void Execute(object? parameter)
        {
            ExecutionCommand(parameter);
        }

        public LoadCommand(Action<object> executionCommand)
        {
            ExecutionCommand = executionCommand;
        }
    }
}
