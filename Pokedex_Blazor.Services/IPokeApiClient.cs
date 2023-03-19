using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokedex_Blazor.Models;

namespace Pokedex_Blazor.Services
{
    public interface IPokeApiClient
    {
        Task<ResultObject> GetAllPokemons(PaginationParameters parameters);
        Task<Pokemon> GetPokemon(string Name);
    }
}
