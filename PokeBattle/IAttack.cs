namespace PokeBattle
{
    public interface IAttack
    {
        int BaseDamage { get; }
        string Name { get; }
        string Type { get; }
    }
}