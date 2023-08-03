using demo.Model;
using DemoAPI.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Model
{
    public class ClienteRepository : IRepositoryCliente
    {
        private ApplicationDbcontext dbcontext; //istanza del db su cui lavoreremo 

        public ClienteRepository(ApplicationDbcontext context)
        {
            this.dbcontext = context;
        }
        public List<Cliente> GetAll()
        {
            return dbcontext.Clienti.ToList();
        }
        public Cliente Add(Cliente cliente)
        {
            var result = dbcontext.Clienti.Add(cliente);
            dbcontext.SaveChanges();
            return result.Entity;
        }

        public Cliente GetById(int id)
        {
            return dbcontext.Clienti.Where(d => d.Id == id).SingleOrDefault();
        }

        public Cliente Update(Cliente modificaCliente)
        {
            var result = dbcontext.Clienti.Update(modificaCliente).Entity;
            dbcontext.SaveChanges();
            return result;
        }


        public Cliente Remove(int id)
        {
            var result = dbcontext.Clienti.Remove(GetById(id)).Entity;
            dbcontext.SaveChanges();
            return result;
        }

    }
}
