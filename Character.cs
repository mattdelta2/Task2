﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Character
    {
        public int characterMaxHP;
        public int characterDamage;
        public int characterHP;

        public int GoblinMaxHP;
        public int GoblinDamage;
        public int GoblinHP;



        public enum Movement
        {
            NoMovement,
            Up,
            Down,
            Right,
            Left,
        }

        public bool isDead;

        public bool CheckRange;
    }
}
