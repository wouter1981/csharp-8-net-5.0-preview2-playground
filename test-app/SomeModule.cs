namespace test_app
{
    public class SomeModule
    {
        private string _name = "";
        public string Name {
            get {
                return _name;
            }
            set {
                if (value.Length >= 1) {
                    value = value.Substring(0,1).ToUpperInvariant() + value.Substring(1);
                }
                _name = value;
            }
        }

        public string Greeting {
            get {
                return "Hello " + _name;
            }
        }

    }
}