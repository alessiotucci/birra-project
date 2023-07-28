
namespace demo.Model
{
    public class Agente : dipendenti
    {

        Contratto Contratto { get; set; }

        Cliente Cliente { get; set; }  


        public Agente(string _cf, string _nome, string _cognome, string _ruolo, Cliente _cliente, Contratto _contratto) : base(_cf, _nome, _cognome, _ruolo)
        {
            Contratto = _contratto;
            Cliente = _cliente;
        }
    }
    
}
