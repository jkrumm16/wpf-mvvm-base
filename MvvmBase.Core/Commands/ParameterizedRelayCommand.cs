using System;

namespace MvvmBase.Core.Commands
{
    public class ParameterizedRelayCommand<TParameter> : IRelayCommand<TParameter>
    {
        private readonly Action<TParameter> _command;
        private readonly Predicate<TParameter> _canExecuteCommand;

        public Predicate<TParameter> CanExecuteCommand
        {
            get { return _canExecuteCommand; }
        }

        public ParameterizedRelayCommand(Action<TParameter> command,
                            Predicate<TParameter> canExecuteCommand)
        {
            _command = command;
            _canExecuteCommand = canExecuteCommand;
        }

        public ParameterizedRelayCommand(Action<TParameter> commandAction)
            : this(commandAction, p => true) 
        { 
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return _canExecuteCommand((TParameter)parameter);
        }

        public void Execute(object parameter)
        {
            _command((TParameter)parameter);
        }
    }
}
