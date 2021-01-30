using MvvmBase.Core.Commands;
using MvvmBase.Core.ViewModels;

namespace MvvmBase.Demo.ViewModels
{
    public class DemoViewModel : ViewModelBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetField(ref _message, value); }
        }

        public RelayCommand ButtonClickedCommand { get; init; }

        public DemoViewModel()
        {
            Message = "It works!";
            ButtonClickedCommand = new RelayCommand(() => Message = "Clicked!");
        }
    }
}
