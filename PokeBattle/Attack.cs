using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    public class Attack : IAttack
    {
        public string Type { get; }
        public string Name { get; }
        public int BaseDamage { get; }
        public Attack(string name, string type, int baseDamage)
        {
            Name = name;
            Type = type;
            BaseDamage = baseDamage;
        }
    }
}
