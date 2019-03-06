using System;
using System.Collections.ObjectModel;

namespace CrossTestApp.Models
{
    public class TestModel : BaseModel
    {
        public static readonly string DefaultText = "Start!";

        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                Set(ref _text, value, "Text");
            }
        }

        public ObservableCollection<DateTime> Collection { get; set; }

        public TestModel()
        {
            Text = DefaultText;
            Collection = new ObservableCollection<DateTime>();
        }
    }
}
