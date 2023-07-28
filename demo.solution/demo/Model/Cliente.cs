namespace demo.Model
{
    public class Cliente 
    {
        public Agente Agente { get; set; }
        public int Piva { get; set; }

        public string Nome { get; set; }

        public string Cognome { get; set; }
        public string Tipologia { get; set; } // da aquisire o cliente fisso
        Contratto Contratto { get; set; }

        public Cliente(Agente agente, int piva, string nome, string cognome, string tipologia, Contratto contratto)
        {
            Agente = agente;
            Piva = piva;
            Nome = nome;
            Cognome = cognome;
            Tipologia = tipologia;
            Contratto = contratto;
        }
    }
}
