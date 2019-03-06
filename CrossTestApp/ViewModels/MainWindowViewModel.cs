using CrossTestApp.Models;
using System;

namespace CrossTestApp.ViewModels
{

    public class MainWindowViewModel : BaseModel
    {
        private TestModel myVar;

        public TestModel MyProperty
        {
            get { return myVar; }
            set
            {
                Set(ref myVar, value, "MyProperty");
            }
        }

        public MainWindowViewModel()
        {
            MyProperty = new TestModel();
        }

        public void DoSomething()
        {
            if (MyProperty.Text == TestModel.DefaultText)
                MyProperty.Text = "Yeah!";
            else
                MyProperty.Text = TestModel.DefaultText;

            MyProperty.Collection.Add(DateTime.Now);
        }
    }
}
