using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Pokemon_Trainer
{
    class Trainer
    {
        public string Name { get; set; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public Trainer(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
        }


        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void IncreaseBadges()
        {
            Badges++;
        }

        public void ReducePokemonsHealth()
        {
            foreach(var p in Pokemons)
            {
                p.ReduceHealth();
            }
        }

        public void RemoveDead()
        {
            List<Pokemon> result = new List<Pokemon>();
            foreach(var p in Pokemons)
            {
                if(p.Health > 0)
                {
                    result.Add(p);
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }
}
