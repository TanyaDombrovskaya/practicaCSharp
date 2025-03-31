namespace GNS
{
    public class HealingDecorator : IGameCharacter
    {
        private readonly IGameCharacter _character;

        public HealingDecorator(IGameCharacter character)
        {
            _character = character;
        }

        public string GetAbilities()
        {
            return $"{_character.GetAbilities()}, Лечение.";
        }
    }

}
