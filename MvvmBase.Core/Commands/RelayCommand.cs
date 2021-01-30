using System;

namespace MvvmBase.Core.Commands
{
    public class RelayCommand : IRelayCommand<object>
    {
        private readonly Action _command;
        private readonly Predicate<object> _canExecuteCommand;

        public Predicate<object> CanExecuteCommand
        {
            get { return _canExecuteCommand; }
        }

        public RelayCommand(Action command,
                            Predicate<object> canExecuteCommand)
        {
            _command = command;
            _canExecuteCommand = canExecuteCommand;
        }

        public RelayCommand(Action commandAction)
            : this(commandAction, p => true)
        {
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecuteCommand(parameter);
        }

        public void Execute(object parameter)
        {
            _command();
        }
    }
}
