using System.ComponentModel;
using System.Diagnostics;

namespace CrossTestApp.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void Set<T>(ref T property, T value, string name)
        {
            property = value;
            Debug.WriteLine("{0} {1}", name, value);
            RaisePropertyChanged(name);
        }

        private void RaisePropertyChanged(string property)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
    }
}