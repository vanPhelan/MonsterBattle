using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    struct Monster
    {
        public float attack;
        public float defense;
        public float health;
    }

    class Game
    {
        public void Run()
        {
            //Monster 1
            Monster goblin = new Monster { attack = 10, defense = 5, health = 20 };

            //Monster 2
            Monster slime = new Monster { attack = 15, defense = 10, health = 15 };

            //Monster 3
            Monster skeleton = new Monster { attack = 20, defense = 5, health = 10 };

            //Monster 1 attacks Monster 2
            float damageTaken = CalculateDamage(goblin.attack, slime.defense);
            slime.health = slime.health - damageTaken;
            Console.WriteLine("Slime has taken " + damageTaken + " damage and has " + slime.health + " health remaining.");

            //Monster 2 attacks Monster 1
            damageTaken = CalculateDamage(slime.attack, goblin.defense);
            goblin.health = goblin.health - damageTaken;
            Console.WriteLine("Goblin has taken " + damageTaken + " damage and has " + goblin.health + " health remaining.");

            //Monster 3 attacks Monster 1
            damageTaken = CalculateDamage(skeleton, goblin);
            goblin.health -= damageTaken;
            Console.WriteLine("Goblin has taken " + damageTaken + " damage and has " + goblin.health + " health remaining.");

            //Monster 3 attacks Monster 2
            damageTaken = CalculateDamage(skeleton, slime);
            slime.health -= damageTaken;
            Console.WriteLine("Slime has taken " + damageTaken + " damage and has " + slime.health + " health remaining.");
        }

        float CalculateDamage(float attack, float defense)
        {
            float damage = attack - defense;
            
            return damage;
        }

        float CalculateDamage(Monster attacker, Monster defender)
        {
            return attacker.attack - defender.defense;
        }
    }
}
