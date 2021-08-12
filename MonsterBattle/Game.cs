using System;
using System.Collections.Generic;
using System.Text;

namespace MonsterBattle
{
    struct Monster
    {
        public string name;
        public float attack;
        public float defense;
        public float health;
    }

    class Game
    {
        public void Run()
        {
            //Monster 1
            Monster goblin = new Monster { name = "Goblin", attack = 10, defense = 5, health = 20 };

            //Monster 2
            Monster slime = new Monster { name = "Slime", attack = 15, defense = 10, health = 15 };

            //Monster 3
            Monster skeleton = new Monster { name = "Skeleton", attack = 20, defense = 5, health = 10 };

            Fight(ref goblin, ref slime);
            Fight(ref slime, ref goblin);
            Fight(ref skeleton, ref goblin);
            Fight(ref skeleton, ref slime);
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

        void Fight(ref Monster attacker, ref Monster defender)
        {
            Console.WriteLine(attacker.name + " attacks " + defender.name + "!");
            float damageTaken = CalculateDamage(attacker, defender);
            defender.health -= damageTaken;
            Console.WriteLine(defender.name + " has taken " + damageTaken + " damage and has " + defender.health + " health remaining.");
        }


    }
}
