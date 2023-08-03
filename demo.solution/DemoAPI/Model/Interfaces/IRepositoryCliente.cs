using demo.Model;

namespace DemoAPI.Model.Interfaces
{
    public interface IRepositoryCliente
    {
        public List<Cliente> GetAll();
        public Cliente Add(Cliente cliente);
        public Cliente GetById(int id);

        public Cliente Update(Cliente cliente);
        public Cliente Remove(int id);

    }
}
