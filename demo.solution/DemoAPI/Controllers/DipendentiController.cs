using demo.Model.Interfaces;
using demo.Model;
using Microsoft.AspNetCore.Mvc;
using DemoAPI.Model.Interfaces;

namespace DemoAPI.Controllers
{
    public class DipendentiController : Controller
    {

        private IRepositoryDipendenti repository;

        public DipendentiController(IRepositoryDipendenti repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public List<Dipendenti> GetAll()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Dipendenti GetById(int id)
        {
            return repository.GetById(id);
        }
        [HttpPost]
        public Dipendenti Post([FromBody] Dipendenti dipendenti)
        {
            return repository.Add(dipendenti);
        }

        [HttpPut]
        public Dipendenti Put([FromBody] Dipendenti dipendenti)
        {
            return repository.Update(dipendenti);
        }

        [HttpDelete("{id:int}")]
        public Dipendenti Delete([FromBody] int id)
        {
            return repository.Remove(id);
        }
    }
}

