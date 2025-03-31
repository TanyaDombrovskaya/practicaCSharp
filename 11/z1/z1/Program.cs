using ANS;

class Task1
{
    static void Main()
    {
        AnimalFactory dogFactory = new DogFactory();
        AnimalFactory catFactory = new CatFactory();
        AnimalFactory birdFactory = new BirdFactory();

        IAnimal dog = dogFactory.CreateAnimal();
        IAnimal cat = catFactory.CreateAnimal();
        IAnimal bird = birdFactory.CreateAnimal();

        dog.MakeSound();
        cat.MakeSound(); 
        bird.MakeSound();
    }
}
