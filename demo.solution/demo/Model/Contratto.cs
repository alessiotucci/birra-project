using Microsoft.AspNetCore.Mvc;

namespace demo.Model
{
    public class Contratto
    {
        public Agente agente  { get; set; }

        public Cliente cliente { get; set; }

        public int Id { get; set; }

        public string cadenza { get; set; }

        public string prodotto { get; set; }
        public int quantita { get; set; }

        public Contratto(Agente agente, Cliente cliente, int id, string cadenza, string prodotto, int quantita)
        {
            this.agente = agente;
            this.cliente = cliente;
            Id = id;
            this.cadenza = cadenza;
            this.prodotto = prodotto;
            this.quantita = quantita;
        }
    }
}
