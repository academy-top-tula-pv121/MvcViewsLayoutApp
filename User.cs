namespace MvcViewsLayoutApp
{
    public class User
    {
        public string Name { get; set; }
        public int Age { set; get; }
        public User() { }
        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
