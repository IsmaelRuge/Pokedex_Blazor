using Newtonsoft.Json;
using Pokedex_Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex_Blazor.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private readonly HttpClient _httpclient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public async Task<ResultObject> GetAllPokemons(PaginationParameters parameters)
        {
            return JsonConvert.DeserializeObject<ResultObject>(
            await _httpclient.GetStringAsync($"pokemon?limit={parameters.PageSize}&offset={parameters.Offset}"));
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(
            await _httpclient.GetStringAsync($"pokemon/{name}"));
        }
    }
}
