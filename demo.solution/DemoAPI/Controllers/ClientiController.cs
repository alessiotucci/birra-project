using demo.Model.Interfaces;
using demo.Model;
using Microsoft.AspNetCore.Mvc;
using DemoAPI.Model.Interfaces;

namespace DemoAPI.Controllers
{
    public class ClientiController : Controller
    {
        private IRepositoryCliente repository;

        public ClientiController(IRepositoryCliente repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Cliente> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Cliente GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Cliente Post([FromBody] Cliente cliente)
        {
            return repository.Add(cliente);
        }

        [HttpPut]
        public Cliente Put([FromBody] Cliente cliente)
        {
            return repository.Update(cliente);
        }

        [HttpDelete("{id:int}")]
        public Cliente Delete([FromBody] int id)
        {
            return repository.Remove(id);
        }
    }
}

