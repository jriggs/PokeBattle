using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle.Pokemon
{
    public abstract class PokeBase
    {
        public int Health { get; private set; }
        public string Name { get; }
        public string Type { get; }

        public string[] AvailableAttacks
        {
            get
            {
                List<string> keys = new List<string>(Attacks.Keys);
                return keys.ToArray();
            }
        }
        public Dictionary<string, IAttack> Attacks { get; } = new Dictionary<string, IAttack>();
        public PokeBase(string name, string type, int health)
        {
            this.Name = name;
            this.Health = health;//do types have different health values
            this.Type = type;
        }

        public void PerformAttack(IAttack attack, PokeBase victim)
        {
            victim.TakeDamage(attack);
        }

        public void TakeDamage(IAttack attack)
        {
            this.Health -= attack.BaseDamage;
        }

        static public Dictionary<string, PokeBase> pokes = new Dictionary<string, PokeBase> 
        {
            {"Pikachu" , new Pikachu() },
            {"Pikachu2" , new Pikachu() },
            {"Pikachu3" , new Pikachu() }
        };
    }
}
