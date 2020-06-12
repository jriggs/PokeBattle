using System;
using System.Collections.Generic;
using System.Text;

namespace PokeBattle
{
    class PokeArena
    {
        private Trainer player1;
        private Trainer player2;
        
        //this class will drive the battle until there is a winner

        public PokeArena()
        {

            //need to add logic to get players and their pokemon
            //if we are keeping the default constructor

        }
        public PokeArena(Trainer player1, Trainer player2)
        {
            this.player1 = player1;
            this.player2 = player2;

            //Console.WriteLine(Object.ReferenceEquals(this.player1, player1));
        }

        public string Battle()
        {
            string returnWinner;

            while( player1.BattlePoke.Health > 0 && player2.BattlePoke.Health > 0 )
            {
                player1.ChooseAttack("electric", player2.BattlePoke);
            }

            if( player1.BattlePoke.Health > player2.BattlePoke.Health )
            {
                returnWinner = "Player 1";
            } else
            {
                returnWinner = "Player 2";
            }

            return $"{returnWinner} was victorious using {player1.BattlePoke.Name}";
        }
    }
}
