using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class PokemonController : ApiController
    {
        // GET api/<controller>
        public List<Pokemon> Get()
        {
            return PokemonData.Listar();
        }

        // GET api/<controller>/5
        public Pokemon Get(int id)
        {
            return PokemonData.Obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody] Pokemon oPokemon)
        {
            return PokemonData.Registrar(oPokemon);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Pokemon oPokemon)
        {
            return PokemonData.Modificar(oPokemon);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return PokemonData.Eliminar(id);
        }
    }
}