using Multitenancy.Core.Interfaces;
using Multitenancy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multitenancy.Core.Repositories
{
    public class PokemonDataRepository : IDataRepository
    {
        readonly List<Item> items;

        public PokemonDataRepository()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "granbull", Description="su personalidad afable y algo miedosa hacen de él un pésimo guardián." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "gligar", Description="tipo tierra/volador introducido en la segunda generación. " },
                new Item { Id = Guid.NewGuid().ToString(), Text = "piloswine", Description="Aunque tiene las patas cortas, sus fuertes pezuñas le permiten caminar por la nieve sin resbalar." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "skarmory", Description="Aparece a menudo en escudos heráldicos, pues se pueden forjar espadas a partir de las plumas que pierde." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "tyrogue", Description="Su pequeño tamaño no debe ser motivo para subestimarlo, ya que se liará de inmediato a golpes con cualquier rival que estime oportuno." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "suicune", Description="Suele corretear por el campo con gran elegancia." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}