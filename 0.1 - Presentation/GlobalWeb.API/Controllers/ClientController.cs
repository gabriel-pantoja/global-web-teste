using GlobalWeb.Application.Interfaces;
using GlobalWeb.Domain.Request;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GlobalWeb.API.Controllers
{
    [Route("api/[controller]")]
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
            return Ok(await _clientService.GetAll());
        }

        // POST api/<ClientController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ClientRequest body)
        {
            return Ok(await _clientService.Add(body));
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ClientRequest body)
        {
            return Ok(await _clientService.Update(body));
        }

        // DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _clientService.Delete(id));
        }
    }
}
