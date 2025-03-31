namespace GNS
{
    public class PowerAttackDecorator : IGameCharacter
    {
        private readonly IGameCharacter _character;

        public PowerAttackDecorator(IGameCharacter character)
        {
            _character = character;
        }

        public string GetAbilities()
        {
            return $"{_character.GetAbilities()}, Мощная атака.";
        }
    }

}
