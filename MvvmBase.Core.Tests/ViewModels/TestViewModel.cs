using MvvmBase.Core.Commands;
using MvvmBase.Core.ViewModels;

namespace MvvmBase.Core.Tests.ViewModels
{
    internal sealed class TestViewModel : ViewModelBase
    {
        private string _stringPropertyA;

        public string StringPropertyA
        {
            get { return _stringPropertyA; }
            set { SetField(ref _stringPropertyA, value); }
        }

        private string _stringPropertyB;

        public string StringPropertyB
        {
            get { return _stringPropertyB; }
            set { SetField(ref _stringPropertyB, value); }
        }

        private int _intProperty;

        public int IntProperty
        {
            get { return _intProperty; }
            set { SetField(ref _intProperty, value); }
        }

        private object _objectProperty;

        public object ObjectProperty
        {
            get { return _objectProperty; }
            set { SetField(ref _objectProperty, value); }
        }

        public RelayCommand DoNothingCommand { get; }

        public RelayCommand ModifyObjectPropertyCommand { get; }

        public ParameterizedRelayCommand<int> ModifyIntPropertyCommand { get; }


        public TestViewModel()
        {
            DoNothingCommand = new RelayCommand(() => { });

            ModifyObjectPropertyCommand = new RelayCommand(() => 
            {
                ObjectProperty = new TestObject
                {
                    TestValue = "Test"
                };
            });

            ModifyIntPropertyCommand = new ParameterizedRelayCommand<int>((i) => 
            { 
                IntProperty += i; 
            });
        }
    }
}
