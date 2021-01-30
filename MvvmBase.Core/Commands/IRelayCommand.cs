using System;
using System.Windows.Input;

namespace MvvmBase.Core.Commands
{
    public interface IRelayCommand<TCommandParameter> : ICommand
    {
        Predicate<TCommandParameter> CanExecuteCommand { get; }
    }
}
