namespace TeamNamespace
{
    public class TeamMember
    {
        public string Name { get; set; }

        public TeamMember(string name)
        {
            Name = name;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Игрок: {Name}");
        }
    }
}
