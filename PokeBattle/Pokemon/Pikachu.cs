using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle.Pokemon
{
    public class Pikachu : PokeBase 
    {
        public Pikachu() : base("Pikachu", "Electric", 100)
        {
            Attacks.Add(base.Name, new Attack("shock", base.Type, 20));
            Attacks.Add(base.Name +1, new Attack("stun", base.Type, 5));
        }
    }
}
