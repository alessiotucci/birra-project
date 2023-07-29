using demo.Model;
using demo.Model.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ContrattiController : ControllerBase
    {
        private IRepositoryContratto repository;

        public ContrattiController(IRepositoryContratto repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Contratto> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Contratto GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Contratto Post([FromBody] Contratto contratto)
        {
            return repository.Add(contratto);
        }

        [HttpPut]
        public Contratto Put([FromBody] Contratto contratto)
        {
            return repository.Update(contratto);
        }

        [HttpDelete("{id:int}")]
        public Contratto Delete([FromBody] int id)
        {
            return repository.Remove(id);
        }
    }
}

       

