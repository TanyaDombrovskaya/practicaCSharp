using GNS;
using System;

class Task2
{
    static void Main()
    {
        IGameCharacter character = new BaseCharacter();
        Console.WriteLine(character.GetAbilities());

        character = new StealthDecorator(character);
        Console.WriteLine(character.GetAbilities());

        character = new PowerAttackDecorator(character);
        Console.WriteLine(character.GetAbilities()); 

        character = new HealingDecorator(character);
        Console.WriteLine(character.GetAbilities());
    }
}
