using System;
using System.Collections.Generic;
using System.Text;

using PokeBattle.Pokemon;

namespace PokeBattle
{
    public class Trainer
    {

        public List<PokeBase> Pokemon { get; private set; } = new List<PokeBase>();
        public PokeBase BattlePoke { get; private set; }

        //adds single card to trainers deck
        public void SelectCard(PokeBase pokemon)
        {
            Pokemon.Add(pokemon);
        }
        //adds multiple card to trainers deck
        public void SelectCard(PokeBase[] pokemon)
        {
            Pokemon.AddRange(pokemon);
        }

        public void SelectCard(PokeBase[] pokemon, bool defaultHealth)
        {
            Pokemon.AddRange(pokemon);
        }
        public void ChoosePokeForBattle(PokeBase pokemon)
        {
            BattlePoke = pokemon;
        }

        public void ChooseAttack(string attackType, PokeBase victim)
        {
            //hard coded, but need to change to ask user
            string attackName = BattlePoke.AvailableAttacks[0];
            IAttack attack = BattlePoke.Attacks[attackName];
            BattlePoke.PerformAttack(attack, victim);
        }
    }
}
