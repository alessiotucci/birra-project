using demo.Model;

namespace DemoAPI.Model.Interfaces
{
    public interface IRepositoryDipendenti
    {
        public List<Dipendenti> GetAll();
        public Dipendenti Add(Dipendenti dipendente);
        public Dipendenti GetById(int id);

        public Dipendenti Update(Dipendenti dipendenti);
        public Dipendenti Remove(int id);
    }
}
