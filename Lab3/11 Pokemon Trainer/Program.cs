using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_Pokemon_Trainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string[] input = {"begin"};

            while (input[0] != "Tournament")
            {
                
                input = Console.ReadLine().Split(' ');
                if (input[0] == "Tournament") break;
                string trainerName = input[0];
                string pokemonName = input[1];
                string pokemonElement = input[2];
                int pokemonHealth = Convert.ToInt32(input[3]);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                Trainer trainer = trainers.First(t => t.Name == trainerName);

                trainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

             
            }

            while ((input[0] = Console.ReadLine()) != "End")
            {
                
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == input[0]))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();
                        trainer.RemoveDead();
                    }
                }
            }

            trainers.OrderByDescending(t => t.Badges).ToList().ForEach(Console.WriteLine);
            Console.ReadKey();

        }
    }
}
