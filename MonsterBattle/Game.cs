using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class Game
    {
        public void Run()
        {
            //Monster 1
            float monster1Attack = 10;
            float monster1Defense = 5;
            float monster1Health = 20;

            //Monster 2
            float monster2Attack = 15;
            float monster2Defense = 10;
            float monster2Health = 15;

            //Monster 1 attacks Monster 2
            float damageTaken = CalculateDamage(monster1Attack, monster2Defense);
            monster2Health = monster2Health - damageTaken;
            Console.WriteLine("Monster 2 has taken " + damageTaken + " damage and has " + monster2Health + " health remaining.");

            //Monster 2 attacks Monster 1
            monster1Health = monster1Health - CalculateDamage(monster2Attack, monster1Defense);
            Console.WriteLine("Monster 1 has taken " + damageTaken + " damage and has " + monster1Health + " health remaining.");
        }

        float CalculateDamage(float attack, float defense)
        {
            float damage = attack - defense;
            
            return damage;
        }
    }
}
