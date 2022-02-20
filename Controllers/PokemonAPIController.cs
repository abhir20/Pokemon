using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Pokemon360.Business;
using System.Net;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

/*
 * Developed by :Abhinaya R, Date : 2/19/2022
 * Web api controller class that invokes business class methods
 */


namespace Pokemon360.Controllers
{
    [Route("api/GetPokemon")]
    [ApiController]
    public class PokemonAPIController : ControllerBase
    {
        IReadData readPokemons = null;
         public PokemonAPIController(IReadData readPokemons)
        {
            this.readPokemons = readPokemons; // Dependancy injection
        }

        [HttpGet]
        public HttpResponseMessage Pokemon()
        {
            IList<Pokemon> pokemonLists = new List<Pokemon>();

            if (pokemonLists == null)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);

            pokemonLists = readPokemons.GetPokemons();

            if (pokemonLists.Count > 0)
            {

                // Tried adding list to response body
                string json = JsonConvert.SerializeObject(pokemonLists, Formatting.Indented);
            }
            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        // GET: api/<PokemonAPIController>
        
        // POST api/<PokemonAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PokemonAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PokemonAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
