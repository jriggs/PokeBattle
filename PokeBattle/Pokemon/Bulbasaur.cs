using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle.Pokemon
{
    public class Bulbasaur : PokeBase 
    {
        public Bulbasaur() : base("Bulbasaur", "Grass", 130)
        {
            Attacks.Add(base.Name, new Attack("mow", base.Type, 20));
            Attacks.Add(base.Name +1, new Attack("graze", base.Type, 5));
        }
    }
}
