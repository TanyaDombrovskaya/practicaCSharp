namespace PersonNamespace
{
    class Person
    {
        public int _age { get; set; }
        public string _name { get; set; }

        public Person() { }

        public Person(int age, string name)
        { 
            _age = age;
            _name = name;
        }
    }
}
