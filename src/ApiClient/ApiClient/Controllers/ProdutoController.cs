using ApiClient.Configurations.Authorization;
using ApiClient.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/Produto
        [Authorize(Actions.ProdutoRead)]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Produto/5
        [Authorize(Actions.ProdutoRead)]
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(new Produto("Desodorante", "Desodorante aerosol", Decimal.Parse("9,55")));
        }

        // POST: api/Produto
        [Authorize(Actions.ProdutoCreate)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Produto produto)
        {
            return Ok(produto);
        }

        // PUT: api/Produto/5
        [Authorize(Actions.ProdutoUpdate)]
        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] Produto produto)
        {
            return Ok(produto);
        }

        // DELETE: api/ApiWithActions/5
        [Authorize(Actions.ProdutoDelete)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(new Produto("Desodorante", "Desodorante aerosol", Decimal.Parse("9,55")));
        }
    }
}
