using MvvmBase.Demo.ViewModels;

namespace MvvmBase.Demo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new DemoViewModel();
        }
    }
}
