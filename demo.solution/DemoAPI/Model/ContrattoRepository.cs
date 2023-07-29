using demo.Model.Interfaces;

namespace demo.Model
{
    public class ContrattoRepository : IRepositoryContratto
    {
        private ApplicationDbcontext dbcontext; //istanza del db su cui lavoreremo 
        public ContrattoRepository(ApplicationDbcontext context)
        {
            this.dbcontext = context;
        }
        public List<Contratto> GetAll()
        {
            return dbcontext.Contratti.ToList();
        }
        public Contratto Add(Contratto contratto)
        {
            var result = dbcontext.Contratti.Add(contratto); 
            dbcontext.SaveChanges();
            return result.Entity;
        }

        public Contratto GetById(int id)
        {
            return dbcontext.Contratti.Where(d => d.Id == id).SingleOrDefault();
        }

        public Contratto Update(Contratto ModificaContratto)
        {
            var result = dbcontext.Contratti.Update(ModificaContratto).Entity;
            dbcontext.SaveChanges();
            return result;
        }


        public Contratto Remove(int id)
        {
            var result = dbcontext.Contratti.Remove(GetById(id)).Entity;
            dbcontext.SaveChanges();
            return result;
        }

    }
}
