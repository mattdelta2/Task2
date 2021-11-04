using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Hero
    {
        public Hero(int _X, int _Y, TileType _TYPEOFTILE, string _SYMBOL, int _HP, int _MAXHP, int _DAMAGE )
        {

        }

        public override MovementDirection ReturnMove(MovementDirection CharacterMove  = MovementDirection.NoMovement)
        {
            if (CheckForValidMove(CharacterMove))
            {
                return CharacterMove;

            }
            else return MovementDirection.NoMovement;

        }

        public override string ToString()
        {
            string INFO = "Player Stats: \n";
            INFO += "HP: " + HP.ToString() + "/" + MAXHP.ToString() + "\n";
            INFO += "Damage: " + DAMAGE.ToString()
        }

    }
}
