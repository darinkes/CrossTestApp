using CrossTestApp.Models;

namespace CrossTestApp.ViewModels
{

    public class MainWindowViewModel
    {
        private TestModel myVar;

        public TestModel MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public MainWindowViewModel()
        {
            MyProperty = new TestModel();
        }
    }
}
