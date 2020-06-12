using System;

using PokeBattle.Pokemon;

namespace PokeBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //set in another part of the game
            Trainer player1 = new Trainer();
            Trainer player2 = new Trainer();

            PokeBase pika = new Pikachu();
            PokeBase bulbasaur = new Bulbasaur();
            
            player1.SelectCard(pika);
            

            PokeBase[] cardsToAdd = { pika, bulbasaur };

            player2.SelectCard(cardsToAdd);


            player1.ChoosePokeForBattle(pika);
            player2.ChoosePokeForBattle(bulbasaur);
            
            //////////////////////////////////////
            //////////////////////////////////////
            
            Console.WriteLine("The Battle Begins!");
            PokeArena pokeArena = new PokeArena(player1, player2);
            Console.WriteLine( pokeArena.Battle() );
            Console.ReadLine();
        }
    }
}
