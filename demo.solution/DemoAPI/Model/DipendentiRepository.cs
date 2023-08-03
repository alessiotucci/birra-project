using demo.Model;
using DemoAPI.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.Model
{
    public class DipendentiRepository : IRepositoryDipendenti
    {
        private ApplicationDbcontext dbcontext; //istanza del db su cui lavoreremo 

        public DipendentiRepository(ApplicationDbcontext context)
        {
            this.dbcontext = context;
        }
        public List<Dipendenti> GetAll()
        {
            return dbcontext.Dipendenti.ToList();
        }
        public Dipendenti Add(Dipendenti dipendente)
        {
            var result = dbcontext.Dipendenti.Add(dipendente);
            dbcontext.SaveChanges();
            return result.Entity;
        }

        public Dipendenti GetById(int id)
        {
            return dbcontext.Dipendenti.Where(d => d.Id == id).SingleOrDefault();
        }

        public Dipendenti Update(Dipendenti modificaDipendenti)
        {
            var result = dbcontext.Dipendenti.Update(modificaDipendenti).Entity;
            dbcontext.SaveChanges();
            return result;
        }


        public Dipendenti Remove(int id)
        {
            var result = dbcontext.Dipendenti.Remove(GetById(id)).Entity;
            dbcontext.SaveChanges();
            return result;
        }

    }
}
