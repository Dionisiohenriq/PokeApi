using System.Net.Http.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using PokeApi.Client.Responses;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace PokeApi.Client
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeApiClient : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;
        private readonly string? baseUrl;

        public PokeApiClient(IConfiguration configuration, HttpClient httpClient)
        {
            _configuration = configuration;
            _httpClient = httpClient;
            baseUrl = _configuration.GetSection("PokeApi")["BaseUrl"];
        }

        /// <summary>
        /// Get All by any limit and offset
        /// </summary>
        /// <param name="offset">the offset</param>
        /// <param name="limit">Number of pokémons</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPokemonByLimit(string offset = "20", string limit = "20")
        {
            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, baseUrl?.ToString());
            request.Headers.Add("offset", offset);
            request.Headers.Add("limit", limit);

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            PokeApiGetAllResponse? pokemons = await response.Content.ReadFromJsonAsync<PokeApiGetAllResponse>();

            if (pokemons == null) return NotFound();

            return Ok(pokemons);
        }

        /// <summary>
        /// Get By pokémon Name
        /// </summary>
        /// <param name="name">The name of pokémon</param>
        /// <returns></returns>
        [HttpGet("name/{name}")]
        public async Task<IActionResult> GetPokemonByName(string name)
        {
            string url = $"{baseUrl}/{name}";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);

            HttpResponseMessage response = await _httpClient.SendAsync(request);

            response.EnsureSuccessStatusCode();

            PokeApiGetPokemonResponse? pokemon = await response.Content.ReadFromJsonAsync<PokeApiGetPokemonResponse>();

            if (pokemon == null) return NotFound();

            return Ok(pokemon);
        }

        /// <summary>
        /// Get By pokémon id
        /// </summary>
        /// <param name="id">The pokémon id</param>
        /// <returns></returns>
        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetPokemonById(string id)
        {
            string url = $"{baseUrl}/{id}";

            HttpResponseMessage response = await _httpClient.GetAsync(url);

            response.EnsureSuccessStatusCode();

            PokeApiGetPokemonResponse? pokemon = await response.Content.ReadFromJsonAsync<PokeApiGetPokemonResponse>();

            if (pokemon == null) return NotFound();

            return Ok(pokemon);
        }
    }
}
