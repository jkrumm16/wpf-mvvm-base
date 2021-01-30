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

        public DemoViewModel()
        {
            Message = "It works!";
        }
    }
}
