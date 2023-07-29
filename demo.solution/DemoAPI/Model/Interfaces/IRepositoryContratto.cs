namespace demo.Model.Interfaces
{
    public interface IRepositoryContratto
    {
        public List<Contratto> GetAll();
        public Contratto Add(Contratto contratto);
        public Contratto GetById(int id);

        public Contratto Update(Contratto ModificaContratto);
        public Contratto Remove(int id);

    }
}
