using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GlobalWeb.API.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientApplication _clientService;

        public ClientController(IClientApplication clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _clientService.GetAll());
        }

        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _clientService.Get(id));
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientRequest body)
        {
            await _clientService.Add(body);
            return Ok(true);
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClientRequest body)
        {
            await _clientService.Update(id, body);
            return Ok(true);
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _clientService.Delete(id);
            return Ok(true);
        }
    }
}
