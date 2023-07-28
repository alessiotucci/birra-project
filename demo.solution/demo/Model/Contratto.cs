using Microsoft.AspNetCore.Mvc;

namespace demo.Model
{
    public class Contratto
    {
       // public string agenteCf  { get; set; }

       // public int PivaCliente { get; set; }

        public int Id { get; set; }

        public string cadenza { get; set; }

        public string prodotto { get; set; }
        public int quantita { get; set; }

        public Contratto(/*string agentecf, int pivacliente,*/ int id, string cadenza, string prodotto, int quantita)
        {
         //   this.agenteCf = agentecf;
           // this.PivaCliente = pivacliente;
            Id = id;
            this.cadenza = cadenza;
            this.prodotto = prodotto;
            this.quantita = quantita;
        }
    }
}
