using demo.Model.Interfaces;

namespace demo.Model
{
    public class Repository : IRepository
    {
        private ApplicationDbcontext dbcontext;
        public Repository(ApplicationDbcontext dbcontext) =>this.dbcontext = dbcontext;

        public IQueryable<Contratto> contrattos => dbcontext.contrattos;


        public IQueryable<Dipendenti> dipendentis => dbcontext.dipendentis;

        public IQueryable<Cliente> clientes => dbcontext.clientes;



    }
}
