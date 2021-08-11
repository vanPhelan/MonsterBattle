using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    class Game
    {
        public void Run()
        {
            float monsterAttack = 10;
            float monsterDefense = 5;
            float monsterHealth = 20;

            float damageTaken = CalculateDamage(monsterAttack, monsterDefense);
            monsterHealth = monsterHealth - damageTaken;

            Console.WriteLine("Monster has taken " + damageTaken + " damage and has " + monsterHealth + " health remaining.");
        }

        float CalculateDamage(float attack, float defense)
        {
            float damage = attack - defense;
            
            return damage;
        }
    }
}
