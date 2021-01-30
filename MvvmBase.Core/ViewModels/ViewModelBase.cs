using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MvvmBase.Core.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected ViewModelBase()
        {
            InitializeAllStringProperties(string.Empty);
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;

            field = value;

            OnPropertyChanged(propertyName);

            return true;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitializeAllStringProperties(string initialValue)
        {
            GetType().GetProperties().Where(p => p.PropertyType == typeof(string))
                                     .Where(p => p.GetValue(this) == null)
                                     .ToList()
                                     .ForEach(p => p.SetValue(this, initialValue));
        }
    }
}
