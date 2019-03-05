namespace CrossTestApp.Models
{
    public class TestModel : BaseModel
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                Set(ref _text, value, "Text");
            }
        }

        public TestModel()
        {
            Text = "Start";
        }
    }
}
