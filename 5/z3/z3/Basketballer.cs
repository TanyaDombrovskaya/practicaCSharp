using System.Xml.Linq;

namespace TeamNamespace
{
    public class Basketballer : TeamMember, IBasketballPlayer
    {
        public Basketballer(string name) : base(name) { }

        public void PlayBasketball()
        {
            Console.WriteLine($"{Name} играет в баскетбол.");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Роль: Баскетболист");
        }
    }
}
