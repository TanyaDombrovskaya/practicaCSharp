namespace ANS
{
    public class BirdFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal()
        {
            return new Bird();
        }
    }
}
