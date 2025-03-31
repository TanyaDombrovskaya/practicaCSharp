namespace GNS
{
    public class StealthDecorator : IGameCharacter
    {
        private readonly IGameCharacter _character;

        public StealthDecorator(IGameCharacter character)
        {
            _character = character;
        }

        public string GetAbilities()
        {
            return $"{_character.GetAbilities()}, Скрытность.";
        }
    }
}
