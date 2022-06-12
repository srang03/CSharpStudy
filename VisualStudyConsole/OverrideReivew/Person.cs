namespace OverrideReivew
{
    public class Person
    {
        private string _name;
        public Person(string name)
        {
            this._name = name;
        }

        public override string ToString()
        {
            return $"Person [{this._name}]";

        }
    }
}
